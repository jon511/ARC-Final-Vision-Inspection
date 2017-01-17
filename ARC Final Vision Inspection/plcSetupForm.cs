using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ARC_Final_Vision_Inspection
{
    public partial class plcSetupForm : Form
    {
        public PLCSetup plcSettings = new PLCSetup();

        public plcSetupForm()
        {
            InitializeComponent();
        }

        private void plcSetupForm_Load(object sender, EventArgs e)
        {
            updateCheckboxes();
            updateDisplay();

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            }
        }

        void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(sender.GetType());
            TextBox textbox = (TextBox)sender;

            if (textbox.Tag != null)
            {
                if (textbox.Tag.ToString() == "1")
                {
                    char ch = e.KeyChar;

                    if (Char.IsWhiteSpace(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                }
                else if (textbox.Tag.ToString() == "2")
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
                else
                {
                    char ch = e.KeyChar;

                    if (!Char.IsDigit(ch) && ch != 8)
                    {
                        e.Handled = true;
                    }
                }

                
            }

        }

        private void updateCheckboxes()
        {

            //plcIPAddressTextbox.Enabled = plcEnableCheckbox.Checked;
            textBox1.Enabled = plcEnableCheckbox.Checked;
            textBox2.Enabled = plcEnableCheckbox.Checked;
            textBox3.Enabled = plcEnableCheckbox.Checked;
            textBox4.Enabled = plcEnableCheckbox.Checked;

            plcMessageDisplayAddressTextbox.Enabled = plcEnableCheckbox.Checked;
            plcMessageDisplayColorAddressTextbox.Enabled = plcEnableCheckbox.Checked;
            mainSerialNumberPLCAddressTextbox.Enabled = plcEnableCheckbox.Checked;
            plcSecondaryMessageEnableCheckBox1.Enabled = plcEnableCheckbox.Checked;
            mainMessageTitleTextBox.Enabled = (plcEnableCheckbox.Checked);
            secondaryMessageTitleTextBox.Enabled = (plcSecondaryMessageEnableCheckBox1.Enabled & plcSecondaryMessageEnableCheckBox1.Checked);
            plcSecondaryMessageDisplayAddressTextbox.Enabled = (plcSecondaryMessageEnableCheckBox1.Enabled & plcSecondaryMessageEnableCheckBox1.Checked);
            plcSecondaryMessageDisplayColorAddressTextbox.Enabled = (plcSecondaryMessageEnableCheckBox1.Enabled & plcSecondaryMessageEnableCheckBox1.Checked);
            secondarySerialNumberPLCAddressTextBox.Enabled = (plcSecondaryMessageEnableCheckBox1.Enabled & plcSecondaryMessageEnableCheckBox1.Checked);

            plcPartCountEnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcGoodCountAddressTextbox.Enabled = (plcPartCountEnableCheckbox.Enabled & plcPartCountEnableCheckbox.Checked);
            plcBadCountAddressTextbox.Enabled = (plcPartCountEnableCheckbox.Enabled & plcPartCountEnableCheckbox.Checked);
            plcCounterResetButtonAddressTextBox.Enabled = (plcPartCountEnableCheckbox.Enabled & plcPartCountEnableCheckbox.Checked);

            plcSecondaryPartCountEnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcSecondaryGoodCountAddressTextbox.Enabled = (plcSecondaryPartCountEnableCheckbox.Enabled & plcSecondaryPartCountEnableCheckbox.Checked);
            plcSecondaryBadCountAddressTextbox.Enabled = (plcSecondaryPartCountEnableCheckbox.Enabled & plcSecondaryPartCountEnableCheckbox.Checked);
            plcSecondaryCounterResetButtonAddressTextBox.Enabled = (plcSecondaryPartCountEnableCheckbox.Enabled & plcSecondaryPartCountEnableCheckbox.Checked);

            plcResultMonitorEnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcResult1AddressTextBox.Enabled = (plcResultMonitorEnableCheckbox.Enabled & plcResultMonitorEnableCheckbox.Checked);
            plcResult2AddressTextBox.Enabled = (plcResultMonitorEnableCheckbox.Enabled & plcResultMonitorEnableCheckbox.Checked);
            plcResult3AddressTextBox.Enabled = (plcResultMonitorEnableCheckbox.Enabled & plcResultMonitorEnableCheckbox.Checked);

            checkBox1.Enabled = plcEnableCheckbox.Checked;
            plcSecondaryResult1AddressTextBox.Enabled = (checkBox1.Enabled & checkBox1.Checked);
            plcSecondaryResult2AddressTextBox.Enabled = (checkBox1.Enabled & checkBox1.Checked);
            plcSecondaryResult3AddressTextBox.Enabled = (checkBox1.Enabled & checkBox1.Checked);


            plcAutoManualEnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcAutoBtnReadAddressTextbox.Enabled = (plcAutoManualEnableCheckbox.Enabled & plcAutoManualEnableCheckbox.Checked);
            plcAutoBtnWriteAddressTextbox.Enabled = (plcAutoManualEnableCheckbox.Enabled & plcAutoManualEnableCheckbox.Checked);
            plcManualBtnReadAddressTextbox.Enabled = (plcAutoManualEnableCheckbox.Enabled & plcAutoManualEnableCheckbox.Checked);
            plcManualBtnWriteAddressTextbox.Enabled = (plcAutoManualEnableCheckbox.Enabled & plcAutoManualEnableCheckbox.Checked);

            plcUserBtn1EnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcUserBtn1WriteAddressTextbox.Enabled = (plcUserBtn1EnableCheckbox.Enabled & plcUserBtn1EnableCheckbox.Checked);
            plcUserBtn1ReadAddressTextbox.Enabled = (plcUserBtn1EnableCheckbox.Enabled & plcUserBtn1EnableCheckbox.Checked);
            plcUserBtn1OffLabelTextbox.Enabled = (plcUserBtn1EnableCheckbox.Enabled & plcUserBtn1EnableCheckbox.Checked);
            plcUserBtn1OnLabelTextbox.Enabled = (plcUserBtn1EnableCheckbox.Enabled & plcUserBtn1EnableCheckbox.Checked);

            plcUserBtn2EnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcUserBtn2WriteAddressTextbox.Enabled = (plcUserBtn2EnableCheckbox.Enabled & plcUserBtn2EnableCheckbox.Checked);
            plcUserBtn2ReadAddressTextbox.Enabled = (plcUserBtn2EnableCheckbox.Enabled & plcUserBtn2EnableCheckbox.Checked);
            plcUserBtn2OffLabelTextbox.Enabled = (plcUserBtn2EnableCheckbox.Enabled & plcUserBtn2EnableCheckbox.Checked);
            plcUserBtn2OnLabelTextbox.Enabled = (plcUserBtn2EnableCheckbox.Enabled & plcUserBtn2EnableCheckbox.Checked);

            plcUserBtn3EnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcUserBtn3WriteAddressTextbox.Enabled = (plcUserBtn3EnableCheckbox.Enabled & plcUserBtn3EnableCheckbox.Checked);
            plcUserBtn3ReadAddressTextbox.Enabled = (plcUserBtn3EnableCheckbox.Enabled & plcUserBtn3EnableCheckbox.Checked);
            plcUserBtn3OffLabelTextbox.Enabled = (plcUserBtn3EnableCheckbox.Enabled & plcUserBtn3EnableCheckbox.Checked);
            plcUserBtn3OnLabelTextbox.Enabled = (plcUserBtn3EnableCheckbox.Enabled & plcUserBtn3EnableCheckbox.Checked);

            plcUserBtn4EnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcUserBtn4WriteAddressTextbox.Enabled = (plcUserBtn4EnableCheckbox.Enabled & plcUserBtn4EnableCheckbox.Checked);
            plcUserBtn4ReadAddressTextbox.Enabled = (plcUserBtn4EnableCheckbox.Enabled & plcUserBtn4EnableCheckbox.Checked);
            plcUserBtn4OffLabelTextbox.Enabled = (plcUserBtn4EnableCheckbox.Enabled & plcUserBtn4EnableCheckbox.Checked);
            plcUserBtn4OnLabelTextbox.Enabled = (plcUserBtn4EnableCheckbox.Enabled & plcUserBtn4EnableCheckbox.Checked);

            plcUserBtn5EnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcUserBtn5WriteAddressTextbox.Enabled = (plcUserBtn5EnableCheckbox.Enabled & plcUserBtn5EnableCheckbox.Checked);
            plcUserBtn5ReadAddressTextbox.Enabled = (plcUserBtn5EnableCheckbox.Enabled & plcUserBtn5EnableCheckbox.Checked);
            plcUserBtn5OffLabelTextbox.Enabled = (plcUserBtn5EnableCheckbox.Enabled & plcUserBtn5EnableCheckbox.Checked);
            plcUserBtn5OnLabelTextbox.Enabled = (plcUserBtn5EnableCheckbox.Enabled & plcUserBtn5EnableCheckbox.Checked);

            plcUserBtn6EnableCheckbox.Enabled = plcEnableCheckbox.Checked;
            plcUserBtn6WriteAddressTextbox.Enabled = (plcUserBtn6EnableCheckbox.Enabled & plcUserBtn6EnableCheckbox.Checked);
            plcUserBtn6ReadAddressTextbox.Enabled = (plcUserBtn6EnableCheckbox.Enabled & plcUserBtn6EnableCheckbox.Checked);
            plcUserBtn6OffLabelTextbox.Enabled = (plcUserBtn6EnableCheckbox.Enabled & plcUserBtn6EnableCheckbox.Checked);
            plcUserBtn6OnLabelTextbox.Enabled = (plcUserBtn6EnableCheckbox.Enabled & plcUserBtn6EnableCheckbox.Checked);


        }

        private void updateDisplay()
        {

            plcEnableCheckbox.Checked = plcSettings.communicationEnabled;
            //plcIPAddressTextbox.Text = plcSettings.ipAddress;
            setIPAddressTextBoxes(plcSettings.ipAddress);
            //plcIPAddressTextbox.Enabled = (plcEnableCheckbox.Checked & plcSettings.communicationEnabled);
            textBox1.Enabled = (plcEnableCheckbox.Checked & plcSettings.communicationEnabled);
            textBox2.Enabled = (plcEnableCheckbox.Checked & plcSettings.communicationEnabled);
            textBox3.Enabled = (plcEnableCheckbox.Checked & plcSettings.communicationEnabled);
            textBox4.Enabled = (plcEnableCheckbox.Checked & plcSettings.communicationEnabled);

            plcMessageDisplayAddressTextbox.Text = plcSettings.displayMessageAddress;
            plcMessageDisplayColorAddressTextbox.Text = plcSettings.displayMessageColorAddress;
            mainSerialNumberPLCAddressTextbox.Text = plcSettings.mainSerialNumberAddress;
            plcSecondaryMessageEnableCheckBox1.Checked = plcSettings.secondaryMessageEnabled;
            mainMessageTitleTextBox.Text = plcSettings.displayMessageTitle;
            secondaryMessageTitleTextBox.Text = plcSettings.secondaryMessageTitle;
            plcSecondaryMessageDisplayAddressTextbox.Text = plcSettings.secondaryDisplayMessageAddress;
            plcSecondaryMessageDisplayColorAddressTextbox.Text = plcSettings.secondaryDisplayMessageColorAddress;
            secondarySerialNumberPLCAddressTextBox.Text = plcSettings.secondarySerialNumberAddress;

            plcPartCountEnableCheckbox.Checked = plcSettings.countersEnabled;
            plcGoodCountAddressTextbox.Text = plcSettings.plcPartcounter.goodCountPLCAddress;
            plcBadCountAddressTextbox.Text = plcSettings.plcPartcounter.rejectCountPLCAddress;
            plcCounterResetButtonAddressTextBox.Text = plcSettings.plcPartcounter.resetButton.writeAddress;

            plcSecondaryPartCountEnableCheckbox.Checked = plcSettings.secondaryCountersEnabled;
            plcSecondaryGoodCountAddressTextbox.Text = plcSettings.plcSecPartCounter.goodCountPLCAddress;
            plcSecondaryBadCountAddressTextbox.Text = plcSettings.plcSecPartCounter.rejectCountPLCAddress;
            plcSecondaryCounterResetButtonAddressTextBox.Text = plcSettings.plcSecPartCounter.resetButton.writeAddress;

            plcResultMonitorEnableCheckbox.Checked = plcSettings.resultsEnabled;
            plcResult1AddressTextBox.Text = plcSettings.plcResult.plcResult1Address;
            plcResult2AddressTextBox.Text = plcSettings.plcResult.plcResult2Address;
            plcResult3AddressTextBox.Text = plcSettings.plcResult.plcResult3Address;

            checkBox1.Checked = plcSettings.secondaryResultsEnabled;
            plcSecondaryResult1AddressTextBox.Text = plcSettings.plcSecondaryResults.plcResult1Address;
            plcSecondaryResult2AddressTextBox.Text = plcSettings.plcSecondaryResults.plcResult2Address;
            plcSecondaryResult3AddressTextBox.Text = plcSettings.plcSecondaryResults.plcResult3Address;

            plcAutoManualEnableCheckbox.Checked = plcSettings.manualAutoButtonsEnabled;
            plcAutoBtnReadAddressTextbox.Text = plcSettings.autoButton.readAddress;
            plcAutoBtnWriteAddressTextbox.Text = plcSettings.autoButton.writeAddress;
            plcManualBtnReadAddressTextbox.Text = plcSettings.manualButton.readAddress;
            plcManualBtnWriteAddressTextbox.Text = plcSettings.manualButton.writeAddress;

            plcUserBtn1EnableCheckbox.Checked = plcSettings.plcButton1.enabled;
            plcUserBtn1WriteAddressTextbox.Text = plcSettings.plcButton1.writeAddress;
            plcUserBtn1ReadAddressTextbox.Text = plcSettings.plcButton1.readAddress;
            plcUserBtn1OffLabelTextbox.Text = plcSettings.plcButton1.offLabel;
            plcUserBtn1OnLabelTextbox.Text = plcSettings.plcButton1.onLabel;

            plcUserBtn2EnableCheckbox.Checked = plcSettings.plcButton2.enabled;
            plcUserBtn2WriteAddressTextbox.Text = plcSettings.plcButton2.writeAddress;
            plcUserBtn2ReadAddressTextbox.Text = plcSettings.plcButton2.readAddress;
            plcUserBtn2OffLabelTextbox.Text = plcSettings.plcButton2.offLabel;
            plcUserBtn2OnLabelTextbox.Text = plcSettings.plcButton2.onLabel;

            plcUserBtn3EnableCheckbox.Checked = plcSettings.plcButton3.enabled;
            plcUserBtn3WriteAddressTextbox.Text = plcSettings.plcButton3.writeAddress;
            plcUserBtn3ReadAddressTextbox.Text = plcSettings.plcButton3.readAddress;
            plcUserBtn3OffLabelTextbox.Text = plcSettings.plcButton3.offLabel;
            plcUserBtn3OnLabelTextbox.Text = plcSettings.plcButton3.onLabel;

            plcUserBtn4EnableCheckbox.Checked = plcSettings.plcButton4.enabled;
            plcUserBtn4WriteAddressTextbox.Text = plcSettings.plcButton4.writeAddress;
            plcUserBtn4ReadAddressTextbox.Text = plcSettings.plcButton4.readAddress;
            plcUserBtn4OffLabelTextbox.Text = plcSettings.plcButton4.offLabel;
            plcUserBtn4OnLabelTextbox.Text = plcSettings.plcButton4.onLabel;

            plcUserBtn5EnableCheckbox.Checked = plcSettings.plcButton5.enabled;
            plcUserBtn5WriteAddressTextbox.Text = plcSettings.plcButton5.writeAddress;
            plcUserBtn5ReadAddressTextbox.Text = plcSettings.plcButton5.readAddress;
            plcUserBtn5OffLabelTextbox.Text = plcSettings.plcButton5.offLabel;
            plcUserBtn5OnLabelTextbox.Text = plcSettings.plcButton5.onLabel;

            plcUserBtn6EnableCheckbox.Checked = plcSettings.plcButton6.enabled;
            plcUserBtn6WriteAddressTextbox.Text = plcSettings.plcButton6.writeAddress;
            plcUserBtn6ReadAddressTextbox.Text = plcSettings.plcButton6.readAddress;
            plcUserBtn6OffLabelTextbox.Text = plcSettings.plcButton6.offLabel;
            plcUserBtn6OnLabelTextbox.Text = plcSettings.plcButton6.onLabel;

            updateCheckboxes();


        }

        private void setIPAddressTextBoxes(string incomingIPAddress)
        {
            string ipAddress = incomingIPAddress;

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

            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void plcSetupOKButton_Click(object sender, EventArgs e)
        {

            storeSetupValues();
            this.Close();
        }

        private void plcSetupCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void plcSetupResetButton_Click(object sender, EventArgs e)
        {
            plcSettings = new PLCSetup();
            updateDisplay();
        }


        private void storeSetupValues()
        {
            if (textBox4.Text.Length > 0 && textBox3.Text.Length > 0 && textBox2.Text.Length > 0 && textBox1.Text.Length > 0)
            {
                plcSettings.ipAddress = textBox1.Text + "." + textBox2.Text + "." + textBox3.Text + "." + textBox4.Text;

            }
            else
            {
                MessageBox.Show("IP Address format is invalid.");
                return;
            }


            plcSettings.communicationEnabled = plcEnableCheckbox.Checked;

            if (plcSettings.communicationEnabled && string.IsNullOrEmpty(plcSettings.ipAddress))
            {
                MessageBox.Show("IP Address is required for PLC Communication");
                return;
            }


            plcSettings.displayMessageAddress = plcMessageDisplayAddressTextbox.Text;
            plcSettings.displayMessageColorAddress = plcMessageDisplayColorAddressTextbox.Text;
            plcSettings.mainSerialNumberAddress = mainSerialNumberPLCAddressTextbox.Text;
            plcSettings.secondaryDisplayMessageAddress = plcSecondaryMessageDisplayAddressTextbox.Text;
            plcSettings.secondaryDisplayMessageColorAddress = plcSecondaryMessageDisplayColorAddressTextbox.Text;
            plcSettings.secondarySerialNumberAddress = secondarySerialNumberPLCAddressTextBox.Text;
            plcSettings.displayMessageTitle = mainMessageTitleTextBox.Text;
            plcSettings.secondaryMessageTitle = secondaryMessageTitleTextBox.Text;

            plcSettings.manualButton.writeAddress = plcManualBtnWriteAddressTextbox.Text;
            plcSettings.manualButton.readAddress = plcManualBtnReadAddressTextbox.Text;
            plcSettings.manualButton.onLabel = "Manual Mode Active";
            plcSettings.manualButton.offLabel = "Press For Manual";
            plcSettings.autoButton.writeAddress = plcAutoBtnWriteAddressTextbox.Text;
            plcSettings.autoButton.readAddress = plcAutoBtnReadAddressTextbox.Text;
            plcSettings.autoButton.onLabel = "Auto Mode Active";
            plcSettings.autoButton.offLabel = "Press For Auto Mode";

            plcSettings.plcResult.plcResult1Address = plcResult1AddressTextBox.Text;
            plcSettings.plcResult.plcResult1Title = plcSecondaryResult3AddressTextBox.Text;
            plcSettings.plcResult.plcResult2Address = plcResult2AddressTextBox.Text;
            plcSettings.plcResult.plcResult2Title = plcSecondaryResult1AddressTextBox.Text;
            plcSettings.plcResult.plcResult3Address = plcResult3AddressTextBox.Text;
            plcSettings.plcResult.plcResult3Title = plcSecondaryResult2AddressTextBox.Text;

            plcSettings.plcPartcounter.goodCountPLCAddress = plcGoodCountAddressTextbox.Text;
            plcSettings.plcPartcounter.rejectCountPLCAddress = plcBadCountAddressTextbox.Text;
            plcSettings.plcPartcounter.resetButton.writeAddress = plcCounterResetButtonAddressTextBox.Text;
            plcSettings.plcPartcounter.resetButton.offLabel = "Reset";
            plcSettings.plcPartcounter.resetButton.onLabel = "Reset";

            plcSettings.plcSecPartCounter.goodCountPLCAddress = plcSecondaryGoodCountAddressTextbox.Text;
            plcSettings.plcSecPartCounter.rejectCountPLCAddress = plcSecondaryBadCountAddressTextbox.Text;
            plcSettings.plcSecPartCounter.resetButton.writeAddress = plcSecondaryCounterResetButtonAddressTextBox.Text;
            plcSettings.plcSecPartCounter.resetButton.offLabel = "Reset";
            plcSettings.plcSecPartCounter.resetButton.onLabel = "Reset";

            plcSettings.plcButton1.writeAddress = plcUserBtn1WriteAddressTextbox.Text;
            plcSettings.plcButton1.readAddress = plcUserBtn1ReadAddressTextbox.Text;
            plcSettings.plcButton1.onLabel = plcUserBtn1OnLabelTextbox.Text;
            plcSettings.plcButton1.offLabel = plcUserBtn1OffLabelTextbox.Text;

            plcSettings.plcButton2.writeAddress = plcUserBtn2WriteAddressTextbox.Text;
            plcSettings.plcButton2.readAddress = plcUserBtn2ReadAddressTextbox.Text;
            plcSettings.plcButton2.onLabel = plcUserBtn2OnLabelTextbox.Text;
            plcSettings.plcButton2.offLabel = plcUserBtn2OffLabelTextbox.Text;

            plcSettings.plcButton3.writeAddress = plcUserBtn3WriteAddressTextbox.Text;
            plcSettings.plcButton3.readAddress = plcUserBtn3ReadAddressTextbox.Text;
            plcSettings.plcButton3.onLabel = plcUserBtn3OnLabelTextbox.Text;
            plcSettings.plcButton3.offLabel = plcUserBtn3OffLabelTextbox.Text;

            plcSettings.plcButton4.writeAddress = plcUserBtn4WriteAddressTextbox.Text;
            plcSettings.plcButton4.readAddress = plcUserBtn4ReadAddressTextbox.Text;
            plcSettings.plcButton4.onLabel = plcUserBtn4OnLabelTextbox.Text;
            plcSettings.plcButton4.offLabel = plcUserBtn4OffLabelTextbox.Text;

            plcSettings.plcButton5.writeAddress = plcUserBtn5WriteAddressTextbox.Text;
            plcSettings.plcButton5.readAddress = plcUserBtn5ReadAddressTextbox.Text;
            plcSettings.plcButton5.onLabel = plcUserBtn5OnLabelTextbox.Text;
            plcSettings.plcButton5.offLabel = plcUserBtn5OffLabelTextbox.Text;

            plcSettings.plcButton6.writeAddress = plcUserBtn6WriteAddressTextbox.Text;
            plcSettings.plcButton6.readAddress = plcUserBtn6ReadAddressTextbox.Text;
            plcSettings.plcButton6.onLabel = plcUserBtn6OnLabelTextbox.Text;
            plcSettings.plcButton6.offLabel = plcUserBtn6OffLabelTextbox.Text;

        }


        #region Checkbox Changed Monitor

        private void plcEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.communicationEnabled = plcEnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcAutoManualEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.manualAutoButtonsEnabled = plcAutoManualEnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcSecondaryMessageEnableCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.secondaryMessageEnabled = plcSecondaryMessageEnableCheckBox1.Checked;
            updateCheckboxes();
        }

        private void plcPartCountEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.countersEnabled = plcPartCountEnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcSecondaryPartCountEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.secondaryCountersEnabled = plcSecondaryPartCountEnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcResultMonitorEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.resultsEnabled = plcResultMonitorEnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.secondaryResultsEnabled = checkBox1.Checked;
            updateCheckboxes();
        }

        private void plcUserBtn1EnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.plcButton1.enabled = plcUserBtn1EnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcUserBtn2EnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.plcButton2.enabled = plcUserBtn2EnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcUserBtn3EnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.plcButton3.enabled = plcUserBtn3EnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcUserBtn4EnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.plcButton4.enabled = plcUserBtn4EnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcUserBtn5EnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.plcButton5.enabled = plcUserBtn5EnableCheckbox.Checked;
            updateCheckboxes();
        }

        private void plcUserBtn6EnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            plcSettings.plcButton6.enabled = plcUserBtn6EnableCheckbox.Checked;
            updateCheckboxes();
        }


        #endregion

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadSettingsFromFile();
        }

        private void saveSettingsToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettingsToFile();
        }

        private void saveSettingsToFile()
        {
            SaveFileDialog myDialog = new SaveFileDialog();

            myDialog.Filter = "Final Inspection Config (.fic)|*.fic";
            myDialog.FilterIndex = 1;
            DialogResult result = myDialog.ShowDialog();



            string filePath = myDialog.FileName;
            StringBuilder mySB = new StringBuilder();
            string delimiter = ",";


            foreach (Control c in this.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox" || c.GetType().ToString() == "System.Windows.Forms.CheckBox")
                {
                    if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        string[][] thisOutputString = new string[][] { new string[] { c.Name.ToString(), c.Text } };


                        for (int x = 0; x < thisOutputString.Length; x++)
                        {
                            mySB.AppendLine(string.Join(delimiter, thisOutputString[x]));

                        }
                    }
                    else
                    {
                        string[][] thisOutputString = new string[][] { new string[] { c.Name.ToString(), ((CheckBox)c).Checked.ToString() } };


                        for (int x = 0; x < thisOutputString.Length; x++)
                        {
                            mySB.AppendLine(string.Join(delimiter, thisOutputString[x]));

                        }
                    }

                }
            }

            File.WriteAllText(filePath, mySB.ToString());
        }

        private void loadSettingsFromFile()
        {
            OpenFileDialog myDialog = new OpenFileDialog();

            myDialog.Filter = "Final Inspection Config (.fic)|*.fic";
            myDialog.FilterIndex = 1;
            myDialog.Multiselect = true;
            DialogResult result = myDialog.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                string file = myDialog.FileName;
                string[] allLines = File.ReadAllLines(file);

                char[] splitchar = { ',' };



                for (int i = 0; i < allLines.Count(); i++)
                {
                    string[] thisData = allLines[i].Split(splitchar);
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().ToString() == "System.Windows.Forms.TextBox" || c.GetType().ToString() == "System.Windows.Forms.CheckBox")
                        {
                            if (c.GetType().ToString() == "System.Windows.Forms.TextBox")
                            {
                                if (c.Name == thisData[0])
                                {
                                    ((TextBox)c).Text = thisData[1].ToString();
                                    //c.Text = thisData[1];
                                }
                            }
                            else
                            {
                                if (c.Name == thisData[0])
                                {
                                    if (thisData[1] == "False")
                                    {
                                        ((CheckBox)c).Checked = false;
                                    }
                                    else if (thisData[1] == "True")
                                    {
                                        ((CheckBox)c).Checked = true;
                                    }


                                }
                            }

                        }
                    }
                }
                storeSetupValues();
                updateDisplay();

            }
        }

        

        




    }
}
