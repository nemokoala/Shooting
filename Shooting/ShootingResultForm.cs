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
    public partial class ShootingResultForm : Form
    {
        ShootingForm _ShootingForm;
        
        public ShootingResultForm(ShootingForm shootingform)
        {
            _ShootingForm = shootingform;
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
            label2.Text = "Score : " + _ShootingForm.score;
            label3.Text = "Stage : " + _ShootingForm.stage;
            IniFile ini = new IniFile();
            try { ini.Load("GameData.ini"); } catch { };      
            int preScore = ini["슈팅"]["점수"].ToInt();
            int preStage = ini["슈팅"]["스테이지"].ToInt();
            if (_ShootingForm.score > preScore)
            {
                label1.Text = "Game over! 최고 기록 달성!";
                ini["슈팅"]["점수"] = _ShootingForm.score;
            }
            
            if (_ShootingForm.stage > preStage)
            {
                label1.Text = "Game over! 최고 기록 달성!";
                ini["슈팅"]["스테이지"] = _ShootingForm.stage;
            }            
            ini.Save("GameData.ini");
            label2.Text = "Score: " + _ShootingForm.score + "   최고 점수: " + preScore;
            label3.Text = "Stage: " + _ShootingForm.stage + "   최고 스테이지: " + preStage;
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
