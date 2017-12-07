using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cow.AutoSize = true;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();


            s.Load();
            s.Play();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            button1.BackColor = Color.FromArgb(rand.Next());



        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Random rand = new Random();
            button2.BackColor = Color.FromArgb(rand.Next());
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {




            System.Media.SoundPlayer s = new System.Media.SoundPlayer();


            s.Load();
            s.Play();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.BackColor = Color.DarkOrange;
        }



        private void button6_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Red;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.Brown);

                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {


            this.BackColor = Color.Blue;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.Brown);

                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {


            this.BackColor = Color.Green;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.Brown);

                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.Brown);

                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {



            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.Width = 100;
            pictureBox2.Height = 100;



        }










        private void pictureBox3_Click(object sender, EventArgs e)
        {

            pictureBox3.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox3.Width = 100;
            pictureBox3.Height = 100;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            pictureBox4.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox4.Width = 100;
            pictureBox4.Height = 100;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            pictureBox5.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox5.Width = 100;
            pictureBox5.Height = 100;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            pictureBox6.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox6.Width = 100;
            pictureBox6.Height = 100;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            pictureBox7.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox7.Width = 100;
            pictureBox7.Height = 100;
        }









        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Random rand = new Random();
            richTextBox1.ForeColor = Color.FromArgb(rand.Next());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Red;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.Brown);

                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.Brown);

                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.Brown);

                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            Application.DoEvents();
            using (Graphics g = CreateGraphics())
            {
                Pen brown = new Pen(Color.Brown);

                g.FillRectangle(brown.Brush, 10, 10, 100, 50);
                brown.Dispose();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            Random rand = new Random();
            richTextBox2.ForeColor = Color.FromArgb(rand.Next());
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Apple;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Banana;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.grapes;
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.orange;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.strawberry;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            pictureBox13.Image = Properties.Resources.pear;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();

            s.Stream = Properties.Resources.Rooster_1;


            s.Load();
            s.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();

            s.Stream = Properties.Resources.African_Lion;


            s.Load();
            s.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();

            s.Stream = Properties.Resources.Sheep_sound_1;


            s.Load();
            s.Play();
        }





        private void button15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.P)
            {
                button15.PerformClick();
                var myForm = new Form3();
                myForm.Show();


            }
        }

        private void button16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.S)
            {
                button16.PerformClick();
                var myForm = new Form4();
                myForm.Show();


            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var myForm = new Form4();
            myForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        }
    }


       
     

      
       

      

     
       
        

      
   

    
      


      

 
    
