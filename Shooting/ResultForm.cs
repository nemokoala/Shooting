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
    public partial class ResultForm : Form
    {
        ShootingForm _ShootingForm;
        JellyForm _JellyForm;
        ReactionForm _ReactionForm;
        int preScore = 0;
        int preStage = 1;

        private String gameName;
        public ResultForm(Form form, string gameName)
        {
            if (gameName == "Shooting")
            _ShootingForm = (ShootingForm)form;
            if (gameName == "Jelly")
                _JellyForm = (JellyForm)form;
            if (gameName == "Reaction")
                _ReactionForm = (ReactionForm)form;
            this.gameName = gameName;
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (gameName == "Shooting")
            {
                this.Text = gameName;
                UI2.Text = "Score : " + _ShootingForm.score + "\nStage : " + _ShootingForm.stage;
                IniFile ini = new IniFile();
                try { ini.Load("GameData.ini"); } catch { };
                preScore = ini["슈팅"]["점수"].ToInt();
                preStage = ini["슈팅"]["스테이지"].ToInt();
                if (_ShootingForm.score > preScore)
                {
                    UI1.Text = "Game over! 최고 기록 달성!";
                    ini["슈팅"]["점수"] = _ShootingForm.score;
                }

                if (_ShootingForm.stage > preStage)
                {
                    UI1.Text = "Game over! 최고 기록 달성!";
                    ini["슈팅"]["스테이지"] = _ShootingForm.stage;
                }
                ini.Save("GameData.ini");
                UI2.Text = "Score: " + _ShootingForm.score + "   최고 점수: " + preScore +
                    "\nStage: " + _ShootingForm.stage + "   최고 스테이지: " + preStage;
            }

            if (gameName == "Jelly")
            {
                this.Text = gameName;
                UI2.Text = "Score : " + _JellyForm.Score;
                IniFile ini = new IniFile();
                try { ini.Load("GameData.ini"); } catch { };
                preScore = ini["젤리"]["점수"].ToInt();                
                if (_JellyForm.Score > preScore)
                {
                    UI1.Text = "Game over! 최고 기록 달성!";
                    ini["젤리"]["점수"] = _JellyForm.Score;
                }

                
                ini.Save("GameData.ini");
                UI2.Text = "Score: " + _JellyForm.Score + "   최고 점수: " + preScore;
                    
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
