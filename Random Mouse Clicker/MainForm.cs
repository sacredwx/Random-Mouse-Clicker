﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Mouse_Clicker
{
    public partial class MainForm : Form
    {
        private int originalFormWidth;
        private int originalFormHeight;
        private static Point location;
        private Random random = new Random();
        private bool widthNotZero;
        private bool heightNotZero;
        private decimal[] minMax = new decimal[2];
        private readonly Hotkey hotkey = new Hotkey();

        public MainForm()
        {
            InitializeComponent();

            originalFormWidth = this.Width;
            originalFormHeight = this.Height;
            comboBoxClickEvery.SelectedIndex = 1;
            comboBoxDuration.SelectedIndex = 0;

            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey();
        }
        
        private void selectAreaButton_Click(object sender, EventArgs e)
        {
            SnippingTool.Snip();
            buttonStart.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
         int x1 = SnippingTool.getDrawnRectangle().X;
         int x2 = SnippingTool.getDrawnRectangle().X + SnippingTool.getRectangleWidth();
         int y1 = SnippingTool.getDrawnRectangle().Y;
         int y2 = SnippingTool.getDrawnRectangle().Y + SnippingTool.getRectangleHeight();

         location = new Point(random.Next(x1,x2), random.Next(y1, y2));
         checkMouseSpeed(location);
         checkClickInterval(comboBoxClickEvery, numericClickEveryMin.Value, numericClickEveryMax.Value);
         checkManualOrAutomatic();

        }

        private void checkManualOrAutomatic()
        {
            int x1 = SnippingTool.getDrawnRectangle().X;
            int x2 = SnippingTool.getDrawnRectangle().X + SnippingTool.getRectangleWidth();
            int y1 = SnippingTool.getDrawnRectangle().Y;
            int y2 = SnippingTool.getDrawnRectangle().Y + SnippingTool.getRectangleHeight();

            if (radioEndManually.Checked)
            {
                ShowBalloonMessage("Press CTRL+WIN+ESC to exit the program...", "Random Mouse Clicker");
                this.WindowState = FormWindowState.Minimized;

                new Thread(delegate () {

                    while (true)
                    {
                        location = new Point(random.Next(x1, x2), random.Next(y1, y2));
                        checkMouseSpeed(location);
                        MouseActions.MouseClick();
                        Thread.Sleep(random.Next((int)minMax[0], (int)minMax[1]));
                    }

                }).Start();               
            }

            else if (radioEndAutomatically.Checked)
            {
                decimal duration = checkClickDuration(comboBoxDuration, numericDuration.Value);

                if (duration != 0)
                {

                }
            }
        }

        private decimal[] checkClickInterval(ComboBox comboBox, decimal min, decimal max)
        {                  
            if (comboBox.Text == "millisecond(s)")
            {
                minMax[0] = min;
                minMax[1] = max;
            }

            else if (comboBox.Text == "second(s)")
            {
                minMax[0] = min * 1000;
                minMax[1] = max * 1000;
            }

            else if(comboBox.Text == "minute(s)")
            {
                minMax[0] = min * 1000 * 60;
                minMax[1] = max * 1000 * 60;
            }

            else if(comboBox.Text == "hour(s)")
            {
                minMax[0] = min * 1000 * 60 * 60;
                minMax[1] = max * 1000 * 60 * 60;
            }

            else if(comboBox.Text == "day(s)")
            {
                minMax[0] = min * 1000 * 60 * 60 * 24;
                minMax[1] = max * 1000 * 60 * 60 * 24;
            }

            return minMax;
        }

        private decimal checkClickDuration(ComboBox comboBox, decimal duration)
        {
            if (comboBox.Text == "click(s)")
            {
                for (int i = 0; i < duration; i++)
                {

                }

                return 0;
            }

            else if (comboBox.Text == "millisecond(s)")
            {
                return duration;
            }

            else if (comboBox.Text == "second(s)")
            {
                return duration * 1000;
            }

            else if (comboBox.Text == "minute(s)")
            {
                return duration * 1000 * 60;
            }

            else if (comboBox.Text == "hour(s)")
            {
                return duration * 1000 * 60 * 60;
            }

            else if (comboBox.Text == "day(s)")
            {
                return duration * 1000 * 60 * 60 * 24;
            }

            return 0;
        }

        private void checkMouseSpeed(Point location)
        {
            if (radioSlow.Checked)
            {
                MouseLinearSmoothMove.slow(location);
            }

            else if (radioNormal.Checked)
            {
                MouseLinearSmoothMove.normal(location);
            }

            else if (radioFast.Checked)
            {
                MouseLinearSmoothMove.fast(location);
            }

            else if (radioInstant.Checked)
            {
                MouseLinearSmoothMove.instant(location);
            }
        }

        private void endManuallyRadio_CheckedChanged(object sender, EventArgs e)
        {
            setAutomaticDuration(false);
        }

        private void endAutomaticallyRadio_CheckedChanged(object sender, EventArgs e)
        {
            setAutomaticDuration(true);
        }

        private void setAutomaticDuration(bool b)
        {
            groupBoxDuration.Enabled = b;
            numericDuration.Enabled = b;
            comboBoxDuration.Enabled = b;
        }

        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            bool basicTabSelected = tabControl1.SelectedIndex == 0;
            bool advancedTabSelected = tabControl1.SelectedIndex == 1;
            bool previewTabSelected = tabControl1.SelectedIndex == 2;
            widthNotZero = SnippingTool.getRectangleWidth() != 0;
            heightNotZero = SnippingTool.getRectangleHeight() != 0;

            if (basicTabSelected)
            {
                this.Width = originalFormWidth;
                this.Height = originalFormHeight;
            }
            else if (advancedTabSelected && widthNotZero && heightNotZero)
            {
                labelWidthHeight.Text = "The area has a width of " + SnippingTool.getRectangleWidth() + " pixels\r\n"
                + " and a height of " + SnippingTool.getRectangleHeight() + " pixels";

                checkBoxDivideInto.Enabled = true;
                divideIntoEqualAreasDisplay();

                this.Width = originalFormWidth;
                this.Height = originalFormHeight;
            }
            else if (previewTabSelected && widthNotZero && heightNotZero)
            {
                previewPictureBox.Visible = true;
                labelPreviewInstructions.Visible = false;
                
                if (SnippingTool.Image.Width > tabControl1.Width)
                {
                    this.Width = SnippingTool.Image.Width + (this.Width - tabControl1.Width) + 8;
                }
                
                if (SnippingTool.Image.Height > tabControl1.Height)
                {
                    this.Height = SnippingTool.Image.Height + (this.Height - tabControl1.Height) + 25;
                }

                previewPictureBox.Image = SnippingTool.Image;
            }
        }

        private void divideIntoEqualAreasCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDivideInto.Checked && widthNotZero && heightNotZero)
            {
                divideIntoEqualAreasDisplay();
                enableDividedAreas(true);
                forceAutomaticEnd();
            }
            else
            {
                enableDividedAreas(false);
                setBackToManualEnd();
            }
        }

        private void enableDividedAreas(bool b)
        {
            numericDivideIntoEqualAreas.Enabled = b;
            labelClickEachArea.Enabled = b;
            labelClickEachTimes.Enabled = b;
            labelOf.Enabled = b;
            labelCannotBeChanged.Visible = b;
            comboBoxDividedAreas.Enabled = b;
            numericClickEachArea.Enabled = b;
        }

        private void forceAutomaticEnd()
        {          
            radioEndAutomatically.Checked = true;
            radioEndManually.Enabled = false;
            comboBoxDuration.Enabled = false;
            comboBoxDuration.SelectedIndex = 0;
            numericDuration.Value = updateTotalClicksDisplay();
            numericDuration.Enabled = false;
        }

        private void setBackToManualEnd()
        {
            radioEndManually.Checked = true;
            radioEndManually.Enabled = true;
            numericDuration.Value = 1;
        }

        private int updateTotalClicksDisplay()
        {
            return (int)numericDivideIntoEqualAreas.Value * (int)numericClickEachArea.Value;
        }

        private void numericDivideIntoEqualAreas_ValueChanged(object sender, EventArgs e)
        {
            divideIntoEqualAreasDisplay();
            numericDuration.Value = updateTotalClicksDisplay();
        }

        private void divideIntoEqualAreasDisplay()
        {
            ImageSplitter.getDimensions((int)numericDivideIntoEqualAreas.Value);
            comboBoxDividedAreas.Items.Clear();

            for (int i = 0; i < ImageSplitter.dimensions.Count(); i++)
            {
                String s = ImageSplitter.dimensionWidths[i] + " x " + ImageSplitter.dimensionHeights[i];
                comboBoxDividedAreas.Items.Add(s);
            }

            comboBoxDividedAreas.SelectedIndex = 0;
        }

        private void numericClickEachArea_ValueChanged(object sender, EventArgs e)
        {
            numericDuration.Value = updateTotalClicksDisplay();
        }

        private void ShowBalloonMessage(string text, string title)
        {
            notifyIcon.BalloonTipText = text;
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.ShowBalloonTip(1000);
        }

        private void RegisterHotKey()
        {
            hotkey.Control = true;
            hotkey.Windows = true;
            hotkey.KeyCode = Keys.Escape;
            
            hotkey.Pressed += Hk_Win_ESC_OnPressed;

            if (!hotkey.GetCanRegister(this))
            {
                Console.WriteLine("Already registered");
            }
            else
            {
                hotkey.Register(this);
            }
        }

        private void Hk_Win_ESC_OnPressed(object sender, HandledEventArgs handledEventArgs)
        {
            Exit();
        }

        private void UnregisterHotkey()
        {
            if (hotkey.Registered)
            {
                hotkey.Unregister();
            }
        }

        private void menuExit_Click_1(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            notifyIcon.Visible = false;
            notifyIcon.Dispose();
            UnregisterHotkey();
            Application.Exit();
            Environment.Exit(0);
        }       
    }
}
