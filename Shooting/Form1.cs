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
    public partial class Form1 : Form
    {
        private int playerMove = 0;
        private int playerHp = 3;
        private float[] iceSpeed = new float[5];
        private Point point;
        private static int enemy1Amount = 7;
        private PictureBox[] Enemy1Parent = new PictureBox[enemy1Amount];
        private PictureBox[] BulletParent = new PictureBox[7];
        private int[] enemyHp = new int[enemy1Amount];
        private int[] enemyImageCount = new int[enemy1Amount];
        private int enemyDefaultHp = 4;
        private int a = 0;
        Random rnd = new Random();
        private int bulletDelay = 10; //총알 연사 속도 (낮을 수록 빠르게 나감)
        private int bulletDelayCount = 1; //총알 연사 속도 체크를 위한 카운트
        private int bulletCount = 0; //데이터구조로 무한 배열
        private int playerImageCount = 0; //이미지 깜빡임 카운트 20->0
        private int bulletSpeed = 8; //총알 투사체 속도

        public Form1()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerAction();
        }

        private void TimerAction()
        {
            { //플레이어 이동
                if (playerMove == -1) Player.Left -= 4;
                if (playerMove == 1) Player.Left += 4;
                int x = Player.Location.X + Player.Width / 2;
                int y = Player.Location.Y + Player.Height / 2;
                Point p = new Point(x, y);
                PlayerCollision.Location = p;
            }
            //적 낙하
            for (int i = 0; i < Enemy1Parent.Length; i++)
            {
                Enemy1Parent[i].Top += 3;
                //iceSpeed[i] += 0.0001f;

                if (Enemy1Parent[i].Top > ClientSize.Height + 100)
                {
                    Enemy1Parent[i].Top = rnd.Next(-500,-50);
                    Enemy1Parent[i].Left = rnd.Next(0, ClientSize.Width - 100);
                    //iceSpeed[i] = rnd.Next(2, 7);
                }
            }

            //플레이어가 적과 충돌 시
            for (int i = 0; i < Enemy1Parent.Length; i++)
            {
                if (Player.Bounds.IntersectsWith(Enemy1Parent[i].Bounds))
                {
                    playerHp -= 1;
                    Enemy1Parent[i].Top = -5;
                    Player.Image = Properties.Resources.PlayerHit;
                    playerImageCount = 20;
                }
                if (enemyImageCount[i] == 16)
                {
                    Enemy1Parent[i].Image = Properties.Resources.Enemy;
                }
                if (enemyImageCount[i] == 10)
                {
                    Enemy1Parent[i].Image = Properties.Resources.EnemyHit;
                }
                if (enemyImageCount[i] == 0)
                {
                    Enemy1Parent[i].Image = Properties.Resources.Enemy;
                }
                enemyImageCount[i]--;
            }
            //총알이 적과 충돌 시
            for (int i = 0; i < BulletParent.Length; i++)
            {
                for (int j = 0; j < Enemy1Parent.Length; j++)
                {
                    if (BulletParent[i].Bounds.IntersectsWith(Enemy1Parent[j].Bounds))
                    {
                        playerHp += 1;
                        enemyHp[j]--;
                        BulletParent[i].Top = -100;
                        BulletParent[i].Left = -100;
                        Enemy1Parent[j].Image = Properties.Resources.EnemyHit;
                        enemyImageCount[j] = 20;                       
                        if (enemyHp[j] <= 0)
                        {
                            Enemy1Parent[j].Top = -100;
                            enemyHp[j] = enemyDefaultHp;
                        }
                    }
                }
                if (BulletParent[i].Top < 0)
                {
                    BulletParent[i].Left = -100;
                } 
            }

            //총알 발사 : 플레이어 위치로 총알 위치 이동
            if (bulletDelayCount % bulletDelay == 0)
            {
                int i = bulletCount % 7;
                int x = Player.Location.X + Player.Width / 2 - 5;
                int y = Player.Location.Y + Player.Height / 2;
                Point p = new Point(x, y);
                BulletParent[i].Location = p;
                bulletCount++;
            }

            for (int i = 0; i < BulletParent.Length; i++) //총알 이동
            {
                BulletParent[i].Top -= bulletSpeed;
            }

            { //배경이동
                if (Background1.Top >= 0 + Background2.Height) Background1.Top = Background2.Top - Background1.Height;
                if (Background2.Top >= 0 + Background2.Height) Background2.Top = 0 - Background1.Top - Background2.Height;
                Background1.Top += 1;
                Background2.Top += 1;
                
            }
            bulletDelayCount++;
            playerImageCount--;
            if (playerImageCount == 0) Player.Image = Properties.Resources.Player;

            ScoreText.Text = "Score : " + playerHp;

        }
        //------------------------------ 타이머 이벤트 끝 -------------------------------------

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) playerMove = -1;
            if (e.KeyCode == Keys.Right) playerMove = 1;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && playerMove != 1) playerMove = 0;
            if (e.KeyCode == Keys.Right && playerMove != -1) playerMove = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Enemy1Parent.Length; i++)
            {

                int x = rnd.Next(0, 400);

                //적 생성 설정
                Enemy1Parent[i] = new PictureBox();
                Enemy1Parent[i].Image = Properties.Resources.Enemy;
                Enemy1Parent[i].Location = new Point(rnd.Next(0, 400), rnd.Next(-500, -50));
                Enemy1Parent[i].Size = new Size(50, 50);
                Enemy1Parent[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Enemy1Parent[i].Margin = new Padding(0, 0, 0, 0);
                //Enemy1Parent[i].BackColor = Color.Transparent;
                //iceSpeed[i] = rnd.Next(3, 5);
                a += 100;
                enemyHp[i] = enemyDefaultHp;  //적 체력 세팅
                Controls.Add(Enemy1Parent[i]);
                Enemy1Parent[i].BringToFront();

            }

            for (int i = 0; i < BulletParent.Length; i++)
            {
                BulletParent[i] = new PictureBox();
                BulletParent[i].Image = Properties.Resources.Bullet;
                //int x = Player.Location.X + Player.Width / 2;
                //int y = Player.Location.Y + Player.Height / 2;
                //Point p = new Point(x, y);
                BulletParent[i].Location = new Point(-30,0);
                BulletParent[i].Size = new Size(10, 10);
                BulletParent[i].SizeMode = PictureBoxSizeMode.StretchImage;
                BulletParent[i].Margin = new Padding(0, 0, 0, 0);
                //Enemy1Parent[i].BackColor = Color.Transparent;
                Controls.Add(BulletParent[i]);
                BulletParent[i].BringToFront();                
            }
            Background1.Size = new Size(ClientSize.Width, ClientSize.Height);
            Background2.Size = new Size(ClientSize.Width, ClientSize.Height);
            Background2.Top = 0 - Background2.Height;
        } 
    }
}
