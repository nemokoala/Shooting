namespace Shooting
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreText = new System.Windows.Forms.Label();
            this.PlayerHpText = new System.Windows.Forms.Label();
            this.StageText = new System.Windows.Forms.Label();
            this.LifeItem = new System.Windows.Forms.PictureBox();
            this.PowerItem = new System.Windows.Forms.PictureBox();
            this.PlayerCollision = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Background2 = new System.Windows.Forms.PictureBox();
            this.Background1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LifeItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCollision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScoreText.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ScoreText.Location = new System.Drawing.Point(12, 9);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(136, 22);
            this.ScoreText.TabIndex = 1;
            this.ScoreText.Text = "Score : 0";
            // 
            // PlayerHpText
            // 
            this.PlayerHpText.AutoSize = true;
            this.PlayerHpText.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlayerHpText.ForeColor = System.Drawing.Color.DarkRed;
            this.PlayerHpText.Location = new System.Drawing.Point(12, 85);
            this.PlayerHpText.Name = "PlayerHpText";
            this.PlayerHpText.Size = new System.Drawing.Size(77, 22);
            this.PlayerHpText.TabIndex = 1;
            this.PlayerHpText.Text = "Hp : ";
            // 
            // StageText
            // 
            this.StageText.AutoSize = true;
            this.StageText.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StageText.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.StageText.Location = new System.Drawing.Point(12, 44);
            this.StageText.Name = "StageText";
            this.StageText.Size = new System.Drawing.Size(135, 22);
            this.StageText.TabIndex = 1;
            this.StageText.Text = "Stage : 1";
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
            // PlayerCollision
            // 
            this.PlayerCollision.Image = global::Shooting.Properties.Resources.Enemy2Hit;
            this.PlayerCollision.Location = new System.Drawing.Point(174, 361);
            this.PlayerCollision.Name = "PlayerCollision";
            this.PlayerCollision.Size = new System.Drawing.Size(25, 25);
            this.PlayerCollision.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerCollision.TabIndex = 0;
            this.PlayerCollision.TabStop = false;
            this.PlayerCollision.Visible = false;
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(131, 425);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(40, 40);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Background2
            // 
            this.Background2.Image = ((System.Drawing.Image)(resources.GetObject("Background2.Image")));
            this.Background2.Location = new System.Drawing.Point(0, 281);
            this.Background2.Name = "Background2";
            this.Background2.Size = new System.Drawing.Size(413, 548);
            this.Background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background2.TabIndex = 2;
            this.Background2.TabStop = false;
            // 
            // Background1
            // 
            this.Background1.Image = ((System.Drawing.Image)(resources.GetObject("Background1.Image")));
            this.Background1.Location = new System.Drawing.Point(0, -1);
            this.Background1.Name = "Background1";
            this.Background1.Size = new System.Drawing.Size(413, 548);
            this.Background1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background1.TabIndex = 2;
            this.Background1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 487);
            this.Controls.Add(this.LifeItem);
            this.Controls.Add(this.PowerItem);
            this.Controls.Add(this.PlayerHpText);
            this.Controls.Add(this.StageText);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.PlayerCollision);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Background2);
            this.Controls.Add(this.Background1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(293, 526);
            this.MinimumSize = new System.Drawing.Size(293, 526);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.LifeItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCollision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PlayerCollision;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.PictureBox Background1;
        private System.Windows.Forms.PictureBox Background2;
        private System.Windows.Forms.Label PlayerHpText;
        private System.Windows.Forms.PictureBox PowerItem;
        private System.Windows.Forms.PictureBox LifeItem;
        private System.Windows.Forms.Label StageText;
    }
}

