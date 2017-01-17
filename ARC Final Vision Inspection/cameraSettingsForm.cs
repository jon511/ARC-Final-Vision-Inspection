using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARC_Final_Vision_Inspection
{
    public partial class cameraSettingsForm : Form
    {
        public string ipAddress;

        public cameraSettingsForm(string incomingIPAddress)
        {
            InitializeComponent();
            ipAddress = incomingIPAddress;

            if (!string.IsNullOrEmpty(ipAddress))
            {
                if (ipAddress.Length >= 6)
                {
                    string[] stringArray;
                    char seperator = '.';
                    stringArray = ipAddress.Split(seperator);
                    textBox1.Text = stringArray[0];
                    textBox2.Text = stringArray[1];
                    textBox3.Text = stringArray[2];
                    textBox4.Text = stringArray[3];
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

            if (ch == 46)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

            if (ch == 46)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

            if (ch == 46)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Length > 0 && textBox3.Text.Length > 0 && textBox2.Text.Length > 0 && textBox1.Text.Length > 0)
            {
                ipAddress = textBox1.Text + "." + textBox2.Text + "." + textBox3.Text + "." + textBox4.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("IP Address format is invalid.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
