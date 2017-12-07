using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /* Set Form's Transperancy 100 % */
            this.Opacity = 0;

            /* Start the Timer To Animate Form */
            timer1.Enabled = true;
  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.07;
            Random randonGen = new Random();
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));
            this.BackColor = randomColor;
        }
    }
}
