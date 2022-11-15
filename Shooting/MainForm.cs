using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shooting
{ 
    public partial class MainForm : Form
    {
        private int shootingStage = 0;
        private int shootingScore = 0;
        public static Boolean ShowMainForm = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShootingForm form1 = new ShootingForm();
            form1.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReactionForm reactionForm = new ReactionForm();
            reactionForm.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JellyForm jellyForm = new JellyForm();
            jellyForm.Show();
            //this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
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

            button1.Text = "슈팅게임\r최대 점수: " + shootingScore + "\r최대 스테이지: " + shootingStage;
        }
    }
}
