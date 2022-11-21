using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    public partial class YTMT : Form
    {
        /* 초기 블록 이미지 설정 */
        Bitmap redbitmap = Shooting.Properties.Resources.red;
        Bitmap bluebitmap = Shooting.Properties.Resources.blue;
        Bitmap whitebitmap = Shooting.Properties.Resources.white;
        Bitmap greenbitmap = Shooting.Properties.Resources.green;
        Bitmap purplebitmap = Shooting.Properties.Resources.purple;
        Bitmap yellowbitmap = Shooting.Properties.Resources.yellow;
        
        private int BlockRange = 0;   //블록 범위
        private int number = 2;       //랜덤 함수의 범위        
        private int score = 0;        //점수
        private bool DontRunEvent = true; // 이벤트 할당, 해제에 도움을 주는 값. 값이 true면 키보드 입력이벤트가 실행되지않음 
        /*게임시작전 카운트다운에 도움을 주는 값 */
        private int DontRunEventTime = 0;
        private int Count = 2; 

        Random rnd = new Random();
        PictureBox[] BTN = new PictureBox[5]; //색상블럭 초기화
        public YTMT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            int y = -10;

            // 초기 색상블럭 생성, 초기화

            for (int i = 0; i < 5; i++)
            {
                BTN[i] = new PictureBox();

                BTN[i].Location = new Point(280, y);
                BTN[i].Size = new Size(100, 100);
                BTN[i].SizeMode = PictureBoxSizeMode.StretchImage;

                BlockRange = rnd.Next(0, 3);
                if (BlockRange == 0)
                    BTN[i].Image = redbitmap;
                else
                    BTN[i].Image = bluebitmap;
                y += 90;
                if (BTN[i] == BTN[BTN.Length - 1])
                {
                    BTN[i].Size = new Size(120, 120);
                    BTN[i].Location = new Point(280, 380);
                    BTN[i].Left += -10;
                }
                this.Controls.Add(BTN[i]);
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) //키보드 입력 시
        {
            if (DontRunEvent == false) //키입력을 받을지 결정
            {
                if (e.KeyCode == Keys.Left) //'<-' 입력시
                {
                    if ((BTN[4].Image == redbitmap) || (BTN[4].Image == whitebitmap) || (BTN[4].Image == purplebitmap)) // 빨강,하양,보라 공룡이라면
                    {
                        Makeblock(); //블럭 처리
                        score++; //점수 증가
                        label1.Text = "SCORE: " + score;

                    }
                    else //키 입력 실수 시 1초동안 키입력 비활성화
                    {
                        DontRunEvent = true;
                        this.BackColor = Color.DarkGray;
                        timer2.Enabled = true;
                    }

                }
                if (e.KeyCode == Keys.Right) // '->- 입력 시
                {
                    if (BTN[4].Image == bluebitmap || BTN[4].Image == greenbitmap || BTN[4].Image == yellowbitmap) // 파랑,초록,노랑 공룡이라면
                    {
                        Makeblock(); //블럭 처리
                        score++;  //점수 증가
                        label1.Text = "SCORE: " + score;

                    }
                    else //키 입력 실수 시 1초동안 키입력 비활성화
                    {
                        DontRunEvent = true;
                        this.BackColor = Color.DarkGray;
                        timer2.Enabled = true;
                    }
                }
            }
        }

        private void Makeblock() //블럭 처리 함수
        {
            if (score > 20) //점수에 따라 생성공룡 수가 다양해짐
                number = 4;
            if (score > 40)
                number = 6;
            /*
            맨 밑에 있는 블럭색상에 맞게 키보드를 입력하면
            그 위에 있는 색상블럭들이 차례차례 내려오고 
            맨 위의 블록은 새로 생성
            */
            BTN[4].Image = BTN[3].Image;
            BTN[3].Image = BTN[2].Image;
            BTN[2].Image = BTN[1].Image;
            BTN[1].Image = BTN[0].Image;

            BlockRange = rnd.Next(0, number);
            if (BlockRange == 0)
                BTN[0].Image = redbitmap;
            else if (BlockRange == 1)
                BTN[0].Image = bluebitmap;
            else if (BlockRange == 2)
                BTN[0].Image = whitebitmap;
            else if (BlockRange == 3)
                BTN[0].Image = greenbitmap;
            else if (BlockRange == 4)
                BTN[0].Image = yellowbitmap;
            else if (BlockRange == 5)
                BTN[0].Image = purplebitmap;

        }

        private void timer1_Tick(object sender, EventArgs e)  //제한 시간을 나타냄. 30초, 제한시간이 지나면 최종점수폼 생성
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Enabled = false;
                DontRunEvent = true;
                YTMTEND form2 = new YTMTEND(score);
                form2.Show();
            }



        }

        private void Form1_Paint(object sender, PaintEventArgs e) //그리기 함수, 해당위치에 있는 색상을 처리해주면 됨.
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);
            Point[] pts =
            {
                new Point(259,375), new Point(400,375),
                new Point(400,516), new Point(259,516), new Point(259,375)
            };
            g.DrawLines(new Pen(Color.Black), pts);
        }

        private void timer2_Tick(object sender, EventArgs e) // 입력미스 시 1초동안 이벤트 비활성화
        {
            DontRunEventTime += 1;
            if(DontRunEventTime == 1)
            {
                DontRunEvent = false;
                timer2.Enabled = false;
                DontRunEventTime = 0;
                this.BackColor = Color.MediumSeaGreen;
            }
        }

        private void timer3_Tick(object sender, EventArgs e) //게임시작 전 카운트 다운
        {
            if (Count == 0)
            {
                CountDown.Hide();
                timer1.Enabled = true;
                timer3.Enabled = false;
                DontRunEvent = false;
                this.BackColor = Color.MediumSeaGreen;
                
            }
            CountDown.Text = "" + Count;
            Count--;
            
        }
    }


}
