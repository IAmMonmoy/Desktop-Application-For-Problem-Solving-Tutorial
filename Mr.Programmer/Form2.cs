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
    public partial class Form2 : Form
    {
        public Form2()
        {
            this.BackgroundImage = Mr.Programmer.Properties.Resources.programming;
            InitializeComponent();
        }

        private void Link_Clicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.Bfs;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.DFS;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.topological_sort;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.Disjoint_set_data_structure;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.kruskal_mst;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.dijkstra;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormShow m = new FormShow();
            m.richTextBox1.Rtf = Mr.Programmer.Properties.Resources.floyed_warshall;
            m.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(Link_Clicked);
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

    }
}
