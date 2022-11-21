using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class YTMTEND : Form
    {
        private int score1;
        public YTMTEND(int score)
        {
            InitializeComponent();
            score1 = score;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            label1.Text = "SCORE: " + score1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
