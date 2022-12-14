using kuma;
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
    public partial class ResultForm : Form
    {
        ShootingForm _ShootingForm;
        JellyForm _JellyForm;
        ReactionForm _ReactionForm;
        MainForm _MainForm;
        YTMT _YTMTForm;
        MineForm _MineForm;
        MoleForm _MoleForm;
        int preScore = 0;
        int preStage = 1;
        Boolean btnClick = false;

        private String gameName;
        public ResultForm(Form form, string gameName, MainForm mainForm)
        {
            if (gameName == "Shooting")
            _ShootingForm = (ShootingForm)form;
            if (gameName == "Jelly")
                _JellyForm = (JellyForm)form;
            if (gameName == "Reaction")
                _ReactionForm = (ReactionForm)form;
            if (gameName == "YTMT")
                _YTMTForm = (YTMT)form;
            if (gameName == "Mine")
                _MineForm = (MineForm)form;
            if (gameName == "Mole")
                _MoleForm = (MoleForm)form;
            this.gameName = gameName;
            _MainForm = mainForm;
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnClick = true;
            if (gameName == "Shooting")
            {
                _ShootingForm = new ShootingForm(_MainForm);
                _ShootingForm.Show();
                this.Close();
            }
            if (gameName == "Jelly")
            {
                _JellyForm = new JellyForm(_MainForm);
                _JellyForm.Show();
                this.Close();
            }
            if (gameName == "YTMT")
            {
                _YTMTForm = new YTMT();
                _YTMTForm.Show();
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnClick = true;
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

            if (gameName == "YTMT")
            {
                this.Text = gameName;
                UI2.Text = "Score : " + _YTMTForm.score;
                IniFile ini = new IniFile();
                try { ini.Load("GameData.ini"); } catch { };
                preScore = ini["니편내편"]["점수"].ToInt();
                if (_YTMTForm.score > preScore)
                {
                    UI1.Text = "Game over! 최고 기록 달성!";
                    ini["니편내편"]["점수"] = _YTMTForm.score;
                }

                ini.Save("GameData.ini");
                UI2.Text = "Score: " + _YTMTForm.score + "   최고 점수: " + preScore;

            }

            if (gameName == "Mine")
            {
                this.Text = gameName;
                UI2.Text = "Score : " + _YTMTForm.score;
                IniFile ini = new IniFile();
                try { ini.Load("GameData.ini"); } catch { };
                preScore = ini["니편내편"]["점수"].ToInt();
                if (_YTMTForm.score > preScore)
                {
                    UI1.Text = "Game over! 최고 기록 달성!";
                    ini["니편내편"]["점수"] = _YTMTForm.score;
                }

                ini.Save("GameData.ini");
                UI2.Text = "Score: " + _YTMTForm.score + "   최고 점수: " + preScore;

            }

            if (gameName == "Mole")
            {
                this.Text = gameName;
                UI2.Text = "Score : " + _MoleForm.score;
                IniFile ini = new IniFile();
                try { ini.Load("GameData.ini"); } catch { };
                preScore = ini["두더지"]["점수"].ToInt();
                if (_MoleForm.score > preScore)
                {
                    UI1.Text = "Game over! 최고 기록 달성!";
                    ini["두더지"]["점수"] = _MoleForm.score;
                }

                ini.Save("GameData.ini");
                UI2.Text = "Score: " + _MoleForm.score + "   최고 점수: " + preScore;

            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void ButtonMain_Click(object sender, EventArgs e)
        {
            btnClick = true;
            Application.Restart();
        }

        private void ResultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btnClick == false)
                Application.Exit();
        }
    }
}
