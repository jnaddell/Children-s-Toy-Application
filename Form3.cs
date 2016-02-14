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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            

            Graphics g = this.CreateGraphics();

            Brush b = new SolidBrush(Color.Maroon);

            Point[] points = new Point[]
        {
            new Point(10, 10),

            new Point(10, 100),

            new Point(50, 65),

            new Point(100, 100),

            new Point(85, 40)};   

            g.FillPolygon(b, points);
        }

      
    }
}
