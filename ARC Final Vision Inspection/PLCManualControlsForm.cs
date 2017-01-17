using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logix;

namespace ARC_Final_Vision_Inspection
{
    public partial class PLCManualControlsForm : Form
    {
        public Controller plc;
        Tag buttonTag = new Tag();
        bool buttonPressActive;

        public PLCSetup plcSettings = new PLCSetup();

        public PLCManualControlsForm()
        {
            InitializeComponent();
        }

        private void PLCManualControlsForm_Load(object sender, EventArgs e)
        {
            plcAutoButton.Visible = false;
            plcManualButton.Visible = false;
            plcManualButton1.Visible = false;
            plcManualButton2.Visible = false;
            plcManualButton3.Visible = false;
            plcManualButton4.Visible = false;
            plcManualButton5.Visible = false;
            plcManualButton6.Visible = false;

            plcManualButton1.Text = "";
            plcManualButton2.Text = "";
            plcManualButton3.Text = "";
            plcManualButton4.Text = "";
            plcManualButton5.Text = "";
            plcManualButton6.Text = "";

            plcAutoButton.Tag = (plcSettings.manualAutoButtonsEnabled) ? assignButtonTags(plcSettings.autoButton) : null;
            plcManualButton.Tag = (plcSettings.manualAutoButtonsEnabled) ? assignButtonTags(plcSettings.manualButton) : null;
            plcManualButton1.Tag = (plcSettings.plcButton1.enabled) ? assignButtonTags(plcSettings.plcButton1) : null;
            plcManualButton2.Tag = (plcSettings.plcButton2.enabled) ? assignButtonTags(plcSettings.plcButton2) : null;
            plcManualButton3.Tag = (plcSettings.plcButton3.enabled) ? assignButtonTags(plcSettings.plcButton3) : null;
            plcManualButton4.Tag = (plcSettings.plcButton4.enabled) ? assignButtonTags(plcSettings.plcButton4) : null;
            plcManualButton5.Tag = (plcSettings.plcButton5.enabled) ? assignButtonTags(plcSettings.plcButton5) : null;
            plcManualButton6.Tag = (plcSettings.plcButton6.enabled) ? assignButtonTags(plcSettings.plcButton6) : null;


            buttonTag.Controller = plc;
            buttonTag.DataType = Logix.Tag.ATOMIC.BOOL;

            updateDisplay();

            foreach (Button button in this.Controls.OfType<Button>())
            {
                
                button.MouseDown += new MouseEventHandler(button_MouseDown);
                //button.MouseUp += new MouseEventHandler(button_MouseUp);
            }

        }


        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            Console.WriteLine("Click");
            if (plc.IsConnected)
            {
                if (button.Tag != null)
                {
                    string[] tag = (string[])button.Tag;

                    if (buttonTag != null && !string.IsNullOrEmpty(tag[0]) && buttonTag.Controller == plc)
                    {
                        Console.WriteLine(buttonTag);
                        Console.WriteLine(tag[0]);
                        Console.WriteLine(buttonTag.Controller);

                        buttonTag.Name = tag[0];
                        bool value = (bool)buttonTag.Now;
                        if (value)
                        {
                            buttonTag.Now = false;
                        }
                        else
                        {
                            buttonTag.Now = true;
                        }
                    }
                }
            }
        }
        

        private string[] assignButtonTags(PLCButton button)
        {
            string[] tag = new string[2];
            tag[0] = button.writeAddress;
            tag[1] = button.readAddress;

            return tag;
        }

        public void updateDisplay()
        {
            if (plcSettings.manualAutoButtonsEnabled)
            {
                plcAutoButton.Visible = true;
                plcManualButton.Visible = true;

                if (plcSettings.manualButton.isActive)
                {
                    plcManualButton.Text = "Manual Mode Is Active";
                    plcManualButton.BackColor = Color.Yellow;
                }
                else
                {
                    plcManualButton.Text = "Press For Manual Mode";
                    plcManualButton.BackColor = Color.LightGray;
                }

                if (plcSettings.autoButton.isActive)
                {
                    plcAutoButton.Text = "Click For Manual Mode";
                    plcAutoButton.BackColor = Color.LightGreen;
                }
                else
                {
                    plcAutoButton.Text = "Click For Auto Mode";
                    plcAutoButton.BackColor = Color.LightGray;
                }

            }

            if (plcSettings.plcButton1.enabled)
            {

                plcManualButton1.Visible = true;

                if (plcSettings.plcButton1.isActive)
                {
                    plcManualButton1.Text = plcSettings.plcButton1.onLabel;
                    plcManualButton1.BackColor = Color.Yellow;
                }
                else
                {
                    plcManualButton1.Text = plcSettings.plcButton1.offLabel;
                    plcManualButton1.BackColor = Color.LightGray;
                }
            }

            if (plcSettings.plcButton2.enabled)
            {
                plcManualButton2.Text = plcSettings.plcButton2.offLabel;
                plcManualButton2.Visible = true;

                if (plcSettings.plcButton2.isActive)
                {
                    plcManualButton2.Text = plcSettings.plcButton2.onLabel;
                    plcManualButton2.BackColor = Color.Yellow;
                }
                else
                {
                    plcManualButton2.Text = plcSettings.plcButton2.offLabel;
                    plcManualButton2.BackColor = Color.LightGray;
                }
            }

            if (plcSettings.plcButton3.enabled)
            {
                plcManualButton3.Text = plcSettings.plcButton3.offLabel;
                plcManualButton3.Visible = true;

                if (plcSettings.plcButton3.isActive)
                {
                    plcManualButton3.Text = plcSettings.plcButton3.onLabel;
                    plcManualButton3.BackColor = Color.Yellow;
                }
                else
                {
                    plcManualButton3.Text = plcSettings.plcButton3.offLabel;
                    plcManualButton3.BackColor = Color.LightGray;
                }
            }

            if (plcSettings.plcButton4.enabled)
            {
                plcManualButton4.Text = plcSettings.plcButton4.offLabel;
                plcManualButton4.Visible = true;

                if (plcSettings.plcButton4.isActive)
                {
                    plcManualButton4.Text = plcSettings.plcButton4.onLabel;
                    plcManualButton4.BackColor = Color.Yellow;
                }
                else
                {
                    plcManualButton4.Text = plcSettings.plcButton4.offLabel;
                    plcManualButton4.BackColor = Color.LightGray;
                }
            }

            if (plcSettings.plcButton5.enabled)
            {
                plcManualButton5.Text = plcSettings.plcButton5.offLabel;
                plcManualButton5.Visible = true;

                if (plcSettings.plcButton5.isActive)
                {
                    plcManualButton5.Text = plcSettings.plcButton5.onLabel;
                    plcManualButton5.BackColor = Color.Yellow;
                }
                else
                {
                    plcManualButton5.Text = plcSettings.plcButton5.offLabel;
                    plcManualButton5.BackColor = Color.LightGray;
                }
            }

            if (plcSettings.plcButton6.enabled)
            {
                plcManualButton6.Text = plcSettings.plcButton6.offLabel;
                plcManualButton6.Visible = true;



                if (plcSettings.plcButton6.isActive)
                {
                    plcManualButton6.Text = plcSettings.plcButton6.onLabel;
                    plcManualButton6.BackColor = Color.Yellow;
                }
                else
                {
                    plcManualButton6.Text = plcSettings.plcButton6.offLabel;
                    plcManualButton6.BackColor = Color.LightGray;
                }
            }
        }

        private void plcManualControlsDoneButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PLCManualControlsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.MouseDown -= new MouseEventHandler(button_MouseDown);
            }
        }

        

        



    }
}
