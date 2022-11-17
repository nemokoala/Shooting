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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(82, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "게임 재시작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(342, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "게임 종료";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}