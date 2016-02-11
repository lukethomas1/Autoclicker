using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker2._0
{
    public partial class Form1 : Form
    {
        //Imports the user32.dll DLL
        [DllImport("user32.dll")]
        //Declares the mouse_event function
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        [DllImport("user32.dll")]
        public extern static short GetAsyncKeyState(Keys vKeys);
        [DllImport("user32.dll")]
        public extern static short GetAsyncKeyState(System.Int32 vKey);
        [DllImport("user32.dll")]
        public extern static short GetKeyState(System.Int32 nVirtKey);
        [DllImport("user32.dll")]
        public extern static short GetKeyState(Keys vKeys);
        //Sets variables for the dwFlags of mouse events (left button down, left up, right down, right up)
        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        public Form1()
        {
            InitializeComponent();
        }

        int currentClicks;
        int totalClicks;
        int clicksPerTick;
        public bool setControl = true;
        public bool setShift = true;
        public bool setAlt;
        public bool index1 = true;
        public bool index2 = false;
        public KeyEventArgs hotkeyKeyEventArgsSetter;

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            clicksPerTick = (int)clicksPerTickBox.Value;
            //clicks the number of times set in the clicksPerTick value box
            if (index1)
            {
                for (int i = 0; i < clicksPerTick; i++)
                {
                    DoMouseClick();
                }
                index1 = false;
            }
            else if(index2)
            {
                for (int i = 0; i < clicksPerTick; i++)
                {
                    DoMouseClick();
                }
                index1 = true;
                index2 = false;
            }
            else
            {
                index2 = true;
            }
            clicksLabel.Text = "Clicks: " + currentClicks.ToString();
            totalLabel.Text = "Total: " + totalClicks.ToString();
            
        }

        string hotkeyLetter = "A";
        private void hotkeyTimer_Tick(object sender, EventArgs e)
        {
            if (hotkeyKeyEventArgsSetter != null)
                hotkeyLetter = hotkeyKeyEventArgsSetter.KeyCode.ToString().ToUpper();

            Keys hotkeyKey = (Keys)Enum.Parse(typeof(Keys), hotkeyLetter.ToUpper());

            if (GetAsyncKeyState(hotkeyKey) == -32767)
            {
                if (setControl && setShift && setAlt)
                {
                    if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                    {
                        if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                        {
                            if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
                            {
                                toggleTimer(tickTimer);
                                hotkeyLabel.Text = "Hotkey: Ctrl + Shift + Alt + " + hotkeyLetter;
                            }
                        }
                    }
                }

                else if (setControl && setAlt)
                {
                    if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                    {
                        if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
                        {
                            toggleTimer(tickTimer);
                            hotkeyLabel.Text = "Hotkey: Ctrl + Alt + " + hotkeyLetter;
                        }
                    }
                }

                else if (setShift && setAlt)
                {
                    if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                    {
                        if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
                        {
                            toggleTimer(tickTimer);
                            hotkeyLabel.Text = "Hotkey: Shift + Alt + " + hotkeyLetter;
                        }
                    }
                }

                else if (setControl && setShift)
                {
                    if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                    {
                        if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                        {
                            toggleTimer(tickTimer);
                            hotkeyLabel.Text = "Hotkey: Ctrl + Shift + " + hotkeyLetter;
                        }
                    }
                }

                else if (setControl)
                {
                    toggleTimer(tickTimer);
                    hotkeyLabel.Text = "Hotkey: Ctrl + " + hotkeyLetter;
                }

                else if (setShift)
                {
                    toggleTimer(tickTimer);
                    hotkeyLabel.Text = "Hotkey: Shift + " + hotkeyLetter;
                }

                else if (setAlt)
                {
                    toggleTimer(tickTimer);
                    hotkeyLabel.Text = "Hotkey: Alt + " + hotkeyLetter;
                }
                else
                {
                    toggleTimer(tickTimer);
                    hotkeyLabel.Text = "Hotkey: " + hotkeyLetter;
                }
            }
        }
        


        //Clicks the mouse once
        //Increments the click counters
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint Xcoord = (uint)Cursor.Position.X;
            uint Ycoord = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, Xcoord, Ycoord, 0, 0);//mousedown
            mouse_event(MOUSEEVENTF_LEFTUP, Xcoord, Ycoord, 0, 0);//mouseup
            currentClicks++;
            totalClicks++;
        }

        //When "Stop" button is pressed
        private void btnStop_Click(object sender, EventArgs e)
        {
            stopClicking();
        }

        //When "Start" button is pressed
        private void btnStart_Click(object sender, EventArgs e)
        {
            startClicking();
        }

        int timerInterval;
        //Starts clicking
        private void startClicking()
        {
            tickTimer.Start();
            timerInterval = Convert.ToInt32(intervalBox.Text);
            tickTimer.Interval = timerInterval;
        }

        //Stops Timer, sets the "current" click counter to 0
        private void stopClicking()
        {
            tickTimer.Stop();
            currentClicks = 0;
        }

        private void toggleTimer(Timer timer)
        {
            if (toggleable)
            {
                if (timer.Enabled)
                {
                    timer.Stop();
                    stopClicking();
                }
                else
                {
                    timer.Start();
                    startClicking();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void testLabel_Click(object sender, EventArgs e)
        {

        }

        private void startHotkey_Click(object sender, EventArgs e)
        {
            startClicking();
        }

        public bool toggleable = true;
        private void hotkeyChangeMenu_Click(object sender, EventArgs e)
        {
            hotkeyPopupForm form2 = new hotkeyPopupForm(timerInterval, currentClicks, totalClicks, clicksPerTick, this);
            form2.Show();
            toggleable = false;
        }

        int mouseCoordX;
        int mouseCoordY;
        //bool firstTime = true;

        private void setPointButton_Click(object sender, EventArgs e)
        {

            


            if(setPointButton.Text == "Set Point")
            {
                setPointButton.Text = "Waiting";
                if(setPointButton.Capture == true)
                {
                    MessageBox.Show("Captured");
                }
                setPointTimer.Start();
            }
            else if(setPointButton.Text == "Delete")
            {
                setPointButton.Text = "Set Point";
                mouseCoordX = 0;
                mouseCoordY = 0;
            }
        }

        bool isDown = false;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            //MessageBox.Show("dunfuckedup");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            //MessageBox.Show("dunfuckedup1");
        }

        int ticks = 0;

        private void setPointTimer_Tick(object sender, EventArgs e)
        {
            ticks++;
            label1.Text = ticks.ToString() + ", " + isDown.ToString() + ", X: " + mouseCoordX + ", Y: " + mouseCoordY;
            if(System.Windows.Input.Mouse.LeftButton == System.Windows.Input.MouseButtonState.Released)
            {
                mouseCoordX = System.Windows.Forms.Cursor.Position.X;
                mouseCoordY = System.Windows.Forms.Cursor.Position.Y;
                //MessageBox.Show(mouseCoordX + " , " + mouseCoordY);
                //setPointButton.Text = "Delete";
                //setPointTimer.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int testClicks = 0;

        private void testButton_Click(object sender, EventArgs e)
        {
            testClicks++;
            testLabel.Text = testClicks.ToString();
        }
    }
}
