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
            this.ButtonMain = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonRetry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI1
            // 
            this.UI1.Font = new System.Drawing.Font("휴먼옛체", 30F, System.Drawing.FontStyle.Bold);
            this.UI1.ForeColor = System.Drawing.Color.Red;
            this.UI1.Location = new System.Drawing.Point(6, 39);
            this.UI1.Name = "UI1";
            this.UI1.Size = new System.Drawing.Size(611, 51);
            this.UI1.TabIndex = 0;
            this.UI1.Text = "Game over!!";
            this.UI1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI2
            // 
            this.UI2.Font = new System.Drawing.Font("휴먼옛체", 30F, System.Drawing.FontStyle.Bold);
            this.UI2.ForeColor = System.Drawing.Color.Black;
            this.UI2.Location = new System.Drawing.Point(-1, 136);
            this.UI2.Name = "UI2";
            this.UI2.Size = new System.Drawing.Size(618, 42);
            this.UI2.TabIndex = 0;
            this.UI2.Text = "Score : 000";
            this.UI2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonMain
            // 
            this.ButtonMain.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonMain.Location = new System.Drawing.Point(205, 271);
            this.ButtonMain.Name = "ButtonMain";
            this.ButtonMain.Size = new System.Drawing.Size(196, 59);
            this.ButtonMain.TabIndex = 1;
            this.ButtonMain.Text = "메인으로";
            this.ButtonMain.UseVisualStyleBackColor = true;
            this.ButtonMain.Click += new System.EventHandler(this.ButtonMain_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonExit.Location = new System.Drawing.Point(205, 346);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(196, 59);
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = "게임 종료";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonRetry
            // 
            this.ButtonRetry.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonRetry.Location = new System.Drawing.Point(205, 198);
            this.ButtonRetry.Name = "ButtonRetry";
            this.ButtonRetry.Size = new System.Drawing.Size(196, 59);
            this.ButtonRetry.TabIndex = 1;
            this.ButtonRetry.Text = "다시하기";
            this.ButtonRetry.UseVisualStyleBackColor = true;
            this.ButtonRetry.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 426);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonRetry);
            this.Controls.Add(this.ButtonMain);
            this.Controls.Add(this.UI2);
            this.Controls.Add(this.UI1);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UI1;
        private System.Windows.Forms.Label UI2;
        private System.Windows.Forms.Button ButtonMain;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonRetry;
    }
}