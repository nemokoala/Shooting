using MineSweeperFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace Shooting
{ 
    public partial class MainForm : Form
    {
        private int shootingStage = 0;
        private int shootingScore = 0;
        private int jellyScore = 0;
        private int reactionScore = 0;
        private int ytmtScore = 0;
        public static Boolean ShowMainForm = true;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            IniFile ini = new IniFile();
            try
            {
                ini.Load("GameData.ini");
            }
            catch
            {

            }

            shootingScore = ini["슈팅"]["점수"].ToInt();
            shootingStage = ini["슈팅"]["스테이지"].ToInt();
            jellyScore = ini["젤리"]["점수"].ToInt();
            reactionScore = ini["반응속도"]["점수"].ToInt();
            ytmtScore = ini["니편내편"]["점수"].ToInt();

            ShootingBtn.Text = "슈팅게임\r최대 점수: " + shootingScore + "\r최대 스테이지: " + shootingStage;
            ReactionBtn.Text = "반응속도 게임\r최고 반응속도: " + reactionScore + "ms";
            DinoBtn.Text = "공룡게임\r최대 점수: " + jellyScore;
            YTMTBtn.Text = "니편내편\r최대 점수: " + ytmtScore;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void ShootingBtn_Click(object sender, EventArgs e)
        {
            ShootingForm form1 = new ShootingForm(this);
            form1.Show();
            this.Hide();
        }
        private void ReactionBtn_Click(object sender, EventArgs e)
        {
            ReactionForm reactionForm = new ReactionForm(this);
            reactionForm.Show();
            this.Hide();
        }
        private void DinoBtn_Click(object sender, EventArgs e)
        {
            JellyForm jellyForm = new JellyForm(this);
            jellyForm.Show();
            this.Hide();
        }
        private void MineBtn_Click(object sender, EventArgs e)
        {
            GameInit gameInit = new GameInit();
            gameInit.Show();
            this.Hide();
        }

        private void YTMTBtn_Click(object sender, EventArgs e)
        {
            YTMT yTMT = new YTMT();
            yTMT.Show();
            this.Hide();
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
