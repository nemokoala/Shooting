namespace Shooting
{
    partial class MainForm
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
            this.ShootingBtn = new System.Windows.Forms.Button();
            this.ReactionBtn = new System.Windows.Forms.Button();
            this.DinoBtn = new System.Windows.Forms.Button();
            this.MineBtn = new System.Windows.Forms.Button();
            this.YTMTBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShootingBtn
            // 
            this.ShootingBtn.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.ShootingBtn.Location = new System.Drawing.Point(34, 49);
            this.ShootingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShootingBtn.Name = "ShootingBtn";
            this.ShootingBtn.Size = new System.Drawing.Size(123, 106);
            this.ShootingBtn.TabIndex = 0;
            this.ShootingBtn.Text = "슈팅 게임";
            this.ShootingBtn.UseVisualStyleBackColor = true;
            this.ShootingBtn.Click += new System.EventHandler(this.ShootingBtn_Click);
            // 
            // ReactionBtn
            // 
            this.ReactionBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReactionBtn.Location = new System.Drawing.Point(195, 49);
            this.ReactionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReactionBtn.Name = "ReactionBtn";
            this.ReactionBtn.Size = new System.Drawing.Size(123, 106);
            this.ReactionBtn.TabIndex = 0;
            this.ReactionBtn.Text = "반응속도 테스트";
            this.ReactionBtn.UseVisualStyleBackColor = true;
            this.ReactionBtn.Click += new System.EventHandler(this.ReactionBtn_Click);
            // 
            // DinoBtn
            // 
            this.DinoBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DinoBtn.Location = new System.Drawing.Point(345, 49);
            this.DinoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DinoBtn.Name = "DinoBtn";
            this.DinoBtn.Size = new System.Drawing.Size(123, 106);
            this.DinoBtn.TabIndex = 0;
            this.DinoBtn.Text = "공룡 점프";
            this.DinoBtn.UseVisualStyleBackColor = true;
            this.DinoBtn.Click += new System.EventHandler(this.DinoBtn_Click);
            // 
            // MineBtn
            // 
            this.MineBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MineBtn.Location = new System.Drawing.Point(34, 179);
            this.MineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MineBtn.Name = "MineBtn";
            this.MineBtn.Size = new System.Drawing.Size(123, 106);
            this.MineBtn.TabIndex = 0;
            this.MineBtn.Text = "지뢰 찾기";
            this.MineBtn.UseVisualStyleBackColor = true;
            this.MineBtn.Click += new System.EventHandler(this.MineBtn_Click);
            // 
            // YTMTBtn
            // 
            this.YTMTBtn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.YTMTBtn.Location = new System.Drawing.Point(195, 179);
            this.YTMTBtn.Margin = new System.Windows.Forms.Padding(2);
            this.YTMTBtn.Name = "YTMTBtn";
            this.YTMTBtn.Size = new System.Drawing.Size(123, 106);
            this.YTMTBtn.TabIndex = 0;
            this.YTMTBtn.Text = "니편 내편";
            this.YTMTBtn.UseVisualStyleBackColor = true;
            this.YTMTBtn.Click += new System.EventHandler(this.YTMTBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 342);
            this.Controls.Add(this.YTMTBtn);
            this.Controls.Add(this.MineBtn);
            this.Controls.Add(this.DinoBtn);
            this.Controls.Add(this.ReactionBtn);
            this.Controls.Add(this.ShootingBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShootingBtn;
        private System.Windows.Forms.Button ReactionBtn;
        private System.Windows.Forms.Button DinoBtn;
        private System.Windows.Forms.Button MineBtn;
        private System.Windows.Forms.Button YTMTBtn;
    }
}