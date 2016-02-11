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
    public partial class hotkeyPopupForm : Form
    {
        bool setHotkeyControl;
        bool setHotkeyShift;
        bool setHotkeyAlt;
        KeyEventArgs setHotkeyKeyCode;
        bool canAccept = false;
        Form1 form1;
        public hotkeyPopupForm()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.hotkeyTextBox.KeyDown += new KeyEventHandler(hotkeyTextBox_KeyDown);
        }

        public hotkeyPopupForm(int interval, int clicks, int total, int clicksPerTick, Form1 oldform)
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.hotkeyTextBox.KeyDown += new KeyEventHandler(hotkeyTextBox_KeyDown);
            form1 = oldform;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.toggleable = true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (canAccept)
            {
                if (setHotkeyControl)
                    form1.setControl = true;
                else
                    form1.setControl = false;
                if (setHotkeyShift)
                    form1.setShift = true;
                else
                    form1.setShift = false;
                if (setHotkeyAlt)
                    form1.setAlt = true;
                else
                    form1.setAlt = false;

                form1.hotkeyLabel.Text = "Hotkey: " + hotkeyTextBox.Text;

                form1.hotkeyKeyEventArgsSetter = setHotkeyKeyCode;
                setHotkeyAlt = false;
                setHotkeyControl = false;
                setHotkeyShift = false;
                this.Close();
                form1.toggleable = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void hotkeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            //Empty the text box
            hotkeyTextBox.Text = "";
            //Check to see if Control, Shift, and/or Alt were held down while the key was pressed
            if (e.Control)
            {
                hotkeyTextBox.Text += "Control + ";
                setHotkeyControl = true;
            }
            if (e.Shift)
            {
                hotkeyTextBox.Text += "Shift + ";
                setHotkeyShift = true;
            }
            if (e.Alt)
            {
                hotkeyTextBox.Text += "Alt + ";
                setHotkeyAlt = true;
            }
            //Add the actual key to the end of the string
            if (e.KeyCode.ToString().Length == 1)
            {
                hotkeyTextBox.Text += e.KeyCode.ToString();
                setHotkeyKeyCode = e;
                canAccept = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            canAccept = false;
            hotkeyTextBox.Text = "";
        }

        private void hotkeyPopupForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            form1.toggleable = true;
        }
        private void Form2_FormClosing(Object sender, FormClosingEventArgs e)
        {
            form1.toggleable = true;
        }

    }
}
