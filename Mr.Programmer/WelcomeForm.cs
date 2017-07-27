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
    public partial class WelcomeForm : Form
    {
        int i;
        public WelcomeForm()
        {
            this.BackgroundImage = Mr.Programmer.Properties.Resources._587777;
            InitializeComponent();
            i = 0;
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 50) //randomly used depending one the time the split screen would take 
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
