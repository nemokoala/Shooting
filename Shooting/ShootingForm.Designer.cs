namespace Shooting
{
    partial class ShootingForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShootingForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MXP = new AxWMPLib.AxWindowsMediaPlayer();
            this.MXP2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.MXP3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.StageUp = new System.Windows.Forms.Label();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.Stone = new System.Windows.Forms.PictureBox();
            this.BombItem = new System.Windows.Forms.PictureBox();
            this.LifeItem = new System.Windows.Forms.PictureBox();
            this.PowerItem = new System.Windows.Forms.PictureBox();
            this.UIText = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Background2 = new System.Windows.Forms.PictureBox();
            this.Background1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MXP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MXP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MXP
            // 
            this.MXP.Enabled = true;
            this.MXP.Location = new System.Drawing.Point(20, 392);
            this.MXP.Name = "MXP";
            this.MXP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP.OcxState")));
            this.MXP.Size = new System.Drawing.Size(75, 23);
            this.MXP.TabIndex = 6;
            // 
            // MXP2
            // 
            this.MXP2.Enabled = true;
            this.MXP2.Location = new System.Drawing.Point(20, 458);
            this.MXP2.Name = "MXP2";
            this.MXP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP2.OcxState")));
            this.MXP2.Size = new System.Drawing.Size(75, 23);
            this.MXP2.TabIndex = 6;
            // 
            // MXP3
            // 
            this.MXP3.Enabled = true;
            this.MXP3.Location = new System.Drawing.Point(20, 509);
            this.MXP3.Name = "MXP3";
            this.MXP3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MXP3.OcxState")));
            this.MXP3.Size = new System.Drawing.Size(75, 23);
            this.MXP3.TabIndex = 6;
            // 
            // StageUp
            // 
            this.StageUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StageUp.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StageUp.ForeColor = System.Drawing.Color.Black;
            this.StageUp.Location = new System.Drawing.Point(100, 183);
            this.StageUp.Name = "StageUp";
            this.StageUp.Size = new System.Drawing.Size(117, 38);
            this.StageUp.TabIndex = 7;
            this.StageUp.Text = "Stage UP!";
            this.StageUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Explosion
            // 
            this.Explosion.Image = global::Shooting.Properties.Resources.NExplosion;
            this.Explosion.Location = new System.Drawing.Point(117, 236);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(100, 100);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Explosion.TabIndex = 4;
            this.Explosion.TabStop = false;
            // 
            // Stone
            // 
            this.Stone.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Stone.Image = global::Shooting.Properties.Resources.Stone;
            this.Stone.Location = new System.Drawing.Point(99, 82);
            this.Stone.Name = "Stone";
            this.Stone.Size = new System.Drawing.Size(55, 55);
            this.Stone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stone.TabIndex = 5;
            this.Stone.TabStop = false;
            // 
            // BombItem
            // 
            this.BombItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BombItem.Image = global::Shooting.Properties.Resources.BombItem;
            this.BombItem.Location = new System.Drawing.Point(232, 385);
            this.BombItem.Name = "BombItem";
            this.BombItem.Size = new System.Drawing.Size(30, 30);
            this.BombItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BombItem.TabIndex = 3;
            this.BombItem.TabStop = false;
            // 
            // LifeItem
            // 
            this.LifeItem.Image = ((System.Drawing.Image)(resources.GetObject("LifeItem.Image")));
            this.LifeItem.Location = new System.Drawing.Point(232, 421);
            this.LifeItem.Name = "LifeItem";
            this.LifeItem.Size = new System.Drawing.Size(30, 30);
            this.LifeItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LifeItem.TabIndex = 3;
            this.LifeItem.TabStop = false;
            // 
            // PowerItem
            // 
            this.PowerItem.Image = ((System.Drawing.Image)(resources.GetObject("PowerItem.Image")));
            this.PowerItem.Location = new System.Drawing.Point(187, 421);
            this.PowerItem.Name = "PowerItem";
            this.PowerItem.Size = new System.Drawing.Size(30, 30);
            this.PowerItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PowerItem.TabIndex = 3;
            this.PowerItem.TabStop = false;
            // 
            // UIText
            // 
            this.UIText.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UIText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UIText.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UIText.ForeColor = System.Drawing.Color.AliceBlue;
            this.UIText.Image = global::Shooting.Properties.Resources.TopUi;
            this.UIText.Location = new System.Drawing.Point(0, -1);
            this.UIText.Name = "UIText";
            this.UIText.Size = new System.Drawing.Size(318, 60);
            this.UIText.TabIndex = 1;
            this.UIText.Text = "Score : 0\r\n";
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(140, 480);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 75);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Background2
            // 
            this.Background2.Image = global::Shooting.Properties.Resources.back;
            this.Background2.Location = new System.Drawing.Point(0, 281);
            this.Background2.Name = "Background2";
            this.Background2.Size = new System.Drawing.Size(413, 548);
            this.Background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background2.TabIndex = 2;
            this.Background2.TabStop = false;
            // 
            // Background1
            // 
            this.Background1.Image = global::Shooting.Properties.Resources.back;
            this.Background1.Location = new System.Drawing.Point(0, -1);
            this.Background1.Name = "Background1";
            this.Background1.Size = new System.Drawing.Size(413, 548);
            this.Background1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background1.TabIndex = 2;
            this.Background1.TabStop = false;
            // 
            // ShootingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 567);
            this.Controls.Add(this.Explosion);
            this.Controls.Add(this.StageUp);
            this.Controls.Add(this.MXP3);
            this.Controls.Add(this.MXP2);
            this.Controls.Add(this.MXP);
            this.Controls.Add(this.Stone);
            this.Controls.Add(this.BombItem);
            this.Controls.Add(this.LifeItem);
            this.Controls.Add(this.PowerItem);
            this.Controls.Add(this.UIText);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Background2);
            this.Controls.Add(this.Background1);
            this.DoubleBuffered = true;
            this.Name = "ShootingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shooting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShootingForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.MXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MXP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MXP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LifeItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label UIText;
        private System.Windows.Forms.PictureBox Background1;
        private System.Windows.Forms.PictureBox Background2;
        private System.Windows.Forms.PictureBox PowerItem;
        private System.Windows.Forms.PictureBox LifeItem;
        private System.Windows.Forms.PictureBox BombItem;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox Stone;
        private AxWMPLib.AxWindowsMediaPlayer MXP;
        private AxWMPLib.AxWindowsMediaPlayer MXP2;
        private AxWMPLib.AxWindowsMediaPlayer MXP3;
        private System.Windows.Forms.Label StageUp;
    }
}

