namespace AutoClicker2._0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clicksLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.clicksPerTickLabel = new System.Windows.Forms.Label();
            this.clicksPerTickBox = new System.Windows.Forms.NumericUpDown();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.hotkeyTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startHotkey = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeyChangeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setPointButton = new System.Windows.Forms.Button();
            this.setPointTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clicksPerTickBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clicksLabel
            // 
            this.clicksLabel.AutoSize = true;
            this.clicksLabel.Location = new System.Drawing.Point(14, 61);
            this.clicksLabel.Name = "clicksLabel";
            this.clicksLabel.Size = new System.Drawing.Size(47, 13);
            this.clicksLabel.TabIndex = 4;
            this.clicksLabel.Text = "Clicks: 0";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(14, 84);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(43, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total: 0";
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(63, 38);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(40, 20);
            this.intervalBox.TabIndex = 7;
            this.intervalBox.TabStop = false;
            this.intervalBox.Text = "1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(171, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(171, 41);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // clicksPerTickLabel
            // 
            this.clicksPerTickLabel.AutoSize = true;
            this.clicksPerTickLabel.Location = new System.Drawing.Point(12, 112);
            this.clicksPerTickLabel.Name = "clicksPerTickLabel";
            this.clicksPerTickLabel.Size = new System.Drawing.Size(99, 13);
            this.clicksPerTickLabel.TabIndex = 12;
            this.clicksPerTickLabel.Text = "# of Clicks per Tick";
            // 
            // clicksPerTickBox
            // 
            this.clicksPerTickBox.Location = new System.Drawing.Point(211, 110);
            this.clicksPerTickBox.Name = "clicksPerTickBox";
            this.clicksPerTickBox.Size = new System.Drawing.Size(35, 20);
            this.clicksPerTickBox.TabIndex = 13;
            this.clicksPerTickBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(12, 41);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(45, 13);
            this.intervalLabel.TabIndex = 14;
            this.intervalLabel.Text = "Interval:";
            // 
            // tickTimer
            // 
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Location = new System.Drawing.Point(12, 148);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(114, 13);
            this.hotkeyLabel.TabIndex = 15;
            this.hotkeyLabel.Text = "Hotkey: Ctrl + Shift + A";
            // 
            // hotkeyTimer
            // 
            this.hotkeyTimer.Enabled = true;
            this.hotkeyTimer.Interval = 30;
            this.hotkeyTimer.Tick += new System.EventHandler(this.hotkeyTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(258, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeysToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startHotkey,
            this.hotkeyChangeMenu});
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            // 
            // startHotkey
            // 
            this.startHotkey.Name = "startHotkey";
            this.startHotkey.Size = new System.Drawing.Size(161, 22);
            this.startHotkey.Text = "Start Clicking";
            this.startHotkey.Click += new System.EventHandler(this.startHotkey_Click);
            // 
            // hotkeyChangeMenu
            // 
            this.hotkeyChangeMenu.Name = "hotkeyChangeMenu";
            this.hotkeyChangeMenu.Size = new System.Drawing.Size(161, 22);
            this.hotkeyChangeMenu.Text = "Change Hotkeys";
            this.hotkeyChangeMenu.Click += new System.EventHandler(this.hotkeyChangeMenu_Click);
            // 
            // setPointButton
            // 
            this.setPointButton.Location = new System.Drawing.Point(171, 135);
            this.setPointButton.Name = "setPointButton";
            this.setPointButton.Size = new System.Drawing.Size(75, 23);
            this.setPointButton.TabIndex = 18;
            this.setPointButton.Text = "Set Point";
            this.setPointButton.UseVisualStyleBackColor = true;
            this.setPointButton.Click += new System.EventHandler(this.setPointButton_Click);
            // 
            // setPointTimer
            // 
            this.setPointTimer.Interval = 10;
            this.setPointTimer.Tick += new System.EventHandler(this.setPointTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(183, 74);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 20;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(156, 79);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(13, 13);
            this.testLabel.TabIndex = 21;
            this.testLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 170);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setPointButton);
            this.Controls.Add(this.hotkeyLabel);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.clicksPerTickBox);
            this.Controls.Add(this.clicksPerTickLabel);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.clicksLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.clicksPerTickBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label clicksLabel;
        internal System.Windows.Forms.Label totalLabel;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.Label clicksPerTickLabel;
        internal System.Windows.Forms.NumericUpDown clicksPerTickBox;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Timer hotkeyTimer;
        internal System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startHotkey;
        private System.Windows.Forms.ToolStripMenuItem hotkeyChangeMenu;
        public System.Windows.Forms.Label hotkeyLabel;
        private System.Windows.Forms.Button setPointButton;
        private System.Windows.Forms.Timer setPointTimer;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label testLabel;
    }
}

