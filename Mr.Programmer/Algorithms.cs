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
    public partial class Algorithms : Form
    {
        public Algorithms()
        {
            this.BackgroundImage = Mr.Programmer.Properties.Resources.programming;
            InitializeComponent();
        }
        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow(); 
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.binary_search_algorithm;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Show();
        }

        private void Algorithms_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.sieve;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.prime_factorization;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.FIbonacci_matrix_multiplication;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.eular_phi_function;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.Modified_sieve;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }
    }
}
