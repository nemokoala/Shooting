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
            this.MoleBtn = new System.Windows.Forms.Button();
            this.UITEXT = new System.Windows.Forms.Label();
            this.MainText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShootingBtn
            // 
            this.ShootingBtn.BackgroundImage = global::Shooting.Properties.Resources.슈팅버튼;
            this.ShootingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShootingBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShootingBtn.Location = new System.Drawing.Point(11, 115);
            this.ShootingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShootingBtn.Name = "ShootingBtn";
            this.ShootingBtn.Size = new System.Drawing.Size(400, 100);
            this.ShootingBtn.TabIndex = 0;
            this.ShootingBtn.Text = "슈팅 게임";
            this.ShootingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShootingBtn.UseVisualStyleBackColor = true;
            this.ShootingBtn.Click += new System.EventHandler(this.ShootingBtn_Click);
            this.ShootingBtn.MouseHover += new System.EventHandler(this.ShootingBtn_MouseHover);
            // 
            // ReactionBtn
            // 
            this.ReactionBtn.BackgroundImage = global::Shooting.Properties.Resources.반응속도버튼;
            this.ReactionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReactionBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.ReactionBtn.Location = new System.Drawing.Point(420, 115);
            this.ReactionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReactionBtn.Name = "ReactionBtn";
            this.ReactionBtn.Size = new System.Drawing.Size(400, 100);
            this.ReactionBtn.TabIndex = 0;
            this.ReactionBtn.Text = "반응속도 테스트";
            this.ReactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReactionBtn.UseVisualStyleBackColor = true;
            this.ReactionBtn.Click += new System.EventHandler(this.ReactionBtn_Click);
            this.ReactionBtn.MouseHover += new System.EventHandler(this.ReactionBtn_MouseHover);
            // 
            // DinoBtn
            // 
            this.DinoBtn.BackgroundImage = global::Shooting.Properties.Resources.공룡버튼;
            this.DinoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DinoBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.DinoBtn.Location = new System.Drawing.Point(11, 219);
            this.DinoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DinoBtn.Name = "DinoBtn";
            this.DinoBtn.Size = new System.Drawing.Size(400, 100);
            this.DinoBtn.TabIndex = 0;
            this.DinoBtn.Text = "공룡 점프";
            this.DinoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DinoBtn.UseVisualStyleBackColor = true;
            this.DinoBtn.Click += new System.EventHandler(this.DinoBtn_Click);
            this.DinoBtn.MouseHover += new System.EventHandler(this.DinoBtn_MouseHover);
            // 
            // MineBtn
            // 
            this.MineBtn.BackgroundImage = global::Shooting.Properties.Resources.지뢰찾기버튼;
            this.MineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MineBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.MineBtn.Location = new System.Drawing.Point(420, 323);
            this.MineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MineBtn.Name = "MineBtn";
            this.MineBtn.Size = new System.Drawing.Size(400, 100);
            this.MineBtn.TabIndex = 0;
            this.MineBtn.Text = "지뢰 찾기";
            this.MineBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MineBtn.UseVisualStyleBackColor = true;
            this.MineBtn.Click += new System.EventHandler(this.MineBtn_Click);
            this.MineBtn.MouseHover += new System.EventHandler(this.MineBtn_MouseHover);
            // 
            // YTMTBtn
            // 
            this.YTMTBtn.BackgroundImage = global::Shooting.Properties.Resources.니편내편버튼;
            this.YTMTBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YTMTBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.YTMTBtn.Location = new System.Drawing.Point(420, 219);
            this.YTMTBtn.Margin = new System.Windows.Forms.Padding(2);
            this.YTMTBtn.Name = "YTMTBtn";
            this.YTMTBtn.Size = new System.Drawing.Size(400, 100);
            this.YTMTBtn.TabIndex = 0;
            this.YTMTBtn.Text = "니편 내편";
            this.YTMTBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.YTMTBtn.UseVisualStyleBackColor = true;
            this.YTMTBtn.Click += new System.EventHandler(this.YTMTBtn_Click);
            this.YTMTBtn.MouseHover += new System.EventHandler(this.YTMTBtn_MouseHover);
            // 
            // MoleBtn
            // 
            this.MoleBtn.BackgroundImage = global::Shooting.Properties.Resources.두더지버튼;
            this.MoleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoleBtn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.MoleBtn.Location = new System.Drawing.Point(11, 323);
            this.MoleBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MoleBtn.Name = "MoleBtn";
            this.MoleBtn.Size = new System.Drawing.Size(400, 100);
            this.MoleBtn.TabIndex = 0;
            this.MoleBtn.Text = "두더지 찾기";
            this.MoleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoleBtn.UseVisualStyleBackColor = true;
            this.MoleBtn.Click += new System.EventHandler(this.MoleBtn_Click);
            this.MoleBtn.MouseHover += new System.EventHandler(this.MoleBtn_MouseHover);
            // 
            // UITEXT
            // 
            this.UITEXT.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UITEXT.Location = new System.Drawing.Point(12, 435);
            this.UITEXT.Name = "UITEXT";
            this.UITEXT.Size = new System.Drawing.Size(807, 207);
            this.UITEXT.TabIndex = 1;
            this.UITEXT.Text = "버튼 위에 마우스를 올려 놓으면. 게임 설명을 표시해 줍니다.";
            // 
            // MainText
            // 
            this.MainText.BackColor = System.Drawing.Color.Transparent;
            this.MainText.Font = new System.Drawing.Font("휴먼편지체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainText.ForeColor = System.Drawing.SystemColors.Control;
            this.MainText.Location = new System.Drawing.Point(251, 31);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(339, 56);
            this.MainText.TabIndex = 2;
            this.MainText.Text = "미니게임 천국";
            this.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shooting.Properties.Resources.메인배경;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 651);
            this.Controls.Add(this.MainText);
            this.Controls.Add(this.UITEXT);
            this.Controls.Add(this.MoleBtn);
            this.Controls.Add(this.YTMTBtn);
            this.Controls.Add(this.MineBtn);
            this.Controls.Add(this.DinoBtn);
            this.Controls.Add(this.ReactionBtn);
            this.Controls.Add(this.ShootingBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button MoleBtn;
        private System.Windows.Forms.Label UITEXT;
        private System.Windows.Forms.Label MainText;
    }
}