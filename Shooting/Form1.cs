using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shooting
{
    public partial class Form1 : Form
    {
        private int playerMove = 0;
        private int playerHp = 3;
        public int score = 0;
        public int stage = 1;
        private float[] iceSpeed = new float[5];
        private Point point;
        private static int enemy1Amount = 7;
        private static int enemy2Amount = 2;
        private PictureBox[] Enemy1Parent = new PictureBox[enemy1Amount];
        private PictureBox[] Enemy2Parent = new PictureBox[enemy2Amount];
        private PictureBox[] BulletParent = new PictureBox[7];
        private ProgressBar[] Enemy1HpViewerParent = new ProgressBar[enemy1Amount];
        private int[] enemy1Hp = new int[enemy1Amount];
        private int[] enemy1ImageCount = new int[enemy1Amount];
        private int[] enemy2Hp = new int[enemy2Amount];
        private int[] enemy2ImageCount = new int[enemy2Amount];
        private int enemy1DefaultHp = 30;
        private int enemy1MaxHp = 30;
        private int enemy1Speed = 2;
        private int enemy2DefaultHp = 100;
        private int enemy2MaxHp = 100;
        private int enemy2Speed = 2;
        private int enemy2InsStage = 5;
        private int a = 0;
        Random rnd = new Random();
        private int bulletDelay = 10; //총알 연사 속도 (낮을 수록 빠르게 나감)
        public int bulletDelayCount = 1; //총알 연사 속도 체크를 위한 카운트
        private int bulletCount = 0; //데이터구조로 무한 배열
        private int playerImageCount = 0; //이미지 깜빡임 카운트 20->0
        private int bulletSpeed = 8; //총알 투사체 속도
        private int bulletDamage = 10;
        private Boolean powerItemActive = false;
        private Boolean lifeItemActive = false;
        private Boolean gameover = false;

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
                if (Player.Left < 0) Player.Left = 0;
                if (Player.Left > ClientSize.Width-Player.Width) Player.Left = ClientSize.Width - Player.Width;
                /*int x = Player.Location.X + Player.Width / 2;
                int y = Player.Location.Y + Player.Height / 2;
                Point p = new Point(x, y);
                PlayerCollision.Location = p;*/
            }
            //적 낙하
            for (int i = 0; i < Enemy1Parent.Length; i++)
            {
                Enemy1Parent[i].Top += enemy1Speed;
                //iceSpeed[i] += 0.0001f;

                if (Enemy1Parent[i].Top > ClientSize.Height + 100) // 적이 맵 밑으로 나갈 경우
                {
                    Enemy1Parent[i].Top = rnd.Next(-500,-50);
                    Enemy1Parent[i].Left = rnd.Next(0, ClientSize.Width - 30);
                    enemy1Hp[i] = enemy1DefaultHp;
                    enemy1ImageCount[i] = 0;
                    Enemy1Parent[i].Image = Properties.Resources.Enemy;
                    Enemy1HpViewerParent[i].Maximum = enemy1DefaultHp;
                    //iceSpeed[i] = rnd.Next(2, 7);
                }
            }
            //적 2 낙하
            if (stage >= enemy2InsStage)
            {
                for (int i = 0; i < Enemy2Parent.Length; i++)
                {
                    Enemy2Parent[i].Top += enemy2Speed;
                    //iceSpeed[i] += 0.0001f;

                    if (Enemy2Parent[i].Top > ClientSize.Height + 100) // 적이 맵 밑으로 나갈 경우
                    {
                        Enemy2Parent[i].Top = rnd.Next(-500, -50);
                        Enemy2Parent[i].Left = rnd.Next(0, ClientSize.Width - 30);
                        enemy2Hp[i] = enemy2DefaultHp;
                        enemy2ImageCount[i] = 0;
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2;
                        //iceSpeed[i] = rnd.Next(2, 7);
                    }
                }
            }

            //플레이어가 적과 충돌 시, 적 이미지 카운트
            for (int i = 0; i < Enemy1Parent.Length; i++)
            {
                if (Player.Bounds.IntersectsWith(Enemy1Parent[i].Bounds))
                {
                    playerHp -= 1;
                    Enemy1Parent[i].Top = -5;
                    enemy1Hp[i] = enemy1DefaultHp;
                    Enemy1HpViewerParent[i].Maximum = enemy1DefaultHp;
                    Player.Image = Properties.Resources.PlayerHit;
                    playerImageCount = 20;
                    PlayerHpText.Text = "Hp: " + playerHp;

                    if (playerHp <= 0 && gameover == false)
                    {
                        gameover = true;
                        this.Hide();
                        Form2 form2 = new Form2(this);
                        form2.ShowDialog();
                    }
                }

                if (enemy1ImageCount[i] == 16)
                {
                    Enemy1Parent[i].Image = Properties.Resources.Enemy;
                }
                if (enemy1ImageCount[i] == 10)
                {
                    Enemy1Parent[i].Image = Properties.Resources.EnemyHit;
                }
                if (enemy1ImageCount[i] == 0)
                {
                    Enemy1Parent[i].Image = Properties.Resources.Enemy;
                }
                enemy1ImageCount[i]--;


                Enemy1HpViewerParent[i].Value = enemy1Hp[i];
                Enemy1HpViewerParent[i].Top = Enemy1Parent[i].Top - 20;
                Enemy1HpViewerParent[i].Left = Enemy1Parent[i].Left - 15;
                
            }

            //플레이어가 적2과 충돌 시, 적 이미지 카운트
            if (stage >= enemy2InsStage)
            {
                for (int i = 0; i < Enemy2Parent.Length; i++)
                {
                    if (Player.Bounds.IntersectsWith(Enemy2Parent[i].Bounds))
                    {
                        playerHp -= 1;
                        Enemy2Parent[i].Top = -30;
                        enemy2Hp[i] = enemy2DefaultHp;
                        Player.Image = Properties.Resources.PlayerHit;
                        playerImageCount = 20;
                        PlayerHpText.Text = "Hp: " + playerHp;

                        if (playerHp <= 0 && gameover == false)
                        {
                            gameover = true;
                            this.Hide();
                            Form2 form2 = new Form2(this);
                            form2.ShowDialog();
                        }
                    }

                    if (enemy2ImageCount[i] == 16)
                    {
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2;
                    }
                    if (enemy2ImageCount[i] == 10)
                    {
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2Hit;
                    }
                    if (enemy2ImageCount[i] == 0)
                    {
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2;
                    }
                    enemy2ImageCount[i]--;

                    /*Enemy1HpViewerParent[i].Text = "HP : " + enemy1Hp[i] +"/"+ enemy1MaxHp;
                    Enemy1HpViewerParent[i].Top = Enemy1Parent[i].Top - 15;
                    Enemy1HpViewerParent[i].Left = Enemy1Parent[i].Left - 15;*/

                }
            }
            

            

            //총알이 적과 충돌 시
            for (int i = 0; i < BulletParent.Length; i++)
            {
                for (int j = 0; j < Enemy1Parent.Length; j++)
                {
                    if (BulletParent[i].Bounds.IntersectsWith(Enemy1Parent[j].Bounds))
                    {
                        enemy1Hp[j] -= bulletDamage;
                        BulletParent[i].Top = -100;
                        BulletParent[i].Left = -100;
                        Enemy1Parent[j].Image = Properties.Resources.EnemyHit;
                        enemy1ImageCount[j] = 20;                       
                        if (enemy1Hp[j] <= 0) //적 체력이 0이 됐을 때
                        {
                            int itemDrop = rnd.Next(0, 100);
                            if (itemDrop <= 17 && powerItemActive == false)
                            {
                                powerItemActive = true;
                                PowerItem.Left = Enemy1Parent[j].Left;
                                PowerItem.Top = Enemy1Parent[j].Top;
                            }
                            if (itemDrop > 17 && itemDrop <=25 && lifeItemActive == false)
                            {
                                lifeItemActive = true;
                                LifeItem.Left = Enemy1Parent[j].Left;
                                LifeItem.Top = Enemy1Parent[j].Top;
                            }
                            Enemy1Parent[j].Top = -100;
                            Enemy1Parent[j].Left = rnd.Next(0, ClientSize.Width - 30);
                            enemy1Hp[j] = enemy1DefaultHp;
                            Enemy1HpViewerParent[j].Maximum = enemy1DefaultHp;
                            enemy1ImageCount[j] = 0;
                            Enemy1Parent[j].Image = Properties.Resources.Enemy;
                            score++;
                            ScoreText.Text = "Score : " + score;
                        }
                    }
                }
                
                if (stage >= enemy2InsStage)//적 2처리
                for (int j = 0; j < Enemy2Parent.Length; j++) 
                {
                    if (BulletParent[i].Bounds.IntersectsWith(Enemy2Parent[j].Bounds))
                    {
                        enemy2Hp[j] -= bulletDamage;
                        BulletParent[i].Top = -100;
                        BulletParent[i].Left = -100;
                        Enemy2Parent[j].Image = Properties.Resources.Enemy2Hit;
                        enemy2ImageCount[j] = 20;
                        if (enemy2Hp[j] <= 0) //적 체력이 0이 됐을 때
                        {
                            int itemDrop = rnd.Next(0, 100);
                            if (itemDrop <= 30 && powerItemActive == false)
                            {
                                powerItemActive = true;
                                PowerItem.Left = Enemy2Parent[j].Left;
                                PowerItem.Top = Enemy2Parent[j].Top;
                            }
                            if (itemDrop > 31 && itemDrop <= 50 && lifeItemActive == false)
                            {
                                lifeItemActive = true;
                                LifeItem.Left = Enemy2Parent[j].Left;
                                LifeItem.Top = Enemy2Parent[j].Top;
                            }
                            Enemy2Parent[j].Top = -100;
                            Enemy2Parent[j].Left = rnd.Next(0, ClientSize.Width - 30);
                            enemy2Hp[j] = enemy2DefaultHp;
                            enemy2ImageCount[j] = 0;
                            Enemy2Parent[j].Image = Properties.Resources.Enemy;
                                score++;
                            ScoreText.Text = "Score : " + score;
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
                int x = Player.Location.X + Player.Width / 2 - BulletParent[0].Width/2;
                int y = Player.Location.Y;
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
            if (playerImageCount == 20) Player.Image = Properties.Resources.PlayerHit;
            if (playerImageCount == 16) Player.Image = Properties.Resources.Player;
            if (playerImageCount == 10) Player.Image = Properties.Resources.PlayerHit;
            if (playerImageCount == 0) Player.Image = Properties.Resources.Player;

            
            //파워업 아이템
            if (Player.Bounds.IntersectsWith(PowerItem.Bounds))
            {
                bulletDamage += 2;
                powerItemActive = false;
                PowerItem.Left = -100;
                if (bulletDamage == 20) //5
                {
                    for(int i=0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.Orange;
                    }
                }
                if (bulletDamage == 30) //10
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.LightGreen;
                    }
                }
                if (bulletDamage == 40) //10
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.LightBlue;
                    }
                }
                if (bulletDamage == 50) //10
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.LightCyan;
                    }
                }
                if (bulletDamage == 60) //10
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].Size = new Size(12, 25);
                    }
                }
                if (bulletDamage == 70) //10
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].Size = new Size(24, 25);
                    }
                }
                if (bulletDamage == 80) //10
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].Size = new Size(36, 25);
                    }
                }
                if (bulletDamage == 90) //10
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].Size = new Size(38, 25);
                    }
                }
                if (bulletDamage == 120) //10
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.LightSalmon;
                        BulletParent[i].Size = new Size(40, 25);
                    }
                }
            }
            if (powerItemActive == true)
            {
                PowerItem.Top += 2;
            }
            if (PowerItem.Top > ClientSize.Height)
            {
                powerItemActive = false;
                PowerItem.Left = -100;
            }
            //라이프 아이템
            if (Player.Bounds.IntersectsWith(LifeItem.Bounds))
            {
                playerHp += 1;
                PlayerHpText.Text = "Hp: " + playerHp;
                lifeItemActive = false;
                LifeItem.Left = -100;
            }
            if (lifeItemActive == true)
            {
                LifeItem.Top += 2;
            }
            if (LifeItem.Top > ClientSize.Height)
            {
                lifeItemActive = false;
                LifeItem.Left = -100;
            }
            if (bulletDelayCount % 1000 == 0)
            {
                stage = (bulletDelayCount / 1000)+1;         
                StageText.Text = "Stage : " + stage;
                enemy1DefaultHp = enemy1MaxHp + stage * 10;
                enemy2DefaultHp = enemy2MaxHp + stage * 20;
                if (stage % 3 == 0) enemy1Speed++;
                if (stage > 5 && stage % 3 == 0) enemy2Speed++;
                if (stage == 5)
                {
                    for (int i=0; i < Enemy2Parent.Length; i++)
                    {
                        Enemy2Parent[i] = new PictureBox();
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2;
                        Enemy2Parent[i].Location = new Point(rnd.Next(0, ClientSize.Width - 30), rnd.Next(-500, -50));
                        Enemy2Parent[i].Size = new Size(60, 60);
                        Enemy2Parent[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        Enemy2Parent[i].Margin = new Padding(0, 0, 0, 0);
                        enemy2Hp[i] = enemy2MaxHp;  //적 체력 세팅
                        Controls.Add(Enemy2Parent[i]);
                        Enemy2Parent[i].BringToFront();
                    }
                }
            }
        }
        //------------------------------ 타이머 이벤트 끝 -------------------------------------

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) playerMove = -1;
            if (e.KeyCode == Keys.Right) playerMove = 1;
            if (e.KeyCode == Keys.Z) stage = 5;
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
                Enemy1Parent[i].Location = new Point(rnd.Next(0, ClientSize.Width-50), rnd.Next(-500, -50));
                Enemy1Parent[i].Size = new Size(40, 40);
                Enemy1Parent[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Enemy1Parent[i].Margin = new Padding(0, 0, 0, 0);
                //Enemy1Parent[i].BackColor = Color.Transparent;
                //iceSpeed[i] = rnd.Next(3, 5);
                a += 100;
                enemy1Hp[i] = enemy1DefaultHp;  //적 체력 세팅
                Controls.Add(Enemy1Parent[i]);
                Enemy1Parent[i].BringToFront();

                //적 체력 정보 표시
                Enemy1HpViewerParent[i] = new ProgressBar();
                Enemy1HpViewerParent[i].Maximum = enemy1MaxHp;
                Enemy1HpViewerParent[i].Minimum = 0;
                Enemy1HpViewerParent[i].Top = Enemy1Parent[i].Top - 15;
                Enemy1HpViewerParent[i].Left = Enemy1Parent[i].Left - 15;
                Enemy1HpViewerParent[i].Size = new Size(70, 15);
                Enemy1HpViewerParent[i].ForeColor = Color.Red;
                Controls.Add(Enemy1HpViewerParent[i]);
                Enemy1HpViewerParent[i].BringToFront();
            }

            //총알 생성
            for (int i = 0; i < BulletParent.Length; i++)
            {
                BulletParent[i] = new PictureBox();
                BulletParent[i].Image = null;
                BulletParent[i].BackColor = Color.Yellow;
                //int x = Player.Location.X + Player.Width / 2;
                //int y = Player.Location.Y + Player.Height / 2;
                //Point p = new Point(x, y);
                BulletParent[i].Location = new Point(-30,0);
                BulletParent[i].Size = new Size(6, 25);
                BulletParent[i].SizeMode = PictureBoxSizeMode.StretchImage;
                BulletParent[i].Margin = new Padding(0, 0, 0, 0);
                //Enemy1Parent[i].BackColor = Color.Transparent;
                Controls.Add(BulletParent[i]);
                BulletParent[i].BringToFront();                
            }
            Background1.Size = new Size(ClientSize.Width, ClientSize.Height);
            Background2.Size = new Size(ClientSize.Width, ClientSize.Height);
            Background2.Top = 0 - Background2.Height;
            PlayerHpText.Text = "Hp: " + playerHp;
            PowerItem.Left = -100;
            LifeItem.Left = -100;
        } 
    }
}
