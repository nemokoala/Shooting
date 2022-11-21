using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperFinal
{
    public partial class MineForm : Form
    {
        private int[,] field; // 지뢰찾기 필드
        public Button[,] buttons; // 클릭을 위한 버튼
        public MineForm()
        {
                InitializeComponent();

        }
        Label mine;
        Label time;
        Button btn_changediff;
        Button btn_manu;
        private int time_ = 1; // 시간
        private int diff;  //난이도
        private int bombs; //폭탄의 수
        
        private bool DontRunEvent = false;
        public void FieldInit(int x, int y, int bomb,int difficulty)
        {
            bombs = bomb;
            Choose_Difficulty(difficulty); // 난이도에 맞는 폼 설정
            field = new int[x, y]; 

            Random rnd = new Random();
            while (bomb > 0) // 필드에 지뢰 랜덤 배치
            {
                int X = rnd.Next(x);
                int Y = rnd.Next(y);
                if (field[X, Y] == -1) continue;
                field[X, Y] = -1;
                for (int bx = -1; bx <= 1; bx++)
                {
                    for (int by = -1; by <= 1; by++)
                    {
                        if (X + bx < 0) continue;
                        if (Y + by < 0) continue;
                        if (X + bx >= field.GetLength(0)) continue;
                        if (Y + by >= field.GetLength(1)) continue;
                        if (field[X + bx, Y + by] != -1)
                            field[X + bx, Y + by]++;
                    }
                }
                bomb--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = new Button[field.GetLength(0), field.GetLength(1)]; // 버튼 만들기
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    buttons[x, y] = new Button();
                    buttons[x, y].Font = new Font("Arial", 20);
                    buttons[x, y].Left = x * 40;
                    buttons[x, y].Top = y * 40;
                    buttons[x, y].Size = new Size(40, 40);
                    Controls.Add(buttons[x, y]);
                    buttons[x,y].TabStop = false;
                    buttons[x, y].MouseUp += BTN_Click; // 클릭이벤트 설정
                }
            }
        }


        private void BTN_Click(object sender, MouseEventArgs e) //게임필드 칸에 대한 클릭이벤트
        {
            if (DontRunEvent == false)
            {
                Button btn = (Button)sender;
                int x = btn.Left / 40;
                int y = btn.Top / 40;
                if (e.Button == MouseButtons.Left) //버튼 좌클릭 시
                {


                    if (field[x, y] == -1) //지뢰일 때 - 게임오버
                    {
                        timer1.Enabled = false;

                        for (int i = 0; i < field.GetLength(0); i++)
                        {
                            for (int j = 0; j < field.GetLength(1); j++)
                            {
                                if (field[i, j] == -1)
                                {
                                    buttons[i, j].Text = "\u274C";
                                    buttons[x, y].Enabled = false;
                                    
                                }
                            }
                        }
                        if (MessageBox.Show("게임 오버!\n재시작하시겠습니까?", "GameOver", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            restart();
                        }
                        else
                        {
                            DontRunEvent = true;
                        }
                    }
                    else if (field[x, y] == 0) // 아무것도 없을 떄
                    {
                        if (buttons[x, y].Text == "\u0021")
                        {
                            bombs++;
                            mine.Text = "지뢰 수: " + bombs;
                        }

                        buttons[x, y].Text = "";
                        Recursive(x, y);
                        buttons[x, y].Enabled = false;


                    }
                    else // 근처에 지뢰가 있을 때
                    {
                        if (buttons[x, y].Text == "\u0021")
                        {
                            bombs++;
                            mine.Text = "지뢰 수: " + bombs;
                        }
                        btn.Text = "" + field[x, y];
                        buttons[x, y].Enabled = false;
                    }
                    CheckGameWin(); // 게임 승리 체크
                }
                else if(e.Button == MouseButtons.Right) // 버튼 우클릭 시 마킹 표시
                {
                    if (buttons[x, y].Text == "\u0021") //마킹 해제
                    { 
                        buttons[x, y].Text = "";
                        bombs++;
                        mine.Text = "지뢰 수: " + bombs;
                    }
                    else
                    { 
                        buttons[x, y].Text = "\u0021"; //마킹
                        bombs--;
                        mine.Text = "지뢰 수: " + bombs;
                    }

                }
            }

        }
        private void CheckGameWin() //게임 승리 조건 체크
        {
            int a = 0;
            for(int x = 0; x < field.GetLength(0); x++)
            {
                for(int y = 0; y<field.GetLength(1); y++)
                {
                    if (!(field[x,y] == -1) && buttons[x,y].Enabled==true) // 남은 버튼수 체크
                    {
                        a++;
                    }
                }
            }
            if (a == 0) //클릭할 버튼이 지뢰만 남았다면 게임승리
            { 
                MessageBox.Show("gamewin");
                timer1.Enabled = false;
            }
        }
        private void Recursive(int x, int y) //빈 칸을 클릭했을 때 주변 모든 빈 칸을 연쇄적으로 오픈
        {
            if (x < 0 || y < 0) return; // 배열 범위 밖인가?
            if (x >= field.GetLength(0) || y >= field.GetLength(1)) return; // 배열 범위 밖인가?
            if (buttons[x, y].Enabled == false) return; // 이미 눌러진 버튼인가?
            if(buttons[x, y].Text == "\u0021")
            {
                buttons[x, y].Text = "";
                bombs++;
                mine.Text = "지뢰 수: " + bombs;
            }
            if (field[x, y] != 0) // 폭탄의 범위에 있는 버튼일때
            {
                buttons[x, y].Text = "" + field[x, y];
                buttons[x, y].Enabled = false;
                return;
            }
            // 위 조건의 범위에 포함되지 않는다면
            buttons[x, y].Enabled = false;

            Recursive(x + 1, y);
            Recursive(x - 1, y);
            Recursive(x, y + 1);
            Recursive(x, y - 1);
            return;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //프로그램 종료
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e) //라운드 플레이 시간 계산
        {
            time.Text = "걸린 시간: " + time_;
            time_++;
        }

        private void restart() // 게임 재시작 기능
        {
            this.Controls.Clear(); //폼에 할당된 컨트롤 해제
            this.InitializeComponent();//폼에 컨트롤 재할당
            /* form_load와 fieldinit 함수 실행 */
            buttons = new Button[field.GetLength(0), field.GetLength(1)]; 
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Font = new Font("Arial", 20);
                    buttons[i, j].Left = i * 40;
                    buttons[i, j].Top = j * 40;
                    buttons[i, j].Size = new Size(40, 40);
                    Controls.Add(buttons[i, j]);
                    buttons[i, j].TabStop = false;
                    buttons[i, j].MouseUp += BTN_Click;

                }
            }
            if (diff == 0)
            {
                FieldInit(5, 5, 3, 0);
            }
            else if (diff == 1)
            {
                FieldInit(10, 10, 15, 1);
            }
            else if (diff == 2)
            {
                FieldInit(15, 15, 45, 2);
            }
            time_ = 1;
        }

        private void Choose_Difficulty(int difficulty) //난이도 설정
        {
            diff = difficulty;
            btn_changediff = new Button();
            btn_manu = new Button();
            mine = new Label();
            time = new Label();
            btn_changediff.Text = "난이도변경";
            btn_manu.Text = "메뉴";
            mine.Text = "지뢰 수: " + bombs;
            time.Text = "걸린 시간: " + time_;

            if (difficulty == 0) //쉬움 난이도
            {
                this.Size = new Size(400, 240);
                btn_changediff.Location = new Point(210, 10);
                btn_manu.Location = new Point(297, 10);
                mine.Location = new Point(210, 50);
                time.Location = new Point(210, 90);

            }
            else if (difficulty == 1) //보통 난이도
            {
                this.Size = new Size(600, 440);
                btn_changediff.Location = new Point(410, 10);
                btn_manu.Location = new Point(497, 10);
                mine.Location = new Point(410, 50);
                time.Location = new Point(410, 90);
            }
            else if (difficulty == 2)//어려움 난이도
            {

                this.Size = new Size(800, 640);
                btn_changediff.Location = new Point(610, 10);
                btn_manu.Location = new Point(697, 10);
                mine.Location = new Point(610, 50);
                time.Location = new Point(610, 90);
            }
            this.Controls.Add(btn_changediff);
            this.Controls.Add(btn_manu);
            this.Controls.Add(mine);
            this.Controls.Add(time);
            btn_changediff.Click += changediff; //각 버튼에 맞는 이벤트 설정

        }
        private void changediff(object sender, EventArgs e) //btn_changediff에 대한 클릭 이벤트
        {
            GameInit game = new GameInit();
            game.Show();
            this.Hide();
        }
    }
}

