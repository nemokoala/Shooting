using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting
{
    public partial class JellyForm : Form
    {
        private short playerJump = 0;
        private short playerDown = 0;
        private Boolean playerSit = false;
        public int Score = 0;
        private int enemySpeed = 12;
        private int playerDefaultTop = 0;
        private Boolean gameOver = false;
        Random rnd = new Random();
        MainForm mainForm;
        public JellyForm(MainForm form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemy1.Left -= (int)enemySpeed;
            Enemy2.Left -= (int)enemySpeed;
            PlayerMask.Left = Player.Left + 31;
            PlayerMask.Top = Player.Top;

            //플레이어 이동
            { 
                if (playerJump > 0 && playerJump <= 7)
                {
                    Player.Top -= 9;
                }
                if (playerJump > 7 && playerJump <= 15)
                {
                    Player.Top -= 12;
                }

                if (playerDown > 8 && playerDown <= 15)
                {
                    Player.Top += 9;
                }
                if (playerDown > 0 && playerDown <= 8)
                {
                    Player.Top += 12;
                }
                playerJump--;
                playerDown--;

                if (playerSit == true)
                {
                    if (Player.Top == playerDefaultTop)
                    {
                        Player.Size = new Size(98, 49);
                        Player.Top = playerDefaultTop + 49;
                        
                    }                 
                }
                if (playerSit == false && playerDown <= 0)
                {
                    Player.Size = new Size(98, 98);
                    Player.Top = playerDefaultTop;                  
                }
            }

            //구름,적 반복 설정
            {
                Cloud1.Left -= enemySpeed - 3;
                Cloud2.Left -= enemySpeed - 3;
                if (Cloud1.Left < 0 - Cloud1.Width)
                {
                    Cloud1.Left = ClientSize.Width + rnd.Next(0, 10);
                }
                if (Cloud2.Left < 0 - Cloud2.Width)
                {
                    Cloud2.Left = ClientSize.Width + rnd.Next(0, 10);
                }
                if (Enemy1.Left < 0 - Enemy1.Width)
                {
                    Enemy1.Left = ClientSize.Width + rnd.Next(0, 1000);
                    if (Enemy1.Left - Enemy2.Left < 150)
                    {
                        Enemy1.Left += 250;
                    }
                }
                if (Enemy2.Left < 0 - Enemy2.Width)
                {
                    Enemy2.Left = ClientSize.Width + rnd.Next(000, 1000);
                    if (Enemy2.Left - Enemy1.Left < 150)
                    {
                        Enemy2.Left += 250;
                    }
                }
            }

            //충돌 설정
            if (PlayerMask.Bounds.IntersectsWith(Enemy1.Bounds))
            {
                GameOver();
            }

            if (PlayerMask.Bounds.IntersectsWith(Enemy2.Bounds) && playerSit == false)
            {
                GameOver();
            }

            //겹치기 해결
            {
                if (Enemy1.Left > ClientSize.Width && Enemy2.Left > ClientSize.Width)
                {
                    if (Enemy2.Left > Enemy1.Left)
                    {
                        if (Enemy2.Left - Enemy1.Left < 200)
                            Enemy2.Left += 200;
                    }
                    if (Enemy1.Left > Enemy2.Left)
                    {
                        if (Enemy1.Left - Enemy2.Left < 200)
                            Enemy1.Left += 200;
                    }
                }

            }

            //스코어 설정
            Score += 3;
            UIText.Text = "Score : " + Score;
            enemySpeed = (Score / 1000) + 8;
        }

        private void JellyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                if (playerJump <= 0 && playerDown <= 0)
                {
                    playerJump = 15;
                    playerDown = 30;
                }
                if (playerSit == true)
                {
                    int y = Player.Top;
                    Player.Top = y - 49;
                    playerSit = false;
                }
                Player.Size = new Size(98, 98);
            }
            if (e.KeyCode == Keys.Down)
            {        
            if (playerSit == false)
                playerSit = true;                 
            }
        }
        private void JellyForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {

                if (playerSit == true)
                    playerSit = false;
                
            }
        }
        private void JellyForm_Load(object sender, EventArgs e)
        {
            playerDefaultTop = Player.Top;
            PlayerMask.Visible = false;
        }

        private void GameOver()
        {
            gameOver = true;
            ResultForm resultform = new ResultForm(this, "Jelly",mainForm);
            resultform.Show();
            this.Close();
        }

        private void JellyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //mainForm.Visible = true;
        }

        private void JellyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!gameOver)
            Application.Restart();
        }
    }
}
