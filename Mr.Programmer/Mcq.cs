using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mr.Programmer
{
    public partial class Mcq : Form
    {
        public Mcq()
        {
            InitializeComponent();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Mcq_Load(object sender, EventArgs e)
        {
            string[] line = new string[6];

            string fileContent = Mr.Programmer.Properties.Resources.New_Text_Document__2_;

            var reader = new StringReader(fileContent);

            /*open the file where question and answers are and put them in the form labels and radio buttons*/

            /*initially these labels are hidden it is only shown after user gives answer to show the answer is right or wrong*/

            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();

            /*take the first 5 line where first line is the question and the next 4 lines are possible answers and put them in first textbox and four radio buttons*/
            line[0] = reader.ReadLine();
            line[1] = reader.ReadLine();
            line[2] = reader.ReadLine();
            line[3] = reader.ReadLine();
            line[4] = reader.ReadLine();

           label1.Text = line[0];
           
           radioButton1.Text = line[1];
           radioButton2.Text = line[2];
           radioButton3.Text = line[3];
           radioButton4.Text = line[4];

           line[0] = reader.ReadLine();
           line[1] = reader.ReadLine();
           line[2] = reader.ReadLine();
           line[3] = reader.ReadLine();
           line[4] = reader.ReadLine();

           label2.Text = line[0];
           radioButton5.Text = line[1];
           radioButton6.Text = line[2];
           radioButton7.Text = line[3];
           radioButton8.Text = line[4];

           line[0] = reader.ReadLine();
           line[1] = reader.ReadLine();
           line[2] = reader.ReadLine();
           line[3] = reader.ReadLine();
           line[4] = reader.ReadLine();

           label3.Text = line[0];
           radioButton9.Text = line[1];
           radioButton10.Text = line[2];
           radioButton11.Text = line[3];
           radioButton12.Text = line[4];

           line[0] = reader.ReadLine();
           line[1] = reader.ReadLine();
           line[2] = reader.ReadLine();
           line[3] = reader.ReadLine();
           line[4] = reader.ReadLine();

           label4.Text = line[0];
           radioButton13.Text = line[1];
           radioButton14.Text = line[2];
           radioButton15.Text = line[3];
           radioButton16.Text = line[4];


           line[0] = reader.ReadLine();
           line[1] = reader.ReadLine();
           line[2] = reader.ReadLine();
           line[3] = reader.ReadLine();
           line[4] = reader.ReadLine();

           label5.Text = line[0];
           radioButton17.Text = line[1];
           radioButton18.Text = line[2];
           radioButton19.Text = line[3];
           radioButton20.Text = line[4];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*If right button is checked shows right answer on immidiate label or else shows wrong answer*/
            if (radioButton3.Checked)
            {
                label6.BackColor = Color.LightBlue;
                label6.Text = "Right Answer !";
                label6.Visible = true;
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked)
            {
                label6.BackColor = Color.Red;
                label6.Text = "Wrong Answer ! Correct Answer C";
                label6.Visible = true;
            }
            if (radioButton6.Checked)
            {
                label7.BackColor = Color.LightBlue;
                label7.Text = "Right Answer !";
                label7.Visible = true;
            }
            else if (radioButton5.Checked || radioButton7.Checked || radioButton8.Checked)
            {
                label7.BackColor = Color.Red;
                label7.Text = "Wrong Answer ! Correct Answer B";
                label7.Visible = true;
            }
            if (radioButton11.Checked)
            {
                label8.BackColor = Color.LightBlue;
                label8.Text = "Right Answer !";
                label8.Visible = true;
            }
            else if (radioButton9.Checked || radioButton12.Checked || radioButton10.Checked)
            {
                label8.BackColor = Color.Red;
                label8.Text = "Wrong Answer ! Correct Answer C";
                label8.Visible = true;
            }
            if (radioButton14.Checked)
            {
                label9.BackColor = Color.LightBlue;
                label9.Text = "Right Answer !";
                label9.Visible = true;
            }
            else if (radioButton13.Checked || radioButton15.Checked || radioButton16.Checked)
            {
                label9.BackColor = Color.Red;
                label9.Text = "Wrong Answer ! Correct Answer B";
                label9.Visible = true;
            }
            if (radioButton18.Checked)
            {
                label10.BackColor = Color.LightBlue;
                label10.Text = "Right Answer !";
                label10.Visible = true;
            }
            else if (radioButton19.Checked || radioButton17.Checked || radioButton20.Checked)
            {
                label10.BackColor = Color.Red;
                label10.Text = "Wrong Answer ! Correct Answer B";
                label10.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
