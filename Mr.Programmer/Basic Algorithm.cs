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
    public partial class Basic_Algorithm : Form
    {
        public Basic_Algorithm()
        {
            this.BackgroundImage = Mr.Programmer.Properties.Resources.programming;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.Bubble_sort;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); 
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.Bitwise_tecniques;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); 
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.recursion;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); 
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.binary_search_algorithm;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); 
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.Modular_Exponention;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); 
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.gcd_lcm;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void Basic_Algorithm_Load(object sender, EventArgs e)
        {

        }
    }
}
