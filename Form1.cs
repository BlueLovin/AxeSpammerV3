using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxeSpammerV3_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start button
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                fstring = richTextBox1.Text.ToString() + "{ENTER}";
            }
            if (timer1.Interval == 1)
            {
                MessageBox.Show("No delay chosen.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (timer1.Interval > 1)
            {
            timer1.Enabled = true;
            checkBox1.Enabled = false;
            richTextBox1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fstring = richTextBox1.Text.ToString();
            if (checkBox1.Checked == true)
            {
                SendKeys.Send(fstring + "{ENTER}");
            }
            if (checkBox1.Checked == false)
            {
                SendKeys.Send(fstring);
            }
        }

        public string fstring { get; set; }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 200;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 300;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 400;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }
        /// <summary>
        /// Stop button
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                MessageBox.Show("Nothing to stop!", "You fucking idiot", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (timer1.Enabled == true)
            {
            timer1.Enabled = false;
            checkBox1.Enabled = true;
            richTextBox1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //fstring = fstring + "{ENTER}";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
