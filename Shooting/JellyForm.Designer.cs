namespace Shooting
{
    partial class JellyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JellyForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UIText = new System.Windows.Forms.Label();
            this.PlayerMask = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Cloud2 = new System.Windows.Forms.PictureBox();
            this.Cloud1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UIText
            // 
            this.UIText.AutoSize = true;
            this.UIText.Font = new System.Drawing.Font("굴림", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UIText.Location = new System.Drawing.Point(8, 5);
            this.UIText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UIText.Name = "UIText";
            this.UIText.Size = new System.Drawing.Size(82, 22);
            this.UIText.TabIndex = 2;
            this.UIText.Text = "Score : ";
            // 
            // PlayerMask
            // 
            this.PlayerMask.Location = new System.Drawing.Point(71, 270);
            this.PlayerMask.Name = "PlayerMask";
            this.PlayerMask.Size = new System.Drawing.Size(19, 67);
            this.PlayerMask.TabIndex = 3;
            this.PlayerMask.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2.Image = global::Shooting.Properties.Resources.JellyEnemy2;
            this.Enemy2.Location = new System.Drawing.Point(817, 220);
            this.Enemy2.Margin = new System.Windows.Forms.Padding(2);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(115, 89);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 1;
            this.Enemy2.TabStop = false;
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.Image = global::Shooting.Properties.Resources.JellyEnemy1;
            this.Enemy1.Location = new System.Drawing.Point(567, 308);
            this.Enemy1.Margin = new System.Windows.Forms.Padding(2);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(97, 60);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 1;
            this.Enemy1.TabStop = false;
            // 
            // Cloud2
            // 
            this.Cloud2.BackColor = System.Drawing.Color.Transparent;
            this.Cloud2.Image = global::Shooting.Properties.Resources.cloud2;
            this.Cloud2.Location = new System.Drawing.Point(567, 11);
            this.Cloud2.Margin = new System.Windows.Forms.Padding(2);
            this.Cloud2.Name = "Cloud2";
            this.Cloud2.Size = new System.Drawing.Size(192, 146);
            this.Cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud2.TabIndex = 1;
            this.Cloud2.TabStop = false;
            // 
            // Cloud1
            // 
            this.Cloud1.BackColor = System.Drawing.Color.Transparent;
            this.Cloud1.Image = ((System.Drawing.Image)(resources.GetObject("Cloud1.Image")));
            this.Cloud1.Location = new System.Drawing.Point(133, 5);
            this.Cloud1.Margin = new System.Windows.Forms.Padding(2);
            this.Cloud1.Name = "Cloud1";
            this.Cloud1.Size = new System.Drawing.Size(197, 128);
            this.Cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud1.TabIndex = 1;
            this.Cloud1.TabStop = false;
            // 
            // Player
            // 
            this.Player.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Shooting.Properties.Resources.Player1;
            this.Player.Location = new System.Drawing.Point(40, 270);
            this.Player.Margin = new System.Windows.Forms.Padding(2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(98, 98);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Ground.Location = new System.Drawing.Point(-2, 369);
            this.Ground.Margin = new System.Windows.Forms.Padding(2);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(865, 77);
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // JellyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 439);
            this.Controls.Add(this.PlayerMask);
            this.Controls.Add(this.UIText);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Cloud1);
            this.Controls.Add(this.Cloud2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JellyForm";
            this.Text = "JellyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JellyForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JellyForm_FormClosed);
            this.Load += new System.EventHandler(this.JellyForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JellyForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.JellyForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Cloud1;
        private System.Windows.Forms.PictureBox Cloud2;
        private System.Windows.Forms.Label UIText;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox PlayerMask;
    }
}