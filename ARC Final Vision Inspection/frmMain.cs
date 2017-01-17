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
using Cognex.InSight;
using Cognex.InSight.Cell;

namespace ARC_Final_Vision_Inspection
{
    public partial class frmMain : Form
    {

        #region Type Definitions

        public enum DisplayType
        {
            Single = 1,
            Dual = 2,
        }

        public enum ConnectStatus
        {
            Disconnected,
            Connecting,
            Connected,
            Disconnecting
        }

        #endregion

        #region Variable Declarations

        int tempPictureCounter = 0;

        const float arHeight = 480;
        const float arWidth = 640;

        public static bool isLocked = true;
        public static bool skipPassword = false;

        public string cameraIPAddress;

        private Cognex.InSight.CvsInSight insight;
        Controller myPLC = new Logix.Controller();
        TagGroup MyGroup = new Logix.TagGroup();

        PLCManualControlsForm plcManualControlsForm = new PLCManualControlsForm();
        public PLCSetup plcSettings = new PLCSetup();

        private DisplayType displayType;

        #endregion


        public frmMain()
        {

            Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();

            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            getPLCSettingsFromPropertiesDefault();

            bindInsightControls();
            if (setUpCameraConnections() > 0)
            {
                MessageBox.Show("No IP Address For Camera");
            }

            pictureBox1.Hide();
            pictureBox2.Hide();

            //updateMainGroupBoxDisplay();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            cvsInSightDisplay1.Disconnect();

            
            //myPLC.Disconnect();

            if (plcManualControlsForm != null)
            {
                plcManualControlsForm.Dispose();
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void bindInsightControls()
        {
            cvsInSightDisplay1.Edit.SoftOnline.Bind(onlineToolStripMenuItem, null, "Click");
            cvsInSightDisplay1.Edit.LiveAcquire.Bind(liveModeToolStripMenuItem, null, "Click");
            cvsInSightDisplay1.Edit.ManualAcquire.Bind(manualControlsToolStripMenuItem, null, "Click");
            cvsInSightDisplay1.Edit.OpenJob.Bind(openJobToolStripMenuItem, null, "Click");
            cvsInSightDisplay1.Edit.SaveJob.Bind(saveJobToolStripMenuItem, null, "Click");
            cvsInSightDisplay1.Edit.SaveJobAs.Bind(saveJobAsToolStripMenuItem, null, "Click");
            cvsInSightDisplay1.Edit.ShowGrid.Bind(showSpreadsheetToolStripMenuItem, null, "Click");
            cvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;
        }

        private int setUpCameraConnections()
        {
            if (string.IsNullOrEmpty(cameraIPAddress))
            {
                return 1;
            }

            if (cvsInSightDisplay1 != null)
            {
                if (!cvsInSightDisplay1.Connected)
                {

                    cvsInSightDisplay1.AutoConnectString = cameraIPAddress + ",admin";
                    cvsInSightDisplay1.AutoReconnect = true; 
                } 
            }


            

            return 0;
        }

        private void getPLCSettingsFromPropertiesDefault()
        {
            plcSettings.manualAutoButtonsEnabled = Properties.Settings.Default.autoButtonEnabled;
            plcSettings.autoButton.readAddress = Properties.Settings.Default.autoButtonReadAddress;
            plcSettings.autoButton.writeAddress = Properties.Settings.Default.autoButtonWriteAddress;
            plcSettings.autoButton.visible = Properties.Settings.Default.autoButtonVisible;
            plcSettings.manualButton.readAddress = Properties.Settings.Default.manualButtonReadAddress;
            plcSettings.manualButton.writeAddress = Properties.Settings.Default.manualButtonWriteAddress;
            plcSettings.communicationEnabled = Properties.Settings.Default.plcCommsEnabled;
            plcSettings.ipAddress = Properties.Settings.Default.plcIPAddress;
            plcSettings.plcButton1.enabled = Properties.Settings.Default.plcButton1Enabled;
            plcSettings.plcButton1.visible = Properties.Settings.Default.plcButton1Visible;
            plcSettings.plcButton1.writeAddress = Properties.Settings.Default.plcButton1WriteAddress;
            plcSettings.plcButton1.readAddress = Properties.Settings.Default.plcButton1ReadAddress;
            plcSettings.plcButton1.onLabel = Properties.Settings.Default.plcButton1OnLabel;
            plcSettings.plcButton1.offLabel = Properties.Settings.Default.plcButton1OffLabel;

            plcSettings.plcButton2.enabled = Properties.Settings.Default.plcButton2Enabled;
            plcSettings.plcButton2.visible = Properties.Settings.Default.plcButton2Visible;
            plcSettings.plcButton2.writeAddress = Properties.Settings.Default.plcButton2WriteAddress;
            plcSettings.plcButton2.readAddress = Properties.Settings.Default.plcButton2ReadAddress;
            plcSettings.plcButton2.onLabel = Properties.Settings.Default.plcButton2OnLabel;
            plcSettings.plcButton2.offLabel = Properties.Settings.Default.plcButton2OffLabel;

            plcSettings.plcButton3.enabled = Properties.Settings.Default.plcButton3Enabled;
            plcSettings.plcButton3.visible = Properties.Settings.Default.plcButton3Visible;
            plcSettings.plcButton3.writeAddress = Properties.Settings.Default.plcButton3WriteAddress;
            plcSettings.plcButton3.readAddress = Properties.Settings.Default.plcButton3ReadAddress;
            plcSettings.plcButton3.onLabel = Properties.Settings.Default.plcButton3OnLabel;
            plcSettings.plcButton3.offLabel = Properties.Settings.Default.plcButton3OffLabel;

            plcSettings.plcButton4.enabled = Properties.Settings.Default.plcButton4Enabled;
            plcSettings.plcButton4.visible = Properties.Settings.Default.plcButton4Visible;
            plcSettings.plcButton4.writeAddress = Properties.Settings.Default.plcButton4WriteAddress;
            plcSettings.plcButton4.readAddress = Properties.Settings.Default.plcButton4ReadAddress;
            plcSettings.plcButton4.onLabel = Properties.Settings.Default.plcButton4OnLabel;
            plcSettings.plcButton4.offLabel = Properties.Settings.Default.plcButton4OffLabel;

            plcSettings.plcButton5.enabled = Properties.Settings.Default.plcButton5Enabled;
            plcSettings.plcButton5.visible = Properties.Settings.Default.plcButton5Visible;
            plcSettings.plcButton5.writeAddress = Properties.Settings.Default.plcButton5WriteAddress;
            plcSettings.plcButton5.readAddress = Properties.Settings.Default.plcButton5ReadAddress;
            plcSettings.plcButton5.onLabel = Properties.Settings.Default.plcButton5OnLabel;
            plcSettings.plcButton5.offLabel = Properties.Settings.Default.plcButton5OffLabel;

            plcSettings.plcButton6.enabled = Properties.Settings.Default.plcButton6Enabled;
            plcSettings.plcButton6.visible = Properties.Settings.Default.plcButton6Visible;
            plcSettings.plcButton6.writeAddress = Properties.Settings.Default.plcButton6WriteAddress;
            plcSettings.plcButton6.readAddress = Properties.Settings.Default.plcButton6ReadAddress;
            plcSettings.plcButton6.onLabel = Properties.Settings.Default.plcButton6OnLabel;
            plcSettings.plcButton6.offLabel = Properties.Settings.Default.plcButton6OffLabel;

            plcSettings.plcButton1.enabled = Properties.Settings.Default.plcButton1Enabled;
            plcSettings.plcButton1.visible = Properties.Settings.Default.plcButton1Visible;
            plcSettings.plcButton1.writeAddress = Properties.Settings.Default.plcButton1WriteAddress;
            plcSettings.plcButton1.readAddress = Properties.Settings.Default.plcButton1ReadAddress;
            plcSettings.plcButton1.onLabel = Properties.Settings.Default.plcButton1OnLabel;
            plcSettings.plcButton1.offLabel = Properties.Settings.Default.plcButton1OffLabel;

            plcSettings.displayMessageColorAddress = Properties.Settings.Default.plcMessageDisplayColorIndicatorAddress;
            plcSettings.displayMessageAddress = Properties.Settings.Default.plcMessageDisplayAddress;
            plcSettings.mainSerialNumberAddress = Properties.Settings.Default.plcMainSerialNumberAddress;
            plcSettings.secondaryDisplayMessageAddress = Properties.Settings.Default.plcSecondaryMessageAddress;
            plcSettings.secondaryDisplayMessageColorAddress = Properties.Settings.Default.plcSecondaryMessageColorAddress;
            plcSettings.secondarySerialNumberAddress = Properties.Settings.Default.plcSecondarySerialNumberAddress;
            plcSettings.secondaryMessageEnabled = Properties.Settings.Default.plcSecondaryDisplayMessageEnabled;
            plcSettings.displayMessageTitle = Properties.Settings.Default.mainMessageTitle;
            plcSettings.secondaryMessageTitle = Properties.Settings.Default.secondaryMessageTitle;

            plcSettings.resultsEnabled = Properties.Settings.Default.plcResultMonitorEnabled;
            plcSettings.plcResult.plcResult1Address = Properties.Settings.Default.plcResult1Address;
            plcSettings.plcResult.plcResult2Address = Properties.Settings.Default.plcResult2Address;
            plcSettings.plcResult.plcResult3Address = Properties.Settings.Default.plcResult3Address;

            plcSettings.secondaryResultsEnabled = Properties.Settings.Default.plcSecondaryResultEnabled;
            plcSettings.plcSecondaryResults.plcResult1Address = Properties.Settings.Default.plcSecondaryResult1Address;
            plcSettings.plcSecondaryResults.plcResult2Address = Properties.Settings.Default.plcSecondaryResult2Address;
            plcSettings.plcSecondaryResults.plcResult3Address = Properties.Settings.Default.plcSecondaryResult3Address;

            plcSettings.countersEnabled = Properties.Settings.Default.plcPartCountersEnabled;
            plcSettings.plcPartcounter.goodCountPLCAddress = Properties.Settings.Default.plcPartCounterGoodAddress;
            plcSettings.plcPartcounter.rejectCountPLCAddress = Properties.Settings.Default.plcPartCounterBadAddress;
            plcSettings.plcPartcounter.resetButton.writeAddress = Properties.Settings.Default.plcMainPartCounterResetButtonAddress;

            plcSettings.secondaryCountersEnabled = Properties.Settings.Default.plcSecondaryPartCounterEnabled;
            plcSettings.plcSecPartCounter.goodCountPLCAddress = Properties.Settings.Default.plcSecondaryPartCounterGoodAddress;
            plcSettings.plcSecPartCounter.rejectCountPLCAddress = Properties.Settings.Default.plcSecondaryPartCounterBadAddress;
            plcSettings.plcSecPartCounter.resetButton.writeAddress = Properties.Settings.Default.plcSecondaryPartCounterResetButtonAddress;

            cameraIPAddress = Properties.Settings.Default.cameraIPAddress;
        }

        private int setPLCSettingsIntoPropertiesDefault()
        {
            try
            {
                Properties.Settings.Default.autoButtonEnabled = plcSettings.manualAutoButtonsEnabled;
                Properties.Settings.Default.autoButtonReadAddress = plcSettings.autoButton.readAddress;
                Properties.Settings.Default.autoButtonWriteAddress = plcSettings.autoButton.writeAddress;
                Properties.Settings.Default.autoButtonVisible = plcSettings.autoButton.visible;
                Properties.Settings.Default.manualButtonReadAddress = plcSettings.manualButton.readAddress;
                Properties.Settings.Default.manualButtonWriteAddress = plcSettings.manualButton.writeAddress;
                Properties.Settings.Default.plcCommsEnabled = plcSettings.communicationEnabled;
                Properties.Settings.Default.plcIPAddress = plcSettings.ipAddress;
                Properties.Settings.Default.plcButton1Enabled = plcSettings.plcButton1.enabled;
                Properties.Settings.Default.plcButton1Visible = plcSettings.plcButton1.visible;
                Properties.Settings.Default.plcButton1WriteAddress = plcSettings.plcButton1.writeAddress;
                Properties.Settings.Default.plcButton1ReadAddress = plcSettings.plcButton1.readAddress;
                Properties.Settings.Default.plcButton1OnLabel = plcSettings.plcButton1.onLabel;
                Properties.Settings.Default.plcButton1OffLabel = plcSettings.plcButton1.offLabel;

                Properties.Settings.Default.plcButton2Enabled = plcSettings.plcButton2.enabled;
                Properties.Settings.Default.plcButton2Visible = plcSettings.plcButton2.visible;
                Properties.Settings.Default.plcButton2WriteAddress = plcSettings.plcButton2.writeAddress;
                Properties.Settings.Default.plcButton2ReadAddress = plcSettings.plcButton2.readAddress;
                Properties.Settings.Default.plcButton2OnLabel = plcSettings.plcButton2.onLabel;
                Properties.Settings.Default.plcButton2OffLabel = plcSettings.plcButton2.offLabel;

                Properties.Settings.Default.plcButton3Enabled = plcSettings.plcButton3.enabled;
                Properties.Settings.Default.plcButton3Visible = plcSettings.plcButton3.visible;
                Properties.Settings.Default.plcButton3WriteAddress = plcSettings.plcButton3.writeAddress;
                Properties.Settings.Default.plcButton3ReadAddress = plcSettings.plcButton3.readAddress;
                Properties.Settings.Default.plcButton3OnLabel = plcSettings.plcButton3.onLabel;
                Properties.Settings.Default.plcButton3OffLabel = plcSettings.plcButton3.offLabel;

                Properties.Settings.Default.plcButton4Enabled = plcSettings.plcButton4.enabled;
                Properties.Settings.Default.plcButton4Visible = plcSettings.plcButton4.visible;
                Properties.Settings.Default.plcButton4WriteAddress = plcSettings.plcButton4.writeAddress;
                Properties.Settings.Default.plcButton4ReadAddress = plcSettings.plcButton4.readAddress;
                Properties.Settings.Default.plcButton4OnLabel = plcSettings.plcButton4.onLabel;
                Properties.Settings.Default.plcButton4OffLabel = plcSettings.plcButton4.offLabel;

                Properties.Settings.Default.plcButton5Enabled = plcSettings.plcButton5.enabled;
                Properties.Settings.Default.plcButton5Visible = plcSettings.plcButton5.visible;
                Properties.Settings.Default.plcButton5WriteAddress = plcSettings.plcButton5.writeAddress;
                Properties.Settings.Default.plcButton5ReadAddress = plcSettings.plcButton5.readAddress;
                Properties.Settings.Default.plcButton5OnLabel = plcSettings.plcButton5.onLabel;
                Properties.Settings.Default.plcButton5OffLabel = plcSettings.plcButton5.offLabel;

                Properties.Settings.Default.plcButton6Enabled = plcSettings.plcButton6.enabled;
                Properties.Settings.Default.plcButton6Visible = plcSettings.plcButton6.visible;
                Properties.Settings.Default.plcButton6WriteAddress = plcSettings.plcButton6.writeAddress;
                Properties.Settings.Default.plcButton6ReadAddress = plcSettings.plcButton6.readAddress;
                Properties.Settings.Default.plcButton6OnLabel = plcSettings.plcButton6.onLabel;
                Properties.Settings.Default.plcButton6OffLabel = plcSettings.plcButton6.offLabel;

                Properties.Settings.Default.plcMessageDisplayColorIndicatorAddress = plcSettings.displayMessageColorAddress;
                Properties.Settings.Default.plcMessageDisplayAddress = plcSettings.displayMessageAddress;
                Properties.Settings.Default.plcMainSerialNumberAddress = plcSettings.mainSerialNumberAddress;
                Properties.Settings.Default.plcSecondaryMessageAddress = plcSettings.secondaryDisplayMessageAddress;
                Properties.Settings.Default.plcSecondaryMessageColorAddress = plcSettings.secondaryDisplayMessageColorAddress;
                Properties.Settings.Default.plcSecondarySerialNumberAddress = plcSettings.secondarySerialNumberAddress;
                Properties.Settings.Default.plcSecondaryDisplayMessageEnabled = plcSettings.secondaryMessageEnabled;
                Properties.Settings.Default.mainMessageTitle = plcSettings.displayMessageTitle;
                Properties.Settings.Default.secondaryMessageTitle = plcSettings.secondaryMessageTitle;

                Properties.Settings.Default.plcResultMonitorEnabled = plcSettings.resultsEnabled;
                Properties.Settings.Default.plcResult1Address = plcSettings.plcResult.plcResult1Address;
                Properties.Settings.Default.plcResult2Address = plcSettings.plcResult.plcResult2Address;
                Properties.Settings.Default.plcResult3Address = plcSettings.plcResult.plcResult3Address;

                Properties.Settings.Default.plcSecondaryResultEnabled = plcSettings.secondaryResultsEnabled;
                Properties.Settings.Default.plcSecondaryResult1Address = plcSettings.plcSecondaryResults.plcResult1Address;
                Properties.Settings.Default.plcSecondaryResult2Address = plcSettings.plcSecondaryResults.plcResult2Address;
                Properties.Settings.Default.plcSecondaryResult3Address = plcSettings.plcSecondaryResults.plcResult3Address;

                Properties.Settings.Default.plcPartCountersEnabled = plcSettings.countersEnabled;
                Properties.Settings.Default.plcPartCounterGoodAddress = plcSettings.plcPartcounter.goodCountPLCAddress;
                Properties.Settings.Default.plcPartCounterBadAddress = plcSettings.plcPartcounter.rejectCountPLCAddress;
                Properties.Settings.Default.plcMainPartCounterResetButtonAddress = plcSettings.plcPartcounter.resetButton.writeAddress;

                Properties.Settings.Default.plcSecondaryPartCounterEnabled = plcSettings.secondaryCountersEnabled;
                Properties.Settings.Default.plcSecondaryPartCounterGoodAddress = plcSettings.plcSecPartCounter.goodCountPLCAddress;
                Properties.Settings.Default.plcSecondaryPartCounterBadAddress = plcSettings.plcSecPartCounter.rejectCountPLCAddress;
                Properties.Settings.Default.plcSecondaryPartCounterResetButtonAddress = plcSettings.plcSecPartCounter.resetButton.writeAddress;

                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {

                return 1;
            }

            return 0;
        }

        private void updateDisplay()
        {
            updatePlcDisplayItems();

            updatePlcDisplayValues();

            updateConnectionStatusLabels();

            updateMainGroupBoxSize();

            updateMenuItems();

            updateInsightDisplaySize();

            manualControlsToolStripMenuItem.Enabled = myPLC.IsConnected;

            if (plcManualControlsForm.Visible)
            {
                plcManualControlsForm.updateDisplay(); 
            }



        }

        private void updateConnectionStatusLabels()
        {
            if (cvsInSightDisplay1.Connected)
            {
                labelCameraStatus.Text = (cvsInSightDisplay1.SoftOnline) ? "Online" : "Offline";
                labelCameraStatus.BackColor = (cvsInSightDisplay1.SoftOnline) ? Color.LightGreen : Color.Yellow;
            }
            else
            {
                labelCameraStatus.Text = "Not Connected";
                labelCameraStatus.BackColor = Control.DefaultBackColor;
            }

            if (plcSettings.communicationEnabled)
            {
                labelPlcStatus.Text = (myPLC.IsConnected) ? "Connected" : "Not Connected";
            }
            else
            {
                labelPlcStatus.Text = "Not Enabled";
            }
            
        }

        private void updateMainGroupBoxSize()
        {
            if ((mainResultsGroupBox.Visible || secondaryResultsGroupBox.Visible) && (mainPartCountGroupBox.Visible || secondaryPartCountGroupBox.Visible))
            {
                groupBoxMainDisplay.Height = 216;
            }
            else if (!mainResultsGroupBox.Visible && !secondaryResultsGroupBox.Visible && !mainPartCountGroupBox.Visible && !secondaryPartCountGroupBox.Visible)
            {
                groupBoxMainDisplay.Height = 130;
            }
            else if ((mainResultsGroupBox.Visible || secondaryResultsGroupBox.Visible) && (!mainPartCountGroupBox.Visible && !secondaryPartCountGroupBox.Visible))
            {
                groupBoxMainDisplay.Height = 179;
            }
            else if (!mainResultsGroupBox.Visible && !secondaryResultsGroupBox.Visible && (mainPartCountGroupBox.Visible || secondaryPartCountGroupBox.Visible))
            {
                groupBoxMainDisplay.Height = 167;
            }

            int tempBottom = labelCameraStatus.Top - 10;
            int tempHeight = tempBottom - groupBoxMainDisplay.Bottom;


            groupBoxImageDisplay.SetBounds(groupBoxImageDisplay.Location.X, groupBoxMainDisplay.Bottom, groupBoxImageDisplay.Width, tempHeight);
        }

        private void updateMenuItems()
        {

            countersToolStripMenuItem.Enabled = plcSettings.countersEnabled && myPLC.IsConnected ? true : false;
            clearStation1CountersToolStripMenuItem.Enabled = (string.IsNullOrEmpty(plcSettings.plcPartcounter.resetButton.writeAddress)) ? false : true;
            clearStation2CountersToolStripMenuItem.Enabled = (string.IsNullOrEmpty(plcSettings.plcSecPartCounter.resetButton.writeAddress)) ? false : true;
            clearAllCountersToolStripMenuItem.Enabled = ((string.IsNullOrEmpty(plcSettings.plcPartcounter.resetButton.writeAddress)) & (string.IsNullOrEmpty(plcSettings.plcSecPartCounter.resetButton.writeAddress))) ? false : true;



            onlineToolStripMenuItem.Enabled = cvsInSightDisplay1.Connected;
            manualTriggerToolStripMenuItem.Enabled = cvsInSightDisplay1.Connected;
            liveModeToolStripMenuItem.Enabled = cvsInSightDisplay1.Connected;

            onlineToolStripMenuItem.Checked = cvsInSightDisplay1.SoftOnline;
            showSpreadsheetToolStripMenuItem.Checked = cvsInSightDisplay1.ShowGrid;
            showSpreadsheetToolStripMenuItem.Enabled = !isLocked;

            plcConnectToolStripMenuItem.Enabled = plcSettings.communicationEnabled;

            if (insight != null)
            {
                liveModeToolStripMenuItem.Checked = insight.LiveAcquisition;
            }
        }

        private void updateInsightDisplaySize()
        {
            if (cvsInSightDisplay1.SoftOnline)
            {
                cvsInSightDisplay1.ShowGrid = false;
                isLocked = true;
            }

            if (cvsInSightDisplay1.ShowGrid)
            {
                cvsInSightDisplay1.Show();
                pictureBox1.Hide();
                pictureBox2.Hide();
                cvsInSightDisplay1.SetBounds(0, 0, groupBoxImageDisplay.Width, groupBoxImageDisplay.Height);
            }
            else
            {
                float aspectRation = arWidth / arHeight;
                float floatHeight = groupBoxImageDisplay.Height;
                float floatWidth = groupBoxImageDisplay.Width;
                cvsInSightDisplay1.Height = groupBoxImageDisplay.Height;
                cvsInSightDisplay1.Width = (int)(floatHeight * aspectRation);
                cvsInSightDisplay1.Show();
                cvsInSightDisplay1.SetBounds((groupBoxImageDisplay.Width / 2) - (cvsInSightDisplay1.Width / 2), 0, cvsInSightDisplay1.Width, cvsInSightDisplay1.Height);
            }

            if (cvsInSightDisplay1.Connected && !cvsInSightDisplay1.SoftOnline)
            {
                pictureBox1.Hide();
                pictureBox2.Hide();
                cvsInSightDisplay1.Show();
            }
            else
            {
                cvsInSightDisplay1.Hide();
            }

            if (pictureBox1.Visible)
            {
                pictureBox1UpdateSize();
            }

            if (pictureBox2.Visible)
            {
                pictureBox2UpdateSize();
            }
        }



        #region Image Control

        private void pictureBox1UpdateImage()
        {
            pictureBox1.Show();
            pictureBox2.Hide();

            int[] settings = getPictureHeight(groupBoxImageDisplay.Height, (groupBoxImageDisplay.Width / 2), (int)arHeight, (int)arWidth);
            int myHeight = settings[0];
            int myWidth = settings[1];

            //int myHeight = groupBoxImageDisplay.Height;
            //int myWidth = groupBoxImageDisplay.Width / 2;
            
            int myY = 0;

            if (myHeight < groupBoxImageDisplay.Height)
            {
                int temp = (groupBoxImageDisplay.Height - myHeight) / 2;
                myY = temp;
            }

            if (displayType == DisplayType.Dual)
            {
                pictureBox1.SetBounds(0, myY, myWidth, myHeight);
            }
            else if (displayType == DisplayType.Single)
            {
                pictureBox1.SetBounds(myWidth - (pictureBox1.Width / 2), myY, myWidth, myHeight);
            }

            
            try
            {
                Image myImage = cvsInSightDisplay1.GetBitmap();
                if (myImage != null)
                {
                    Image newIMG = myImage.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
                    pictureBox1.Image = newIMG;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //throw;
            }

        }

        private void pictureBox1UpdateSize()
        {

            int[] settings = getPictureHeight(groupBoxImageDisplay.Height, (groupBoxImageDisplay.Width / 2), (int)arHeight, (int)arWidth);

            //int myHeight = groupBoxImageDisplay.Height;
            //int myWidth = groupBoxImageDisplay.Width / 2;


            //double tempHeight = myWidth * asepectRation;
            int myHeight = settings[0];
            int myWidth = settings[1];
            int myY = 0;
            
            if (myHeight < groupBoxImageDisplay.Height)
            {
                int temp = (groupBoxImageDisplay.Height - myHeight) /2;
                myY = temp;
            }

            if (displayType == DisplayType.Dual)
            {
                pictureBox1.SetBounds(0, myY, myWidth, myHeight);
            }
            else if (displayType == DisplayType.Single)
            {
                pictureBox1.SetBounds(myWidth - (pictureBox1.Width / 2), myY, myWidth, myHeight);
            }

            try
            {
                Image myImage = pictureBox1.Image;
                if (myImage != null)
                {
                    Image newIMG = myImage.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
                    pictureBox1.Image = newIMG;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //throw;
            }
        }

        private void pictureBox2UpdateImage()
        {
            
            pictureBox2.Visible = pictureBox1.Visible;
            

            int myHeight = pictureBox1.Size.Height;
            int myWidth = pictureBox1.Size.Width;

            
            int myX = groupBoxImageDisplay.Width / 2;
            pictureBox2.SetBounds(myX, pictureBox1.Location.Y, myWidth, myHeight);

            try
            {
                Image myImage = cvsInSightDisplay1.GetBitmap();
                if (myImage != null)
                {
                    Image newIMG = myImage.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
                    pictureBox2.Image = newIMG;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //throw;
            }
        }

        private void pictureBox2UpdateSize()
        {

            int myHeight = pictureBox1.Size.Height;
            int myWidth = pictureBox1.Size.Width;


            int myX = groupBoxImageDisplay.Width / 2;
            pictureBox2.SetBounds(myX, pictureBox1.Location.Y, myWidth, myHeight);

            try
            {
                Image myImage = pictureBox2.Image;
                if (myImage != null)
                {
                    Image newIMG = myImage.GetThumbnailImage(pictureBox1.Width, pictureBox1.Height, new System.Drawing.Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
                    pictureBox2.Image = newIMG;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //throw;
            }
        }

        private int[] getPictureHeight(int height, int width, int aHeight, int aWidth)
        {
            double aspectRatio = (double)aHeight / (double)aWidth;
            
            double widthHeight = (double)width * aspectRatio;

            double heightWidth = (double)height / aspectRatio;

            double deltaHeight1 = widthHeight - (double)height;

            double deltaWidth2 = heightWidth - (double)width;

            if (widthHeight <= height )
            {
                int[] settings  = new int[2];
                settings[0] = (int)widthHeight;
                settings[1] = (int)width;
                return settings;
            }

            if (heightWidth <= width)
            {
                int[] settings  = new int[2];
                settings[0] = (int)height;
                settings[1] = (int)heightWidth;
                return settings;
            }


            int[] newSettings = new int[2];
            newSettings[0] = aHeight;
            newSettings[1] = aWidth;

            return newSettings;
        }

        public bool ThumbnailCallback()
        {
            return false;
        }

        #endregion

        private void updatePlcDisplayValues()
        {

            plcMainMessageDisplayTextBox.Text = plcSettings.displayMessageString;
            plcMainMessageDisplayTextBox.BackColor = getDisplayMessageColor(plcSettings.displayMessageColor);
            mainSerialNumberLabel.Text = "Serial Number: " + plcSettings.mainSerialNumberString;
            plcSecondaryMessageTextBox.Text = plcSettings.secondaryDisplayMessageString;
            plcSecondaryMessageTextBox.BackColor = getDisplayMessageColor(plcSettings.secondaryDisplayMessageColor);
            secondarySerialNumberLabel.Text = "Serial Number: " + plcSettings.secondarySerialNumberString;

            mainPartCountGoodLabel.Text = "Good Parts: " + plcSettings.plcPartcounter.goodParts.ToString();
            mainPartCountRejectLabel.Text = "Rejects Parts: " + plcSettings.plcPartcounter.rejectParts.ToString();
            mainPartCountTotalLabel.Text = "Total Parts: " + plcSettings.plcPartcounter.totalParts.ToString();

            secondaryPartCountGoodLabel.Text = "Good Parts: " + plcSettings.plcSecPartCounter.goodParts.ToString();
            secondaryPartCountRejectLabel.Text = "Rejects Parts: " + plcSettings.plcSecPartCounter.rejectParts.ToString();
            secondaryPartCountTotalLabel.Text = "Total Parts: " + plcSettings.plcSecPartCounter.totalParts.ToString();

            mainResultValue1Label.Text = "Low Limit: " + plcSettings.plcResult.value1.ToString();
            mainResultValue2Label.Text = "Actual: " + plcSettings.plcResult.value2.ToString();
            mainResultValue3Label.Text = "High Limit: " + plcSettings.plcResult.value3.ToString();

            secondaryResultValue1Label.Text = "Low Limit: " + plcSettings.plcSecondaryResults.value1.ToString();
            secondaryResultValue2Label.Text = "Actual: " + plcSettings.plcSecondaryResults.value2.ToString();
            secondaryResultValue3Label.Text = "High Limit: " + plcSettings.plcSecondaryResults.value3.ToString();


        }

        private Color getDisplayMessageColor(int colorNumber) 
        {

            if (colorNumber == 1)
            {
                return Color.LightGreen;
            }

            if (colorNumber == 2)
            {
                return Color.Yellow;
            }

            if (colorNumber == 3)
            {
                return Color.Red;
            }

            if (colorNumber == 4)
            {
                return Color.Magenta;
            }

            return Control.DefaultBackColor;
        }

        private void updatePlcDisplayItems()
        {

            plcSecondaryMessageTextBox.Visible = plcSettings.secondaryMessageEnabled;
            mainMessageLabel.Text = (string.IsNullOrEmpty(plcSettings.displayMessageTitle)) ? "Station 1" : plcSettings.displayMessageTitle;
            secondaryMessageLabel.Text = (string.IsNullOrEmpty(plcSettings.secondaryMessageTitle)) ? "Station 2" : plcSettings.secondaryMessageTitle;

            int marginSize = (plcSecondaryMessageTextBox.Visible) ? 20 : 100;

            int xStart = marginSize;
            int xEnd = groupBoxMainDisplay.Size.Width - marginSize;
            int workingWidth = xEnd - xStart;
            int centerPoint = groupBoxMainDisplay.Size.Width / 2;

            //
            mainMessageLabel.Visible = plcMainMessageDisplayTextBox.Visible;
            mainPartCountGroupBox.Visible = plcSettings.countersEnabled && (plcMainMessageDisplayTextBox.Size.Width > mainPartCountGroupBox.Size.Width);
            mainSerialNumberLabel.Visible = plcMainMessageDisplayTextBox.Visible;
            mainResultsGroupBox.Visible = plcSettings.resultsEnabled && (plcMainMessageDisplayTextBox.Size.Width > mainResultsGroupBox.Size.Width);
            secondaryMessageLabel.Visible = plcSecondaryMessageTextBox.Visible;
            secondaryPartCountGroupBox.Visible = plcSettings.secondaryCountersEnabled && plcSecondaryMessageTextBox.Visible && (plcSecondaryMessageTextBox.Size.Width > secondaryPartCountGroupBox.Size.Width);
            secondarySerialNumberLabel.Visible = plcSecondaryMessageTextBox.Visible;
            secondaryResultsGroupBox.Visible = plcSettings.secondaryResultsEnabled && plcSecondaryMessageTextBox.Visible && (plcSecondaryMessageTextBox.Size.Width > secondaryResultsGroupBox.Size.Width);

            if (!plcSecondaryMessageTextBox.Visible)
            {
                int width = workingWidth;
                int height = plcMainMessageDisplayTextBox.Size.Height;
                int x = xStart;
                int y = groupBoxMainDisplay.Top + 20;

                plcMainMessageDisplayTextBox.SetBounds(x, y, width, height);

                //find center points of the display messages to set position of title labels.
                int centerMain = plcMainMessageDisplayTextBox.Location.X + (plcMainMessageDisplayTextBox.Size.Width / 2);
                mainMessageLabel.SetBounds((centerMain - (mainMessageLabel.Size.Width / 2)), groupBoxMainDisplay.Top, mainMessageLabel.Size.Width, mainMessageLabel.Size.Height);
                mainSerialNumberLabel.SetBounds(plcMainMessageDisplayTextBox.Location.X, plcMainMessageDisplayTextBox.Bottom, mainSerialNumberLabel.Size.Width, mainSerialNumberLabel.Size.Height);
                mainResultsGroupBox.SetBounds((centerMain - (mainResultsGroupBox.Size.Width / 2)), mainSerialNumberLabel.Bottom, mainResultsGroupBox.Size.Width, mainResultsGroupBox.Size.Height);

                int mainSerial_y = (mainResultsGroupBox.Visible) ? mainResultsGroupBox.Bottom : mainSerialNumberLabel.Bottom;
                mainPartCountGroupBox.SetBounds((centerMain - (mainPartCountGroupBox.Width / 2)), mainSerial_y, mainPartCountGroupBox.Size.Width, mainPartCountGroupBox.Size.Height);

            }
            else
            {
                int width = (workingWidth / 2) - (marginSize / 2);
                int height = plcMainMessageDisplayTextBox.Size.Height;

                int xMain = xStart;
                int xSec = xStart + width + marginSize;
                int y = groupBoxMainDisplay.Top + 20;

                plcMainMessageDisplayTextBox.SetBounds(xMain, y, width, height);
                plcSecondaryMessageTextBox.SetBounds(xSec, y, width, height);

                //find center points of the display messages to set position of title labels.
                int centerMain = plcMainMessageDisplayTextBox.Location.X + (plcMainMessageDisplayTextBox.Size.Width / 2);
                int centerSec = plcSecondaryMessageTextBox.Location.X + (plcSecondaryMessageTextBox.Size.Width / 2);

                //position the display message title labels.
                mainMessageLabel.SetBounds((centerMain - (mainMessageLabel.Size.Width / 2)), groupBoxMainDisplay.Top, mainMessageLabel.Size.Width, mainMessageLabel.Size.Height);
                secondaryMessageLabel.SetBounds((centerSec - (secondaryMessageLabel.Size.Width / 2)), groupBoxMainDisplay.Top, secondaryMessageLabel.Size.Width, secondaryMessageLabel.Size.Height);

                mainSerialNumberLabel.SetBounds(plcMainMessageDisplayTextBox.Location.X, plcMainMessageDisplayTextBox.Bottom, mainSerialNumberLabel.Size.Width, mainSerialNumberLabel.Size.Height);
                mainResultsGroupBox.SetBounds((centerMain - (mainResultsGroupBox.Size.Width / 2)), mainSerialNumberLabel.Bottom, mainResultsGroupBox.Size.Width, mainResultsGroupBox.Size.Height);

                int mainSerial_y = (mainResultsGroupBox.Visible) ? mainResultsGroupBox.Bottom : mainSerialNumberLabel.Bottom;
                mainPartCountGroupBox.SetBounds((centerMain - (mainPartCountGroupBox.Width / 2)), mainSerial_y, mainPartCountGroupBox.Size.Width, mainPartCountGroupBox.Size.Height);


                secondarySerialNumberLabel.SetBounds(plcSecondaryMessageTextBox.Location.X, plcSecondaryMessageTextBox.Bottom, secondarySerialNumberLabel.Size.Width, secondarySerialNumberLabel.Size.Height);
                secondaryResultsGroupBox.SetBounds((centerSec - (secondaryResultsGroupBox.Size.Width / 2)), secondarySerialNumberLabel.Bottom, secondaryResultsGroupBox.Size.Width, secondaryResultsGroupBox.Size.Height);

                int secSerial_y = (secondaryResultsGroupBox.Visible) ? secondaryResultsGroupBox.Bottom : secondarySerialNumberLabel.Bottom;
                secondaryPartCountGroupBox.SetBounds((centerSec - (secondaryPartCountGroupBox.Width / 2)), secSerial_y, secondaryPartCountGroupBox.Size.Width, secondaryPartCountGroupBox.Size.Height);

            }

        }


        #region Camera Status and Control

        public bool IsConnected
        {
            get
            {
                if (!(insight == null))
                    if (insight.State != Cognex.InSight.CvsInSightState.NotConnected)
                        return (true);
                    else
                        return false;
                else
                    return false;
            }
        }

        private void cvsInSightDisplay1_ResultsChanged(object sender, EventArgs e)
        {

            if (insight != null)
            {

                if (IsConnected)
                {
                    CvsCell displayTypeCell = insight.Results.Cells["Z0"];
                    if (displayTypeCell != null)
                    {

                        if (displayTypeCell.DataType == CvsCellDataType.FloatingPoint)
                        {
                            string myString = displayTypeCell.Text;
                            double cellValue = Convert.ToDouble(displayTypeCell.Text);
                            if (cellValue == 1)
                            {
                                displayType = DisplayType.Single;

                                CvsCell pictureCell = insight.Results.Cells["Z2"];
                                if (pictureCell.DataType == CvsCellDataType.FloatingPoint)
                                {

                                    if (cvsInSightDisplay1.SoftOnline)
                                    {
                                        double pictureNumber = Convert.ToDouble(pictureCell.Text);
                                        if (pictureNumber == 2)
                                        {
                                            pictureBox1UpdateImage();
                                        }
                                    }


                                }


                            }
                            else if (cellValue == 2)
                            {
                                displayType = DisplayType.Dual;

                                CvsCell sideCell = insight.Results.Cells["Z1"];
                                CvsCell pictureCell = insight.Results.Cells["Z2"];

                                if (pictureCell != null && sideCell != null)
                                {
                                    double sideNumber = (sideCell.DataType == CvsCellDataType.FloatingPoint) ? Convert.ToDouble(sideCell.Text) : 0;
                                    double pictureNumber = (pictureCell.DataType == CvsCellDataType.FloatingPoint) ? Convert.ToDouble(pictureCell.Text) : 0;

                                    if (cvsInSightDisplay1.SoftOnline)
                                    {
                                        if (sideNumber == 1 && pictureNumber == 2)
                                        {
                                            pictureBox1UpdateImage();
                                        }
                                        else if (sideNumber == 2 && pictureNumber == 2)
                                        {
                                            pictureBox2UpdateImage();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cvsInSightDisplay1_ConnectCompleted(object sender, CvsConnectCompletedEventArgs e)
        {
            insight = cvsInSightDisplay1.InSight;
        }

        #endregion


        #region Password verification

        private void checkPassword()
        {
            passwordForm passForm = new passwordForm();
            passForm.ShowDialog();
        }

        #endregion



        public static void sendButton(string tagName)
        {

            if (string.IsNullOrEmpty(tagName))
            {
                MessageBox.Show("Tag Name not assigned to requested Tag");
            }
            else
            {
                //sendButtonValue(tagName);
            }

        }

        private void sendButtonValue(string tagName)
        {
            object newValue;

            Tag buttonTag = new Tag();
            buttonTag.Controller = myPLC;
            buttonTag.Name = tagName;

            bool currentValue = (bool)buttonTag.Now;

            if (buttonTag.DataType == Logix.Tag.ATOMIC.BOOL)
            {
                newValue = !currentValue;

                buttonTag.Now = newValue;
            }

            bool aValue = (bool)buttonTag.Now;

            if (currentValue != aValue)
            {
                buttonTag.Now = !currentValue;
            }


        }

        #region Menu Items Actions

        private void manualControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            plcManualControlsForm.plcSettings = plcSettings;
            plcManualControlsForm.plc = myPLC;
            plcManualControlsForm.ShowDialog();
        }


        private void settingsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            checkPassword();
            if (isLocked)
            {
                if (skipPassword)
                {
                    skipPassword = false;
                }
                else
                {
                    MessageBox.Show("Password is Incorrect", "Login Error", MessageBoxButtons.OKCancel);
                }

            }
            else
            {
                cameraSettingsForm cameraSettings = new cameraSettingsForm(cameraIPAddress);
                cameraSettings.ShowDialog();
                cameraIPAddress = cameraSettings.ipAddress;
                Console.WriteLine(cameraIPAddress);
                Properties.Settings.Default.cameraIPAddress = cameraIPAddress;
                Properties.Settings.Default.Save();
                isLocked = true;
            }
        }

        private void plcConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectToPLC();

            if (myPLC.IsConnected)
            {
                addTags();
            }
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            checkPassword();
            if (isLocked)
            {
                if (skipPassword)
                {
                    skipPassword = false;
                }
                else
                {
                    MessageBox.Show("Password is Incorrect", "Login Error", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                plcSetupForm myPLCSetupForm = new plcSetupForm();
                myPLCSetupForm.plcSettings = plcSettings;
                myPLCSetupForm.ShowDialog();
                plcSettings = myPLCSetupForm.plcSettings;
                myPLCSetupForm.Dispose();

                setPLCSettingsIntoPropertiesDefault();
                

                if (plcSettings.communicationEnabled)
                {
                    if (!myPLC.IsConnected)
                    {
                        connectToPLC();
                    }

                    if (myPLC.IsConnected)
                    {
                        addTags();
                    }

                }

                isLocked = true;

                //updateMainGroupBoxDisplay();
            }
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkPassword();
            //updateMainGroupBoxDisplay();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cameraConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setUpCameraConnections();
        }

        private void clearStation1CountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearStation1Counter();
        }

        private void clearStation2CountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearStation2Counter();
        }

        private void clearAllCountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearStation1Counter();
            clearStation2Counter();
        }

        #endregion


        #region  Counter Resets To PLC

        private void clearStation1Counter()
        {
            sendButtonValue(plcSettings.plcPartcounter.resetButton.writeAddress);
        }

        private void clearStation2Counter()
        {

        }


        #endregion


        private void connectToPLC()
        {

            if (plcSettings.communicationEnabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.ipAddress))
                {
                    myPLC.IPAddress = plcSettings.ipAddress;
                    myPLC.Path = "0";
                    myPLC.Timeout = 3000;

                }
                else
                {
                    string msg = "No IP Address entered";
                    MessageBox.Show(msg, this.Text);
                }

                if (ResultCode.E_SUCCESS == myPLC.Connect())
                {


                    ///////////////////////////
                    // set scanning parameters

                    // Step 1: assign parent Controller class
                    MyGroup.Controller = myPLC;
                    // Step 2: start scanning
                    //MyGroup.ScanningMode = TagGroup.SCANMODE.ReadOnly;
                    MyGroup.Interval = 250;
                    MyGroup.ScanStart();

                }
                else
                {
                    string msg = "ERROR:" + myPLC.ErrorCode.ToString() + " - " + myPLC.ErrorString;
                    MessageBox.Show(msg, this.Text);
                }


            }
        }

        private void addTags()
        {
            //Clear all tags from tag group.  This will ensure that tags added to the plc setup form will not be duplicates.  And
            //also ensure tag are removed tag group when they are removed from plc setup form.
            MyGroup.Clear();

            //Assign display message and display message color addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (!string.IsNullOrEmpty(plcSettings.displayMessageAddress))
            {
                addTagToGroup(plcSettings.displayMessageAddress, 1);
            }

            if (!string.IsNullOrEmpty(plcSettings.displayMessageColorAddress))
            {
                addTagToGroup(plcSettings.displayMessageColorAddress, 2);
            }

            if (!string.IsNullOrEmpty(plcSettings.mainSerialNumberAddress))
            {
                addTagToGroup(plcSettings.mainSerialNumberAddress, 1);
            }

            //If secondary display is enabled and the address text boxes are not empty then,
            //Assign secondary message and color addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.secondaryMessageEnabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.secondaryDisplayMessageAddress))
                {
                    addTagToGroup(plcSettings.secondaryDisplayMessageAddress, 1);
                }

                if (!string.IsNullOrEmpty(plcSettings.secondaryDisplayMessageColorAddress))
                {
                    addTagToGroup(plcSettings.secondaryDisplayMessageColorAddress, 2);
                }

                if (!string.IsNullOrEmpty(plcSettings.secondarySerialNumberAddress))
                {
                    addTagToGroup(plcSettings.secondarySerialNumberAddress, 1);
                }

            }

            //If Auto and Manual buttons are enabled and the address text boxes are not empty then,
            //Assign auto and manual write and read addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.manualAutoButtonsEnabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.autoButton.writeAddress))
                {
                    addTagToGroup(plcSettings.autoButton.writeAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.autoButton.readAddress))
                {
                    addTagToGroup(plcSettings.autoButton.readAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.manualButton.writeAddress))
                {
                    addTagToGroup(plcSettings.manualButton.writeAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.manualButton.readAddress))
                {
                    addTagToGroup(plcSettings.manualButton.readAddress, 5);
                }
            }


            //If part counters are enabled and the address text boxes are not empty then,
            //Assign good part count, reject part count, and reset button write addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.countersEnabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcPartcounter.goodCountPLCAddress))
                {
                    addTagToGroup(plcSettings.plcPartcounter.goodCountPLCAddress, 2);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcPartcounter.rejectCountPLCAddress))
                {
                    addTagToGroup(plcSettings.plcPartcounter.rejectCountPLCAddress, 2);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcPartcounter.resetButton.writeAddress))
                {
                    addTagToGroup(plcSettings.plcPartcounter.resetButton.writeAddress, 5);
                }

            }

            if (plcSettings.secondaryCountersEnabled)
            {

                if (!string.IsNullOrEmpty(plcSettings.plcSecPartCounter.goodCountPLCAddress))
                {
                    addTagToGroup(plcSettings.plcSecPartCounter.goodCountPLCAddress, 2);

                }

                if (!string.IsNullOrEmpty(plcSettings.plcSecPartCounter.rejectCountPLCAddress))
                {
                    addTagToGroup(plcSettings.plcSecPartCounter.rejectCountPLCAddress, 2);

                }

                if (!string.IsNullOrEmpty(plcSettings.plcSecPartCounter.resetButton.writeAddress))
                {
                    addTagToGroup(plcSettings.plcSecPartCounter.resetButton.writeAddress, 5);

                }

            }


            //If Results Display is enabled and the address text boxes are not empty then,
            //Assign results addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.resultsEnabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcResult.plcResult1Address))
                {
                    addTagToGroup(plcSettings.plcResult.plcResult1Address, 4);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcResult.plcResult2Address))
                {
                    addTagToGroup(plcSettings.plcResult.plcResult2Address, 4);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcResult.plcResult3Address))
                {
                    addTagToGroup(plcSettings.plcResult.plcResult3Address, 4);
                }

            }

            if (plcSettings.secondaryResultsEnabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcSecondaryResults.plcResult1Address))
                {
                    addTagToGroup(plcSettings.plcSecondaryResults.plcResult1Address, 4);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcSecondaryResults.plcResult2Address))
                {
                    addTagToGroup(plcSettings.plcSecondaryResults.plcResult2Address, 4);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcSecondaryResults.plcResult3Address))
                {
                    addTagToGroup(plcSettings.plcSecondaryResults.plcResult3Address, 4);
                }
            }

            //If User Button 1 is enabled and the address text boxes are not empty then,
            //Assign User Button 1 write and read addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.plcButton1.enabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcButton1.writeAddress))
                {
                    addTagToGroup(plcSettings.plcButton1.writeAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcButton1.readAddress))
                {
                    addTagToGroup(plcSettings.plcButton1.readAddress, 5);
                }

            }

            //If User Button 2 is enabled and the address text boxes are not empty then,
            //Assign User Button 2 write and read addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.plcButton2.enabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcButton2.writeAddress))
                {
                    addTagToGroup(plcSettings.plcButton2.writeAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcButton2.readAddress))
                {
                    addTagToGroup(plcSettings.plcButton2.readAddress, 5);
                }

            }

            //If User Button 3 is enabled and the address text boxes are not empty then,
            //assign User Button 3 write and read addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.plcButton3.enabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcButton3.writeAddress))
                {
                    addTagToGroup(plcSettings.plcButton3.writeAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcButton3.readAddress))
                {
                    addTagToGroup(plcSettings.plcButton3.readAddress, 5);
                }

            }

            //If User Button 4 is enabled and the address text boxes are not empty then,
            //assign User Button 4 write and read addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.plcButton4.enabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcButton4.writeAddress))
                {
                    addTagToGroup(plcSettings.plcButton4.writeAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcButton4.readAddress))
                {
                    addTagToGroup(plcSettings.plcButton4.readAddress, 5);
                }

            }

            //If User Button 5 is enabled and the address text boxes are not empty then,
            //assign User Button 5 write and read addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.plcButton5.enabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcButton5.writeAddress))
                {
                    addTagToGroup(plcSettings.plcButton5.writeAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcButton5.readAddress))
                {
                    addTagToGroup(plcSettings.plcButton5.readAddress, 5);
                }

            }

            //If User Button 6 is enabled and the address text boxes are not empty then,
            //assign User Button 6 write and read addresses to the tag group. Send tag name in first argument.
            //The second argument is the tag type: 1 = string, 2 = dint, 3 = sint, 4 = real, 5 = bool.
            if (plcSettings.plcButton6.enabled)
            {
                if (!string.IsNullOrEmpty(plcSettings.plcButton6.writeAddress))
                {
                    addTagToGroup(plcSettings.plcButton6.writeAddress, 5);
                }

                if (!string.IsNullOrEmpty(plcSettings.plcButton6.readAddress))
                {
                    addTagToGroup(plcSettings.plcButton6.readAddress, 5);
                }

            }

            updateAfterGroupRead();

        }

        private void updateAfterGroupRead()
        {

            for (int i = 0; i < MyGroup.Count; i++)
            {
                Tag tag = (Tag)MyGroup.Tags[i];
                string thisString = tag.MyObject.ToString();

                if (thisString == plcSettings.displayMessageAddress)
                {
                    plcSettings.displayMessageString = tag.Value.ToString();
                }

                if (thisString == plcSettings.displayMessageColorAddress)
                {
                    plcSettings.displayMessageColor = (int)tag.Value;

                }

                if (thisString == plcSettings.mainSerialNumberAddress)
                {
                    plcSettings.mainSerialNumberString = tag.Value.ToString();
                }

                if (thisString == plcSettings.secondarySerialNumberAddress)
                {
                    plcSettings.secondarySerialNumberString = tag.Value.ToString();
                }

                if (thisString == plcSettings.secondaryDisplayMessageAddress)
                {
                    plcSettings.secondaryDisplayMessageString = tag.Value.ToString();
                }

                if (thisString == plcSettings.secondaryDisplayMessageColorAddress)
                {
                    plcSettings.secondaryDisplayMessageColor = (int)tag.Value;
                }

                if (thisString == plcSettings.plcPartcounter.goodCountPLCAddress)
                {
                    plcSettings.plcPartcounter.goodParts = (int)tag.Value;
                }

                if (thisString == plcSettings.plcPartcounter.rejectCountPLCAddress)
                {
                    plcSettings.plcPartcounter.rejectParts = (int)tag.Value;
                }

                if (thisString == plcSettings.plcSecPartCounter.goodCountPLCAddress)
                {
                    plcSettings.plcSecPartCounter.goodParts = (int)tag.Value;
                }

                if (thisString == plcSettings.plcSecPartCounter.rejectCountPLCAddress)
                {
                    plcSettings.plcSecPartCounter.rejectParts = (int)tag.Value;
                }

                if (thisString == plcSettings.plcResult.plcResult1Address)
                {
                    plcSettings.plcResult.value1 = Convert.ToDouble(tag.Value);
                }

                if (thisString == plcSettings.plcResult.plcResult2Address)
                {
                    plcSettings.plcResult.value2 = Convert.ToDouble(tag.Value);
                }

                if (thisString == plcSettings.plcResult.plcResult3Address)
                {
                    plcSettings.plcResult.value3 = Convert.ToDouble(tag.Value);
                }

                if (thisString == plcSettings.plcSecondaryResults.plcResult1Address)
                {
                    plcSettings.plcSecondaryResults.value1 = Convert.ToDouble(tag.Value);
                }

                if (thisString == plcSettings.plcSecondaryResults.plcResult2Address)
                {
                    plcSettings.plcSecondaryResults.value2 = Convert.ToDouble(tag.Value);
                }

                if (thisString == plcSettings.plcSecondaryResults.plcResult3Address)
                {
                    plcSettings.plcSecondaryResults.value3 = Convert.ToDouble(tag.Value);
                }

                if (thisString == plcSettings.autoButton.readAddress)
                {
                    plcSettings.autoButton.isActive = (bool)tag.Value;
                }

                if (thisString == plcSettings.manualButton.readAddress)
                {
                    plcSettings.manualButton.isActive = (bool)tag.Value;
                }

                if (thisString == plcSettings.plcButton1.readAddress)
                {
                    plcSettings.plcButton1.isActive = (bool)tag.Value;
                }

                if (thisString == plcSettings.plcButton2.readAddress)
                {
                    plcSettings.plcButton2.isActive = (bool)tag.Value;
                }

                if (thisString == plcSettings.plcButton3.readAddress)
                {
                    plcSettings.plcButton3.isActive = (bool)tag.Value;
                }

                if (thisString == plcSettings.plcButton4.readAddress)
                {
                    plcSettings.plcButton4.isActive = (bool)tag.Value;
                }

                if (thisString == plcSettings.plcButton5.readAddress)
                {
                    plcSettings.plcButton5.isActive = (bool)tag.Value;
                }

                if (thisString == plcSettings.plcButton6.readAddress)
                {
                    plcSettings.plcButton6.isActive = (bool)tag.Value;
                }
            }

        }

        private void addTagToGroup(string name, int dataType)
        {
            try
            {
                Tag newTag = new Tag();
                newTag.Name = name;
                switch (dataType)
                {
                    case 1:
                        newTag.DataType = Logix.Tag.ATOMIC.STRING;
                        break;

                    case 2:
                        newTag.DataType = Logix.Tag.ATOMIC.DINT;
                        break;

                    case 3:
                        newTag.DataType = Logix.Tag.ATOMIC.SINT;
                        break;

                    case 4:
                        newTag.DataType = Logix.Tag.ATOMIC.REAL;
                        break;

                    case 5:
                        newTag.DataType = Logix.Tag.ATOMIC.BOOL;
                        break;

                    default:
                        break;
                }

                myPLC.ReadTag(newTag);
                

                if (ResultCode.QUAL_GOOD == newTag.QualityCode)
                {

                    newTag.Changed += new System.EventHandler(newTag_Changed);

                    newTag.MyObject = newTag.Name;

                    MyGroup.AddTag(newTag);
                }
                else
                    
                    MessageBox.Show(newTag.Name.ToString() + " : Tag Not Found In PLC");
                    
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }




        }

        private void tagChanged(EventArgs e)
        {
            try
            {
                DataChangeEventArgs args = (DataChangeEventArgs)e;


                if (ResultCode.QUAL_GOOD == args.QualityCode)
                {


                    string thisString = args.MyObject.ToString();

                    if (thisString == plcSettings.displayMessageAddress)
                    {
                        plcSettings.displayMessageString = args.Value.ToString();
                    }

                    if (thisString == plcSettings.displayMessageColorAddress)
                    {
                        plcSettings.displayMessageColor = (int)args.Value;

                    }

                    if (thisString == plcSettings.mainSerialNumberAddress)
                    {
                        plcSettings.mainSerialNumberString = args.Value.ToString();
                    }

                    if (thisString == plcSettings.secondarySerialNumberAddress)
                    {
                        plcSettings.secondarySerialNumberString = args.Value.ToString();
                    }

                    if (thisString == plcSettings.secondaryDisplayMessageAddress)
                    {
                        plcSettings.secondaryDisplayMessageString = args.Value.ToString();
                    }

                    if (thisString == plcSettings.secondaryDisplayMessageColorAddress)
                    {
                        //int thisInt = (int)args.Value;

                        //switch ((int)args.Value)
                        //{
                        //    case 1:
                        //        plcSecondaryMessageTextBox.BackColor = Color.LightGreen;
                        //        break;

                        //    case 2:
                        //        plcSecondaryMessageTextBox.BackColor = Color.Yellow;
                        //        break;

                        //    case 3:
                        //        plcSecondaryMessageTextBox.BackColor = Color.Red;
                        //        break;

                        //    case 4:
                        //        plcSecondaryMessageTextBox.BackColor = Color.Magenta;
                        //        break;

                        //    default:
                        //        break;
                        //}

                        plcSettings.secondaryDisplayMessageColor = (int)args.Value;

                    }

                    if (thisString == plcSettings.plcPartcounter.goodCountPLCAddress)
                    {
                        plcSettings.plcPartcounter.goodParts = (int)args.Value;
                    }

                    if (thisString == plcSettings.plcPartcounter.rejectCountPLCAddress)
                    {
                        plcSettings.plcPartcounter.rejectParts = (int)args.Value;
                    }

                    if (thisString == plcSettings.plcSecPartCounter.goodCountPLCAddress)
                    {
                        plcSettings.plcSecPartCounter.goodParts = (int)args.Value;
                    }

                    if (thisString == plcSettings.plcSecPartCounter.rejectCountPLCAddress)
                    {
                        plcSettings.plcSecPartCounter.rejectParts = (int)args.Value;
                    }

                    if (thisString == plcSettings.plcResult.plcResult1Address)
                    {
                        plcSettings.plcResult.value1 = Convert.ToDouble(args.Value);
                    }

                    if (thisString == plcSettings.plcResult.plcResult2Address)
                    {
                        plcSettings.plcResult.value2 = Convert.ToDouble(args.Value);
                    }

                    if (thisString == plcSettings.plcResult.plcResult3Address)
                    {
                        plcSettings.plcResult.value3 = Convert.ToDouble(args.Value);
                    }

                    if (thisString == plcSettings.plcSecondaryResults.plcResult1Address)
                    {
                        plcSettings.plcSecondaryResults.value1 = Convert.ToDouble(args.Value);
                    }

                    if (thisString == plcSettings.plcSecondaryResults.plcResult2Address)
                    {
                        plcSettings.plcSecondaryResults.value2 = Convert.ToDouble(args.Value);
                    }

                    if (thisString == plcSettings.plcSecondaryResults.plcResult3Address)
                    {
                        plcSettings.plcSecondaryResults.value3 = Convert.ToDouble(args.Value);
                    }

                    if (thisString == plcSettings.autoButton.readAddress)
                    {
                        plcSettings.autoButton.isActive = (bool)args.Value;
                    }

                    if (thisString == plcSettings.manualButton.readAddress)
                    {
                        plcSettings.manualButton.isActive = (bool)args.Value;
                    }

                    if (thisString == plcSettings.plcButton1.readAddress)
                    {
                        plcSettings.plcButton1.isActive = (bool)args.Value;
                    }

                    if (thisString == plcSettings.plcButton2.readAddress)
                    {
                        plcSettings.plcButton2.isActive = (bool)args.Value;
                    }

                    if (thisString == plcSettings.plcButton3.readAddress)
                    {
                        plcSettings.plcButton3.isActive = (bool)args.Value;
                    }

                    if (thisString == plcSettings.plcButton4.readAddress)
                    {
                        plcSettings.plcButton4.isActive = (bool)args.Value;
                    }

                    if (thisString == plcSettings.plcButton5.readAddress)
                    {
                        plcSettings.plcButton5.isActive = (bool)args.Value;
                    }

                    if (thisString == plcSettings.plcButton6.readAddress)
                    {
                        plcSettings.plcButton6.isActive = (bool)args.Value;
                    }


                    //updateMainGroupBoxDisplay();
                }
                else

                    if (myPLC.IsConnected == false)
                    {
                        //_status.Text = "DISCONNECTED";
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        /// Tag.Changed event handler
        /// </summary>
        /// <param name="sender">
        /// Instance of Tag class that invoked the change</param>
        /// <param name="e">DataChangedEventArgs</param>
        private void newTag_Changed(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
            // since tag_changed is being called from the plcUpdate
            // thread, we need to ceated a delegate to handle the UI
            if (InvokeRequired)
                Invoke(new changedDelegate(tagChanged), new object[] { e });
            else
                tagChanged(e);
        }

        // <summary>
        /// Delegate for the UI update
        /// </summary>
        /// <param name="e">
        /// </param>
        delegate void changedDelegate(EventArgs e);

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tempPictureCounter == 0)
            {
                pictureBox1UpdateImage();
                if (displayType == DisplayType.Dual)
                {
                    tempPictureCounter++;
                }
                
            }
            else
            {
                pictureBox2UpdateImage();
                tempPictureCounter = 0;
            }


        }

        

        

        

    }
}
