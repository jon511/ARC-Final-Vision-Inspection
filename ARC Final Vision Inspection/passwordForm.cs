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
    public partial class passwordForm : Form
    {
        public passwordForm()
        {
            InitializeComponent();
        }

        private void passwordOKButton_Click(object sender, EventArgs e)
        {
            verifyPassword();
            this.Close();
        }

        private void verifyPassword()
        {
            string password = "12345";
            if (passwordTextbox.Text == password)
            {

                frmMain.isLocked = false;
                
            }

        }

        private void usernameTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string password = "12345";
            if (passwordTextbox.Text == password)
            {

                frmMain.isLocked = false;
            }
        }

        private void passwordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                verifyPassword();
                this.Close();
            }
        }

        private void passwordCancelButton_Click(object sender, EventArgs e)
        {
            frmMain.skipPassword = true;
            this.Close();
        }


    }
}
