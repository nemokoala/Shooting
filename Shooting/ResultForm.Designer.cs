namespace Shooting
{
    partial class ResultForm
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
            this.UI1 = new System.Windows.Forms.Label();
            this.UI2 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonRetry = new System.Windows.Forms.Button();
            this.ButtonMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UI1
            // 
            this.UI1.BackColor = System.Drawing.Color.Transparent;
            this.UI1.Font = new System.Drawing.Font("HY견고딕", 25F, System.Drawing.FontStyle.Bold);
            this.UI1.ForeColor = System.Drawing.Color.Red;
            this.UI1.Location = new System.Drawing.Point(27, 365);
            this.UI1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UI1.Name = "UI1";
            this.UI1.Size = new System.Drawing.Size(960, 89);
            this.UI1.TabIndex = 0;
            this.UI1.Text = "Game over!!";
            this.UI1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI2
            // 
            this.UI2.BackColor = System.Drawing.Color.Transparent;
            this.UI2.Font = new System.Drawing.Font("HY견고딕", 25F, System.Drawing.FontStyle.Bold);
            this.UI2.ForeColor = System.Drawing.Color.Transparent;
            this.UI2.Location = new System.Drawing.Point(16, 454);
            this.UI2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UI2.Name = "UI2";
            this.UI2.Size = new System.Drawing.Size(971, 147);
            this.UI2.TabIndex = 0;
            this.UI2.Text = "Score : 000";
            this.UI2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackgroundImage = global::Shooting.Properties.Resources.button;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExit.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonExit.Location = new System.Drawing.Point(695, 644);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(308, 103);
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = "게임 종료";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonRetry
            // 
            this.ButtonRetry.BackgroundImage = global::Shooting.Properties.Resources.button;
            this.ButtonRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRetry.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonRetry.Location = new System.Drawing.Point(19, 644);
            this.ButtonRetry.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonRetry.Name = "ButtonRetry";
            this.ButtonRetry.Size = new System.Drawing.Size(308, 103);
            this.ButtonRetry.TabIndex = 1;
            this.ButtonRetry.Text = "다시하기";
            this.ButtonRetry.UseVisualStyleBackColor = true;
            this.ButtonRetry.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonMain
            // 
            this.ButtonMain.BackgroundImage = global::Shooting.Properties.Resources.button;
            this.ButtonMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMain.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonMain.Location = new System.Drawing.Point(354, 644);
            this.ButtonMain.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonMain.Name = "ButtonMain";
            this.ButtonMain.Size = new System.Drawing.Size(308, 103);
            this.ButtonMain.TabIndex = 1;
            this.ButtonMain.Text = "메인으로";
            this.ButtonMain.UseVisualStyleBackColor = true;
            this.ButtonMain.Click += new System.EventHandler(this.ButtonMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shooting.Properties.Resources.GameOver;
            this.pictureBox1.Location = new System.Drawing.Point(113, -41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 830);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonRetry);
            this.Controls.Add(this.ButtonMain);
            this.Controls.Add(this.UI2);
            this.Controls.Add(this.UI1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultForm_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI1;
        private System.Windows.Forms.Label UI2;
        private System.Windows.Forms.Button ButtonMain;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonRetry;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}