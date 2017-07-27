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
    public partial class About_Me : Form
    {
        public About_Me()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Me_Load(object sender, EventArgs e)
        {
            richTextBox1.Rtf = Mr.Programmer.Properties.Resources.about_me;
            pictureBox1.BackgroundImage = Mr.Programmer.Properties.Resources._1471896_646482435398412_1468404596_n;
        }
    }
}
