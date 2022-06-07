namespace ComputerGander
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.ipButton = new System.Windows.Forms.Button();
            this.macButton = new System.Windows.Forms.Button();
            this.macLabel = new System.Windows.Forms.Label();
            this.enterIPLabel = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.pingDataLabel = new System.Windows.Forms.Label();
            this.generatePingData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.packetsListBox = new System.Windows.Forms.ListBox();
            this.PacketsLabel = new System.Windows.Forms.Label();
            this.primaryTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(6, 122);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(20, 15);
            this.ipAddressLabel.TabIndex = 0;
            this.ipAddressLabel.Text = "IP:";
            // 
            // ipButton
            // 
            this.ipButton.Location = new System.Drawing.Point(6, 96);
            this.ipButton.Name = "ipButton";
            this.ipButton.Size = new System.Drawing.Size(168, 23);
            this.ipButton.TabIndex = 1;
            this.ipButton.Text = "Show IP Address";
            this.ipButton.UseVisualStyleBackColor = true;
            this.ipButton.Click += new System.EventHandler(this.GenerateIP);
            // 
            // macButton
            // 
            this.macButton.Location = new System.Drawing.Point(6, 27);
            this.macButton.Name = "macButton";
            this.macButton.Size = new System.Drawing.Size(168, 23);
            this.macButton.TabIndex = 2;
            this.macButton.Text = "Show MAC Address";
            this.macButton.UseVisualStyleBackColor = true;
            this.macButton.Click += new System.EventHandler(this.GenerateMAC);
            // 
            // macLabel
            // 
            this.macLabel.AutoSize = true;
            this.macLabel.Location = new System.Drawing.Point(6, 53);
            this.macLabel.Name = "macLabel";
            this.macLabel.Size = new System.Drawing.Size(37, 15);
            this.macLabel.TabIndex = 3;
            this.macLabel.Text = "MAC:";
            // 
            // enterIPLabel
            // 
            this.enterIPLabel.AutoSize = true;
            this.enterIPLabel.Location = new System.Drawing.Point(64, 247);
            this.enterIPLabel.Name = "enterIPLabel";
            this.enterIPLabel.Size = new System.Drawing.Size(91, 15);
            this.enterIPLabel.TabIndex = 5;
            this.enterIPLabel.Text = "Enter IP to Ping:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(6, 275);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(199, 23);
            this.ipTextBox.TabIndex = 6;
            // 
            // pingDataLabel
            // 
            this.pingDataLabel.AutoSize = true;
            this.pingDataLabel.Location = new System.Drawing.Point(15, 357);
            this.pingDataLabel.Name = "pingDataLabel";
            this.pingDataLabel.Size = new System.Drawing.Size(0, 15);
            this.pingDataLabel.TabIndex = 8;
            // 
            // generatePingData
            // 
            this.generatePingData.Location = new System.Drawing.Point(6, 331);
            this.generatePingData.Name = "generatePingData";
            this.generatePingData.Size = new System.Drawing.Size(199, 23);
            this.generatePingData.TabIndex = 9;
            this.generatePingData.Text = "Generate Ping Data";
            this.generatePingData.UseVisualStyleBackColor = true;
            this.generatePingData.Click += new System.EventHandler(this.GeneratePing);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Example: 12.345.678.90";
            // 
            // packetsListBox
            // 
            this.packetsListBox.FormattingEnabled = true;
            this.packetsListBox.ItemHeight = 15;
            this.packetsListBox.Location = new System.Drawing.Point(285, 27);
            this.packetsListBox.Name = "packetsListBox";
            this.packetsListBox.Size = new System.Drawing.Size(212, 334);
            this.packetsListBox.TabIndex = 11;
            // 
            // PacketsLabel
            // 
            this.PacketsLabel.AutoSize = true;
            this.PacketsLabel.Location = new System.Drawing.Point(345, 9);
            this.PacketsLabel.Name = "PacketsLabel";
            this.PacketsLabel.Size = new System.Drawing.Size(97, 15);
            this.PacketsLabel.TabIndex = 12;
            this.PacketsLabel.Text = "Received Packets";
            // 
            // primaryTimer
            // 
            this.primaryTimer.Enabled = true;
            this.primaryTimer.Interval = 2000;
            this.primaryTimer.Tick += new System.EventHandler(this.primaryTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.PacketsLabel);
            this.Controls.Add(this.packetsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generatePingData);
            this.Controls.Add(this.pingDataLabel);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.enterIPLabel);
            this.Controls.Add(this.macLabel);
            this.Controls.Add(this.macButton);
            this.Controls.Add(this.ipButton);
            this.Controls.Add(this.ipAddressLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ipAddressLabel;
        private Button ipButton;
        private Button macButton;
        private Label macLabel;
        private Label enterIPLabel;
        private TextBox ipTextBox;
        private Label pingDataLabel;
        private Button generatePingData;
        private Label label1;
        private ListBox packetsListBox;
        private Label PacketsLabel;
        private System.Windows.Forms.Timer primaryTimer;
    }
}