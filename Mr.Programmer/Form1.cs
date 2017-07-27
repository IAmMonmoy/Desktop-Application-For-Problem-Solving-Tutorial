using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mr.Programmer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DuringStaringProgram m = new DuringStaringProgram(); //A class used to take recent date
            label1.Text = label1.Text + m.DateAndTime; /*shows time in main form*/
        }
        
 
        private void Form1_Load(object sender, EventArgs e)
        {
           WelcomeForm x = new WelcomeForm(); // split screen from
           this.Hide();
           x.ShowDialog();
           this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do U Want To Exit ?"," EXIT",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if (dialogresult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); /*A Dedicated form used only to show documents*/
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.link; /*oepns needed file that is on program resources*/
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked); /*Link clicked event if link is clicked it is opend on browser. Link_Clicked is a function*/
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); 
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.Ad_hoc;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); 
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.stl;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Basic_Algorithm m = new Basic_Algorithm();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Algorithms m = new Algorithms();
            this.Hide();
            m.ShowDialog();
            this.Show();

        }

        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e) // this is Link_Clicked function which start the link in browser
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Mcq m = new Mcq();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            About_Me m = new About_Me();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.about_me;
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.Copy;
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

    }
}
