﻿using System;
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
    public partial class ReactionForm : Form
    {
        private int ms = 0;
        private int time = 0;
        private int alertTime = 0;
        private Boolean clickEnable = false;
        Random random = new Random();
        ReactionForm reactionForm;
        public ReactionForm()
        {
            InitializeComponent();
            reactionForm = this;
        }

        
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= 0)
            {
                time++;
                //label1.Text = time + "/" + alertTime;
            }
            
            if (time > alertTime)
            {
                if (!clickEnable)
                {
                    clickEnable = true;
                    label1.BackColor = Color.LightBlue;
                    label1.Text = "Click";
                }
                
                ms += 10;
            }
        }

        private void ReactionForm_Load(object sender, EventArgs e)
        {
            alertTime = random.Next(100,500);
            label1.Text = "대기\r\n화면이 하늘색이 되면 바로 클릭하세요";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (time == -1)
            {
                ms = 0;
                time = 0;
                alertTime = random.Next(100, 500);
                clickEnable = false;
                label1.Text = "대기\r\n화면이 하늘색이 되면 바로 클릭하세요";
                label1.BackColor = Color.FromArgb(224, 224, 224);
            }

            if (clickEnable == true)
            {
                time = -1;
                label1.Text = ms + "ms";
                label1.BackColor = Color.LightGreen;
            }

            if (clickEnable == false && time > 0)
            {
                time = -1;
                label1.Text = "클릭을 미리 하지 마시오.";
                label1.BackColor = Color.Red;
            }

        }
    }
}