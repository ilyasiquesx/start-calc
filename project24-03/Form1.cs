using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project24_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            theDigit.Text = 0.ToString();
        }
        public void isNullString()
        {
            if (theDigit.Text == "0")
            {
                theDigit.Text = null;
            }
        }
        public void arithmeticEx()
        {
            subDigit.Text = null;
            arithmeticSign.Text = null;
            theDigit.Text = "Error";
        }
        private void digit0_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit0.Text;
        }

        private void digit1_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit1.Text;
        }

        private void digit2_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit2.Text;
        }

        private void digit3_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit3.Text;
        }

        private void digit4_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit4.Text;
        }

        private void digit5_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit5.Text;
        }

        private void digit6_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit6.Text;
        }

        private void digit7_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit7.Text;
        }

        private void digit8_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit8.Text;
        }

        private void digit9_Click(object sender, EventArgs e)
        {
            isNullString();
            theDigit.Text += digit9.Text;
        }
        private void signDot_Click(object sender, EventArgs e)
        {
            if (theDigit.Text == "")
            {
                theDigit.Text += digit0.Text + signDot.Text;
            }
            if (!theDigit.Text.Contains(','))
            {
                theDigit.Text += signDot.Text;
            }
        }
        private void signClear_Click(object sender, EventArgs e)
        {
            theDigit.Text = digit0.Text;
            subDigit.Text = null;
            arithmeticSign.Text = null;
        }

        private void signDiv_Click(object sender, EventArgs e)
        {
            try
            {
                arithmeticSign.Text = signDiv.Text;
                if (subDigit.Text != "" && theDigit.Text != "")
                {
                    subDigit.Text = (Convert.ToDouble(subDigit.Text) / Convert.ToDouble(theDigit.Text)).ToString();
                    theDigit.Text = null;
                }
                else if (theDigit.Text != "")
                {
                    subDigit.Text = theDigit.Text;
                    theDigit.Text = null;
                }
            }
            catch (Exception)
            {
                arithmeticEx();
            }
        }
        private void signMulti_Click(object sender, EventArgs e)
        {
            try
            {
                arithmeticSign.Text = signMulti.Text;
                if (subDigit.Text != "" && theDigit.Text != "")
                {
                    subDigit.Text = (Convert.ToDouble(theDigit.Text) * Convert.ToDouble(subDigit.Text)).ToString();
                    theDigit.Text = null;
                }
                else if (theDigit.Text != "")
                {
                    subDigit.Text = theDigit.Text;
                    theDigit.Text = null;
                }
            }
            catch
            {
                arithmeticEx();
            }
        }
        private void signSub_Click(object sender, EventArgs e)
        {
            try
            {
                arithmeticSign.Text = signSub.Text;
                if (subDigit.Text != "" && theDigit.Text != "")
                {
                    subDigit.Text = (Convert.ToDouble(subDigit.Text) - Convert.ToDouble(theDigit.Text)).ToString();
                    theDigit.Text = null;
                }
                else if (theDigit.Text != "")
                {
                    subDigit.Text = theDigit.Text;
                    theDigit.Text = null;
                }
            }
            catch
            {
                arithmeticEx();
            }
        }
        private void signPlus_Click(object sender, EventArgs e)
        {
            try
            {
                arithmeticSign.Text = signPlus.Text;
                if (subDigit.Text != "" && theDigit.Text != "")
                {
                    subDigit.Text = (Convert.ToDouble(theDigit.Text) + Convert.ToDouble(subDigit.Text)).ToString();
                    theDigit.Text = null;
                }
                else if (theDigit.Text != "")
                {
                    subDigit.Text = theDigit.Text;
                    theDigit.Text = null;
                }
            }
            catch
            {
                arithmeticEx();
            }
        }
        private void signEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (arithmeticSign.Text == signMulti.Text && theDigit.Text != "")
                {
                    theDigit.Text = (Convert.ToDouble(theDigit.Text) * Convert.ToDouble(subDigit.Text)).ToString();
                    subDigit.Text = null;
                    arithmeticSign.Text = null;

                }
                if (arithmeticSign.Text == signSub.Text && theDigit.Text != "")
                {
                    theDigit.Text = (Convert.ToDouble(subDigit.Text) - Convert.ToDouble(theDigit.Text)).ToString();
                    subDigit.Text = null;
                    arithmeticSign.Text = null;
                }
                if (arithmeticSign.Text == signPlus.Text && theDigit.Text != "")
                {
                    theDigit.Text = (Convert.ToDouble(theDigit.Text) + Convert.ToDouble(subDigit.Text)).ToString();
                    subDigit.Text = null;
                    arithmeticSign.Text = null;
                }
                if (arithmeticSign.Text == signDiv.Text && theDigit.Text != "")
                {
                    theDigit.Text = (Convert.ToDouble(subDigit.Text) / Convert.ToDouble(theDigit.Text)).ToString();
                    subDigit.Text = null;
                    arithmeticSign.Text = null;
                }
                if (subDigit.Text != "" && theDigit.Text == "")
                {
                    theDigit.Text = subDigit.Text;
                    subDigit.Text = null;
                    arithmeticSign.Text = null;
                }
            }
            catch
            {
                arithmeticEx();
            }
        }
    }
}
