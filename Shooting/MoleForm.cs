using Shooting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kuma
{
    public partial class MoleForm : Form
    {
        int a, b, c; //두더지 123
        int health = 3; //체력
        int disad = 1; //불이익
        public int score = 0; //스코어
        int scoreup = 10; //스코어 업
        public int highscore = 0; //최고점수
        int choice = 2; //가장 많이 나올 두더지 초이스
        int choice2 = 0;
        int reply = 0; //답
        int check = 0; //위치
        int preScore = 0;
        int max_appear = 4; //최대
        int ran_appear = 2; //최대보다 적은
        int mole1, mole2, mole3; //두더지 123
        Random rand = new Random();

        bool goleft, goright = false;
        bool st_cl = true;

        Boolean gameOver = false;
        //test
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            if (check == reply)
            {
                MessageBox.Show("정답~!");

                score += scoreup;
                max_appear += 3;//난이도 증가
                ran_appear += 3;
                health++; //체력증가
                IniFile ini = new IniFile();
                try { ini.Load("GameData.ini"); } catch { }
                preScore = ini["두더지"]["점수"].ToInt();
                if (preScore < score)//실시간으로 최고점수 갱신 가능
                {
                    //Shooting.Properties.Settings.Default.최고점수 = score;
                    //Shooting.Properties.Settings.Default.Save();

                    ini["두더지"]["점수"] = score;
                    ini.Save("GameData.ini");

                }

                st_cl = true; //두더지 시작
                timer1.Enabled = true; //두더지 움직임
                button1.Visible = false;
                a = 0;
                b = 0;
                c = 0;
                label2.Text = "" + a;
                label3.Text = "" + b;
                label4.Text = "" + c;
            }
            else if (check != reply)
            {
                MessageBox.Show("오답!!");
                health -= disad; //체력 깍임
                max_appear += 3;//난이도 증가
                ran_appear += 3;
                st_cl = true; //두더지 시작
                timer1.Enabled = true; //두더지 움직임
                a = 0;
                b = 0;
                c = 0;
                label2.Text = "" + a;
                label3.Text = "" + b;
                label4.Text = "" + c;
                button1.Visible = false;
            }
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        /*
        private void start_Click(object sender, EventArgs e) //제동장치
        {
            st_cl = true;
            timer1.Enabled = true;
        }
        */
        private void player_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 130, 63);
        }

        private void MoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!gameOver)
                Application.Restart();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            healthbar.Text = "체력 : " + health; //체력
            scorebar.Text = "Scroe : " + score; //현재점수
            IniFile ini = new IniFile();
            try { ini.Load("GameData.ini"); } catch { }
            highscore = ini["두더지"]["점수"].ToInt();
            //highscore = Shooting.Properties.Settings.Default.최고점수;
            highscorebar.Text = "HighScore : " + highscore; //최고점수

            if (health <= 0) //체력 0이 되면
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                gameOver = true;
                ResultForm resultform = new ResultForm(this, "Mole", null);
                resultform.Show();
                this.Close();
            }

            if (goleft)
            {
                if (player.Location.X == 727)
                {
                    player.Location = new Point(471, 327);
                    check = 1;
                }
                else if (player.Location.X == 471)
                {
                    player.Location = new Point(215, 327);
                    check = 0;
                }
                goleft = false;
            }
            if (goright)
            {
                if (player.Location.X == 215)
                {
                    player.Location = new Point(471, 327);
                    check = 1;
                }
                else if (player.Location.X == 471)
                {
                    player.Location = new Point(727, 327);
                    check = 2;
                }
                goright = false;
            }
        }

        public MoleForm()
        {
            InitializeComponent();
        }

        private static DateTime Delay(int MS)//딜레이 함수
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) //플레이어 이동
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (st_cl) //타이머 온오프
            {

                button1.Visible = false;
                Delay(150);
                choice = rand.Next(0, 3); //가장 많이 나올 두더지
                //MessageBox.Show("" + choice);
                if (choice == 0)
                {
                    reply = 0; //1번
                    mole1 = max_appear;
                    mole2 = rand.Next(ran_appear, ran_appear + 1);
                    mole3 = rand.Next(ran_appear, ran_appear + 1);
                }
                if (choice == 1)
                {
                    reply = 1; //2번
                    mole2 = max_appear;
                    mole1 = rand.Next(ran_appear, ran_appear + 1);
                    mole3 = rand.Next(ran_appear, ran_appear + 1);
                }
                if (choice == 2)
                {
                    reply = 2; //3번
                    mole3 = max_appear;
                    mole1 = rand.Next(ran_appear, ran_appear + 1);
                    mole2 = rand.Next(ran_appear, ran_appear + 1);
                }


                label2.Text = "" + mole1;
                label3.Text = "" + mole2;
                label4.Text = "" + mole3;

                while (mole1!=0||mole2!=0||mole3!=0)
                {
                    choice2 = rand.Next(0, 3); //턴마다 두더지 순서 정하기
                    if (choice2 == 0)
                    {
                        if(choice == 1 && choice == 2) //선택된 두더지가 아니고
                        {
                            if (mole1 == 2) //this 두더지가 2번 남았다면 한턴 쉬기
                                break;
                        }
                        if (mole1 > 0)
                        {
                            pictureBox1.Image = Shooting.Properties.Resources.on; //두더지 온
                            Delay(220);
                            pictureBox1.Image = Shooting.Properties.Resources.off; //두더지 오프
                            Delay(220);
                            mole1 -= 1;
                            a++;
                        }
                    }
                    else if (choice2 == 1)
                    {
                        if (choice == 0 && choice == 2)
                        {
                            if (mole2 == 2)
                                break;
                        }
                        if (mole2 > 0)
                        {
                            pictureBox2.Image = Shooting.Properties.Resources.on;
                            Delay(220);
                            pictureBox2.Image = Shooting.Properties.Resources.off;
                            Delay(220);
                            mole2 -= 1;
                            b++;
                        }
                        
                    }
                    else if (choice2 == 2)
                    {
                        if (choice == 0 && choice == 1)
                        {
                            if (mole3 == 3)
                                break;
                        }
                        if (mole3 > 0)
                        {
                            pictureBox3.Image = Shooting.Properties.Resources.on;
                            Delay(220);
                            pictureBox3.Image = Shooting.Properties.Resources.off;
                            Delay(220);
                            mole3 -= 1;
                            c++;
                        }
                    }

                    st_cl = false; // 두더지 스톱
                    timer1.Enabled = false; // 타이머 종료

                }
                button1.Visible = true;

            }


        }
    }
}
