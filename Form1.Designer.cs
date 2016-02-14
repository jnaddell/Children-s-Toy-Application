namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape12 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape8 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape7 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rectangleShape11 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape13 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(110, 228);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(428, 80);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "Type anything in this box and watch as the text changes colors!";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(552, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 63);
            this.button3.TabIndex = 7;
            this.button3.Text = "Change Background to Red!";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(552, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 67);
            this.button5.TabIndex = 8;
            this.button5.Text = "Change Background to Blue!";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Orange;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(552, 81);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 67);
            this.button10.TabIndex = 9;
            this.button10.Text = "Change background to Orange!";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Green;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(552, 154);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 68);
            this.button11.TabIndex = 10;
            this.button11.Text = "Change Background to Green!";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape13,
            this.rectangleShape11,
            this.rectangleShape12,
            this.rectangleShape8,
            this.rectangleShape7});
            this.shapeContainer2.Size = new System.Drawing.Size(669, 311);
            this.shapeContainer2.TabIndex = 11;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape12
            // 
            this.rectangleShape12.Location = new System.Drawing.Point(110, 69);
            this.rectangleShape12.Name = "rectangleShape12";
            this.rectangleShape12.Size = new System.Drawing.Size(428, 139);
            // 
            // rectangleShape8
            // 
            this.rectangleShape8.Location = new System.Drawing.Point(542, 0);
            this.rectangleShape8.Name = "rectangleShape8";
            this.rectangleShape8.Size = new System.Drawing.Size(129, 310);
            // 
            // rectangleShape7
            // 
            this.rectangleShape7.Location = new System.Drawing.Point(106, 215);
            this.rectangleShape7.Name = "rectangleShape7";
            this.rectangleShape7.Size = new System.Drawing.Size(434, 95);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(3, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(98, 56);
            this.button12.TabIndex = 12;
            this.button12.Text = "Click the Rooster Sound!";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(3, 69);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(98, 56);
            this.button13.TabIndex = 13;
            this.button13.Text = "Click for Lion Sound!";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(3, 131);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 55);
            this.button14.TabIndex = 14;
            this.button14.Text = "Click for Sheep Sound!";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(3, 209);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(98, 46);
            this.button15.TabIndex = 16;
            this.button15.Text = "Press P for the Pentagon";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button15_KeyPress);
            // 
            // button16
            // 
            this.button16.CausesValidation = false;
            this.button16.Location = new System.Drawing.Point(3, 257);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(98, 51);
            this.button16.TabIndex = 17;
            this.button16.Text = "Click for the Square!";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            this.button16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button16_KeyPress);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::WindowsFormsApplication1.Properties.Resources.happy;
            this.pictureBox14.Location = new System.Drawing.Point(120, 0);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(399, 54);
            this.pictureBox14.TabIndex = 15;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::WindowsFormsApplication1.Properties.Resources.pear1;
            this.pictureBox13.Location = new System.Drawing.Point(472, 81);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(47, 50);
            this.pictureBox13.TabIndex = 5;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.MouseHover += new System.EventHandler(this.pictureBox13_MouseHover);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::WindowsFormsApplication1.Properties.Resources.strawberry1;
            this.pictureBox12.Location = new System.Drawing.Point(393, 81);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(67, 50);
            this.pictureBox12.TabIndex = 4;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.MouseHover += new System.EventHandler(this.pictureBox12_MouseHover);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApplication1.Properties.Resources.orange1;
            this.pictureBox11.Location = new System.Drawing.Point(183, 81);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(51, 50);
            this.pictureBox11.TabIndex = 3;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.MouseHover += new System.EventHandler(this.pictureBox11_MouseHover);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApplication1.Properties.Resources.grapes1;
            this.pictureBox10.Location = new System.Drawing.Point(306, 81);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(81, 50);
            this.pictureBox10.TabIndex = 2;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.MouseHover += new System.EventHandler(this.pictureBox10_MouseHover);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApplication1.Properties.Resources.Banana1;
            this.pictureBox9.Location = new System.Drawing.Point(240, 81);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(60, 51);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.MouseHover += new System.EventHandler(this.pictureBox9_MouseHover);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApplication1.Properties.Resources.Apple1;
            this.pictureBox8.Location = new System.Drawing.Point(120, 81);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(57, 51);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.MouseHover += new System.EventHandler(this.pictureBox8_MouseHover);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(425, 26);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Put your mouse over any of the fruits to make them dance!!!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rectangleShape11
            // 
            this.rectangleShape11.Location = new System.Drawing.Point(1, 4);
            this.rectangleShape11.Name = "rectangleShape11";
            this.rectangleShape11.Size = new System.Drawing.Size(105, 194);
            // 
            // rectangleShape13
            // 
            this.rectangleShape13.Location = new System.Drawing.Point(-2, 200);
            this.rectangleShape13.Name = "rectangleShape13";
            this.rectangleShape13.Size = new System.Drawing.Size(108, 110);
            // 
            // Form1
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(669, 311);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.shapeContainer2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button15_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cow;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape10;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape9;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape8;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape7;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape12;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape13;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape11;
    }
}

