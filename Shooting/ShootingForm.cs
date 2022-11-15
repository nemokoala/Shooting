using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.Windows.Forms;


namespace Shooting
{
    public partial class ShootingForm : Form
    {
        private int playerMove = 0;
        private int playerHp = 3;
        private int playerMaxHp = 5;
        public int score = 0;
        public int stage = 1;     
        private static int enemy1Amount = 7;
        private static int enemy2Amount = 2;
        private PictureBox[] Enemy1Parent = new PictureBox[enemy1Amount];
        private PictureBox[] Enemy2Parent = new PictureBox[enemy2Amount];
        private PictureBox[] BulletParent = new PictureBox[7];
        private ProgressBar[] Enemy1HpViewerParent = new ProgressBar[enemy1Amount];
        private ProgressBar[] Enemy2HpViewerParent = new ProgressBar[enemy2Amount];
        private int[] enemy1HpViewerEnable = new int[enemy1Amount];
        private int[] enemy2HpViewerEnable = new int[enemy2Amount];
        private int[] enemy1Hp = new int[enemy1Amount];
        private int[] enemy1ImageCount = new int[enemy1Amount];
        private int[] enemy2Hp = new int[enemy2Amount];
        private int[] enemy2ImageCount = new int[enemy2Amount];
        private int enemy1DefaultHp = 30;
        private int enemy1MaxHp = 30;
        private int enemy1Speed = 3;
        private int enemy2DefaultHp = 100;
        private int enemy2MaxHp = 100;
        private int enemy2Speed = 3;
        private int enemy2InsStage = 5;
        private int stoneInsStage = 10;
        private int a = 0;
        private int explosionCount = 0;
        Random rnd = new Random();
        private int bulletDelay = 6; //총알 연사 속도 (낮을 수록 빠르게 나감)
        public int bulletDelayCount = 1; //총알 연사 속도 체크를 위한 카운트
        private int bulletCount = 0; //데이터구조로 무한 배열
        private int playerImageCount = 0; //이미지 깜빡임 카운트 20->0
        private int bulletSpeed = 17; //총알 투사체 속도
        private int bulletDamage = 10;
        private int weaponLevel = 1;
        private int itemMoveSpeed = 3;
        private Boolean powerItemActive = false;
        private Boolean lifeItemActive = false;
        private Boolean bombItemActive = false;
        private Boolean gameover = false;
        private SoundPlayer GunSound = new SoundPlayer("gun.wav");
        private SoundPlayer BgmSound = new SoundPlayer("bgm.wav");
        private SoundPlayer ExplosionSound = new SoundPlayer("explosion.wav");

        public ShootingForm()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            UIText.BringToFront();
            { //플레이어 이동
                if (playerMove == -1) Player.Left -= 6;
                if (playerMove == 1) Player.Left += 6;
                if (Player.Left < 0) Player.Left = 0;
                if (Player.Left > ClientSize.Width - Player.Width) Player.Left = ClientSize.Width - Player.Width;
                /*int x = Player.Location.X + Player.Width / 2;
                int y = Player.Location.Y + Player.Height / 2;
                Point p = new Point(x, y);
                PlayerCollision.Location = p;*/
            }
            //적 낙하
            for (int i = 0; i < Enemy1Parent.Length; i++)
            {
                Enemy1Parent[i].Top += enemy1Speed;

                if (Enemy1Parent[i].Top > ClientSize.Height + 100) // 적이 맵 밑으로 나갈 경우
                {
                    Enemy1Parent[i].Visible = false;
                    Enemy1Parent[i].Top = rnd.Next(-500, -Enemy1Parent[0].Height);
                    Enemy1Parent[i].Left = rnd.Next(0, ClientSize.Width - Enemy1Parent[0].Width);
                    enemy1Hp[i] = enemy1DefaultHp;
                    enemy1ImageCount[i] = 0;
                    Enemy1Parent[i].Image = Properties.Resources.Enemy;
                    Enemy1HpViewerParent[i].Maximum = enemy1DefaultHp;
                    Enemy1HpViewerParent[i].Value = enemy1DefaultHp;
                }
                if (Enemy1Parent[i].Top > 0 - Enemy1Parent[0].Height) Enemy1Parent[i].Visible = true;
                else Enemy1Parent[i].Visible = false;


            }
            //적 2 낙하
            if (stage >= enemy2InsStage)
            {
                for (int i = 0; i < Enemy2Parent.Length; i++)
                {
                    Enemy2Parent[i].Top += enemy2Speed;

                    if (Enemy2Parent[i].Top > ClientSize.Height + 100) // 적이 맵 밑으로 나갈 경우
                    {
                        Enemy2Parent[i].Visible = true;
                        Enemy2Parent[i].Top = rnd.Next(-500, -Enemy2Parent[0].Height);
                        Enemy2Parent[i].Left = rnd.Next(0, ClientSize.Width - Enemy2Parent[0].Width);
                        enemy2Hp[i] = enemy2DefaultHp;
                        enemy2ImageCount[i] = 0;
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2;
                        Enemy2HpViewerParent[i].Maximum = enemy2DefaultHp;
                        Enemy2HpViewerParent[i].Value = enemy2DefaultHp;
                    }
                    if (Enemy2Parent[i].Top > 0 - Enemy2Parent[0].Height) Enemy2Parent[i].Visible = true;
                    else Enemy2Parent[i].Visible = false;
                }
            }

            //플레이어가 적과 충돌 시, 적 이미지 카운트
            for (int i = 0; i < Enemy1Parent.Length; i++)
            {
                if (Player.Bounds.IntersectsWith(Enemy1Parent[i].Bounds))
                {
                    playerHp -= 1;
                    Enemy1Parent[i].Top = rnd.Next(-500, -Enemy1Parent[0].Height);
                    Enemy1Parent[i].Left = rnd.Next(0, ClientSize.Width - Enemy1Parent[0].Width);
                    enemy1Hp[i] = enemy1DefaultHp;
                    Enemy1HpViewerParent[i].Maximum = enemy1DefaultHp;
                    Enemy1HpViewerParent[i].Value = enemy1DefaultHp;
                    Player.Image = Properties.Resources.PlayerHit;
                    playerImageCount = 20;
                    UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;

                    if (playerHp <= 0 && gameover == false)
                    {
                        gameover = true;
                        this.Hide();
                        ShootingResultForm form2 = new ShootingResultForm(this);
                        form2.ShowDialog();
                    }
                }

                if (enemy1ImageCount[i] == 18)
                {
                    Enemy1Parent[i].Image = Properties.Resources.Enemy;
                }
                if (enemy1ImageCount[i] == 12)
                {
                    Enemy1Parent[i].Image = Properties.Resources.EnemyHit;
                }
                if (enemy1ImageCount[i] == 7)
                {
                    Enemy1Parent[i].Image = Properties.Resources.Enemy;
                }
                enemy1ImageCount[i]--;

                //------------------ 적1 체력바 ---------------------------------
                if (enemy1HpViewerEnable[i] > 0)
                {
                    Enemy1HpViewerParent[i].Value = enemy1Hp[i];
                    Enemy1HpViewerParent[i].Top = Enemy1Parent[i].Top - Enemy1HpViewerParent[i].Height - 5;
                    Enemy1HpViewerParent[i].Left = Enemy1Parent[i].Left + Enemy1Parent[i].Width / 2 - Enemy1HpViewerParent[i].Width / 2;
                    Enemy1HpViewerParent[i].Visible = true;
                }
                if (enemy1HpViewerEnable[i] <= 0)
                {
                    Enemy1HpViewerParent[i].Visible = false;
                }
                enemy1HpViewerEnable[i]--; //체력바 자동 사라짐


            }

            //플레이어가 적2과 충돌 시, 적 이미지 카운트
            if (stage >= enemy2InsStage)
            {
                for (int i = 0; i < Enemy2Parent.Length; i++)
                {
                    if (Player.Bounds.IntersectsWith(Enemy2Parent[i].Bounds))
                    {
                        playerHp -= 1;
                        Enemy2Parent[i].Top = rnd.Next(-500, -Enemy2Parent[0].Height);
                        Enemy2Parent[i].Left = rnd.Next(0, ClientSize.Width - Enemy2Parent[0].Width);
                        enemy2Hp[i] = enemy2DefaultHp;
                        Enemy2HpViewerParent[i].Maximum = enemy2DefaultHp;
                        Enemy2HpViewerParent[i].Value = enemy2DefaultHp;
                        Player.Image = Properties.Resources.PlayerHit;
                        playerImageCount = 20;
                        UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;

                        if (playerHp <= 0 && gameover == false)
                        {
                            gameover = true;
                            this.Hide();
                            ShootingResultForm form2 = new ShootingResultForm(this);
                            form2.ShowDialog();
                        }
                    }

                    if (enemy2ImageCount[i] == 18)
                    {
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2;
                    }
                    if (enemy2ImageCount[i] == 12)
                    {
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2Hit;
                    }
                    if (enemy2ImageCount[i] == 7)
                    {
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2;
                    }
                    enemy2ImageCount[i]--;

                    //------------------ 적2 체력바 ---------------------------------
                    if (enemy2HpViewerEnable[i] > 0)
                    {
                        Enemy2HpViewerParent[i].Value = enemy2Hp[i];
                        Enemy2HpViewerParent[i].Top = Enemy2Parent[i].Top - Enemy2HpViewerParent[i].Height - 5;
                        Enemy2HpViewerParent[i].Left = Enemy2Parent[i].Left + Enemy2Parent[i].Width / 2 - Enemy2HpViewerParent[i].Width / 2;
                        Enemy2HpViewerParent[i].Visible = true;
                    }
                    if (enemy2HpViewerEnable[i] <= 0)
                    {
                        Enemy2HpViewerParent[i].Visible = false;
                    }

                    enemy2HpViewerEnable[i]--; //체력바 자동 사라짐

                    /*Enemy1HpViewerParent[i].Text = "HP : " + enemy1Hp[i] +"/"+ enemy1MaxHp;
                    Enemy1HpViewerParent[i].Top = Enemy1Parent[i].Top - 15;
                    Enemy1HpViewerParent[i].Left = Enemy1Parent[i].Left - 15;*/

                }
            }

            //플레이어가 돌과 충돌 시          
            if (Player.Bounds.IntersectsWith(Stone.Bounds))
            {
                Stone.Left = Player.Left;
                Stone.Top = rnd.Next(-300, 0 - Stone.Height);
                playerHp--;
                Player.Image = Properties.Resources.PlayerHit;
                playerImageCount = 20;
                UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;

                if (playerHp <= 0 && gameover == false)
                {
                    gameover = true;
                    this.Hide();
                    ShootingResultForm form2 = new ShootingResultForm(this);
                    form2.ShowDialog();
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
                        //Enemy1HpViewerParent[i].Value = enemy1Hp[i] + h;
                        Enemy1HpViewerParent[j].Top = Enemy1Parent[j].Top - Enemy1HpViewerParent[j].Height - 5;
                        Enemy1HpViewerParent[j].Left = Enemy1Parent[j].Left + Enemy1Parent[j].Width / 2 - Enemy1HpViewerParent[j].Width / 2;
                        Enemy1HpViewerParent[j].Visible = true;
                        enemy1HpViewerEnable[j] = 40; //체력바 표시 시간
                        if (enemy1Hp[j] <= 0) //적 체력이 0이 됐을 때
                        {
                            Enemy1Die(j);
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
                            Enemy2HpViewerParent[j].Top = Enemy2Parent[j].Top - Enemy2HpViewerParent[j].Height - 5;
                            Enemy2HpViewerParent[j].Left = Enemy2Parent[j].Left + Enemy2Parent[j].Width / 2 - Enemy2HpViewerParent[j].Width / 2;
                            Enemy2HpViewerParent[j].Visible = true;
                            enemy2HpViewerEnable[j] = 40; //체력바 표시 시간
                            if (enemy2Hp[j] <= 0) //적 체력이 0이 됐을 때
                            {
                                Enemy2Die(j);
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
                int x = Player.Location.X + Player.Width / 2 - BulletParent[0].Width / 2;
                int y = Player.Location.Y;
                Point p = new Point(x, y);
                BulletParent[i].Location = p;
                bulletCount++;
                //GunSound.Play();
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
                weaponLevel++;
                powerItemActive = false;
                PowerItem.Left = -100;
                UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;
                if (weaponLevel == 3) 
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.Orange;
                    }
                }
                if (weaponLevel == 6)
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.LightGreen;
                    }
                }
                if (weaponLevel == 10) 
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.LawnGreen;
                    }
                }
                if (weaponLevel == 20) 
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.Lime;
                    }
                }
                if (weaponLevel == 30) 
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.GreenYellow;
                        BulletParent[i].Size = new Size(12, 35);
                    }
                }
                if (weaponLevel == 50) 
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.PaleGreen;
                        BulletParent[i].Size = new Size(24, 35);
                    }
                }
                if (weaponLevel == 60) 
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.MediumSpringGreen;
                        BulletParent[i].Size = new Size(36, 35);
                    }
                }
                if (weaponLevel == 70) 
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.Aquamarine;
                        BulletParent[i].Size = new Size(38, 35);
                    }
                }
                if (weaponLevel == 80) 
                {
                    for (int i = 0; i < BulletParent.Length; i++)
                    {
                        BulletParent[i].BackColor = Color.SkyBlue;
                        BulletParent[i].Size = new Size(40, 35);
                    }
                }
            }
            if (powerItemActive == true)
            {
                PowerItem.Top += itemMoveSpeed;
            }
            if (PowerItem.Top > ClientSize.Height)
            {
                powerItemActive = false;
                PowerItem.Left = -100;
            }
            //라이프 아이템
            if (Player.Bounds.IntersectsWith(LifeItem.Bounds))
            {
                if (playerHp < playerMaxHp)
                playerHp += 1;
                UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;
                lifeItemActive = false;
                LifeItem.Left = -100;
            }
            if (lifeItemActive == true)
            {
                LifeItem.Top += itemMoveSpeed;
            }
            if (LifeItem.Top > ClientSize.Height)
            {
                lifeItemActive = false;
                LifeItem.Left = -100;
            }

            
            explosionCount--;
            if (explosionCount < 0) Explosion.SendToBack();
            //폭탄 아이템
            if (Player.Bounds.IntersectsWith(BombItem.Bounds)) 
            {
                ExplosionSound.Play();
                Explosion.BringToFront();
                explosionCount = 12;
                for (int i = 0; i < Enemy1Parent.Length; i++)
                {
                    Enemy1Die(i);
                }

                if (stage >= enemy2InsStage)
                {
                    for (int i = 0; i < Enemy2Parent.Length; i++)
                    {
                        Enemy2Die(i);
                    }
                }
                Stone.Left = Player.Left;
                Stone.Top = rnd.Next(-300, 0 - Stone.Height);
                bombItemActive = false;
                BombItem.Left = -100;
            }
            if (bombItemActive == true)
            {
                BombItem.Top += itemMoveSpeed+1;
                if (BombItem.Left > Player.Left)
                    BombItem.Left -= 1;
                if (BombItem.Left < Player.Left)
                    BombItem.Left += 1;
            }
            if (BombItem.Top > ClientSize.Height)
            {
                bombItemActive = false;
                BombItem.Left = -100;
            }

            //스테이지 설정
            if (bulletDelayCount % 700 == 0) 
            {
                stage = (bulletDelayCount / 700) + 1;
                UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;
                enemy1DefaultHp = enemy1MaxHp + stage * 20;
                enemy2DefaultHp = enemy2MaxHp + stage * 30;
                if (stage % 3 == 0) enemy1Speed++;
                if (stage > 5 && stage % 6 == 0) enemy2Speed++;
                if (stage == 5)
                {
                    for (int i = 0; i < Enemy2Parent.Length; i++)
                    {
                        Enemy2Parent[i] = new PictureBox();
                        Enemy2Parent[i].Image = Properties.Resources.Enemy2;
                        Enemy2Parent[i].Location = new Point(rnd.Next(0, ClientSize.Width - 30), rnd.Next(-500, -50));
                        Enemy2Parent[i].Size = new Size(70, 90);
                        Enemy2Parent[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        Enemy2Parent[i].Margin = new Padding(0, 0, 0, 0);
                        enemy2Hp[i] = enemy2DefaultHp;  //적2 체력 세팅
                        Controls.Add(Enemy2Parent[i]);
                        Enemy2Parent[i].BringToFront();

                        Enemy2HpViewerParent[i] = new ProgressBar(); //적2 체력바 세팅
                        Enemy2HpViewerParent[i].Maximum = enemy2DefaultHp;
                        Enemy2HpViewerParent[i].Minimum = 0;
                        Enemy2HpViewerParent[i].Top = Enemy2Parent[i].Top - 15;
                        Enemy2HpViewerParent[i].Left = Enemy2Parent[i].Left - 15;
                        Enemy2HpViewerParent[i].Size = new Size(70, 15);
                        Enemy2HpViewerParent[i].ForeColor = Color.Red;
                        Controls.Add(Enemy2HpViewerParent[i]);
                        Enemy2HpViewerParent[i].BringToFront();
                        enemy2HpViewerEnable[i] = 0;
                        Enemy2HpViewerParent[i].Value = enemy2DefaultHp;
                        Enemy2HpViewerParent[i].Visible = false;
                    }
                } //적2, 적2 체력바 생성
                if (stage == stoneInsStage)
                {
                    Stone.Left = Player.Left;
                    Stone.Top = 0 - Stone.Height;
                }
            }

            //돌 낙하
            if (stage >= stoneInsStage)
            {
                Stone.Top += 3;
                if (Stone.Top > ClientSize.Height)
                {
                    Stone.Left = Player.Left;
                    Stone.Top = rnd.Next(-300, 0 - Stone.Height);
                }
            }
            
        }

        //------------------------------ 타이머 이벤트 끝 -------------------------------------

        private void Enemy1Die(int j)
        {
            Enemy1HpViewerParent[j].Maximum = enemy1DefaultHp;
            Enemy1HpViewerParent[j].Value = enemy1DefaultHp;
            enemy1HpViewerEnable[j] = 0;
            Enemy1HpViewerParent[j].Visible = false;
            int itemDrop = rnd.Next(0, 100);
            if (itemDrop <= 20 && powerItemActive == false)
            {
                powerItemActive = true;
                PowerItem.Left = Enemy1Parent[j].Left;
                PowerItem.Top = Enemy1Parent[j].Top;
            }
            if (itemDrop > 20 && itemDrop <= 27 && lifeItemActive == false)
            {
                lifeItemActive = true;
                LifeItem.Left = Enemy1Parent[j].Left;
                LifeItem.Top = Enemy1Parent[j].Top;
            }
            if (itemDrop > 30 && itemDrop <= 40 && bombItemActive == false)
            {
                bombItemActive = true;
                BombItem.Left = Enemy1Parent[j].Left;
                BombItem.Top = Enemy1Parent[j].Top;
            }
            Enemy1Parent[j].Top = rnd.Next(-500, -50); 
            Enemy1Parent[j].Left = rnd.Next(0, ClientSize.Width - Enemy1Parent[0].Width);
            enemy1Hp[j] = enemy1DefaultHp;
            enemy1ImageCount[j] = 0;
            Enemy1Parent[j].Image = Properties.Resources.Enemy;
            score += 10+stage;
            UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;

        }

        private void Enemy2Die(int j)
        {
            Enemy2HpViewerParent[j].Maximum = enemy2DefaultHp;
            Enemy2HpViewerParent[j].Value = enemy2DefaultHp;
            enemy2HpViewerEnable[j] = 0;
            Enemy2HpViewerParent[j].Visible = false;
            int itemDrop = rnd.Next(0, 100);
            if (itemDrop <= 40 && powerItemActive == false)
            {
                powerItemActive = true;
                PowerItem.Left = Enemy2Parent[j].Left;
                PowerItem.Top = Enemy2Parent[j].Top;
            }
            if (itemDrop > 40 && itemDrop <= 60 && lifeItemActive == false)
            {
                lifeItemActive = true;
                LifeItem.Left = Enemy2Parent[j].Left;
                LifeItem.Top = Enemy2Parent[j].Top;
            }
            if (itemDrop > 70 && itemDrop <= 80 && bombItemActive == false)
            {
                bombItemActive = true;
                BombItem.Left = Enemy2Parent[j].Left;
                BombItem.Top = Enemy2Parent[j].Top;
            }
            Enemy2Parent[j].Top = rnd.Next(-500, -50);
            Enemy2Parent[j].Left = rnd.Next(0, ClientSize.Width - Enemy2Parent[0].Width);
            enemy2Hp[j] = enemy2DefaultHp;
            enemy2ImageCount[j] = 0;
            Enemy2Parent[j].Image = Properties.Resources.Enemy2;
            score += 20+stage;
            UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) playerMove = -1;
            if (e.KeyCode == Keys.Right) playerMove = 1;
            if (e.KeyCode == Keys.Z) Player.Controls.Clear();
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
                Enemy1Parent[i].Location = new Point(rnd.Next(0, ClientSize.Width - 50), rnd.Next(-500, -50));
                Enemy1Parent[i].Size = new Size(50, 75);
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
                enemy1HpViewerEnable[i] = 0;
                Enemy1HpViewerParent[i].Value = enemy1DefaultHp;
                Enemy1HpViewerParent[i].Visible = false;
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
                BulletParent[i].Location = new Point(-30, 0);
                BulletParent[i].Size = new Size(6, 35);
                BulletParent[i].SizeMode = PictureBoxSizeMode.StretchImage;
                BulletParent[i].Margin = new Padding(0, 0, 0, 0);
                //Enemy1Parent[i].BackColor = Color.Transparent;
                Controls.Add(BulletParent[i]);
                BulletParent[i].BringToFront();
            }
            Background1.Size = new Size(ClientSize.Width, ClientSize.Height);
            Background2.Size = new Size(ClientSize.Width, ClientSize.Height);
            Background2.Top = 0 - Background2.Height;
            UIText.Text = "Score : " + score + "\nStage : " + stage + "\n무기레벨 : " + weaponLevel + "\n체력 : " + playerHp + "/" + playerMaxHp;
            PowerItem.Left = -100; //아이템들 위치 초기설정
            LifeItem.Left = -100;
            BombItem.Left = -100;
            Explosion.SendToBack();
            BgmSound.PlayLooping();
            Stone.Left = -100; //돌 초기에 안보이게
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}