namespace SerialCommGUI
{
    partial class transmitForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentPortSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.rTxtBoxInput = new System.Windows.Forms.RichTextBox();
            this.rTxtBoxSent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rTxtBoxRecieve = new System.Windows.Forms.RichTextBox();
            this.WriteDataBttn = new System.Windows.Forms.Button();
            this.ClearRecievedBttn = new System.Windows.Forms.Button();
            this.activePort = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comPortToolStripMenuItem,
            this.showCurrentPortSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // comPortToolStripMenuItem
            // 
            this.comPortToolStripMenuItem.Name = "comPortToolStripMenuItem";
            this.comPortToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.comPortToolStripMenuItem.Text = "Configure Port";
            this.comPortToolStripMenuItem.Click += new System.EventHandler(this.comPortToolStripMenuItem_Click);
            // 
            // showCurrentPortSettingsToolStripMenuItem
            // 
            this.showCurrentPortSettingsToolStripMenuItem.Name = "showCurrentPortSettingsToolStripMenuItem";
            this.showCurrentPortSettingsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.showCurrentPortSettingsToolStripMenuItem.Text = "Show Current Port Settings";
            this.showCurrentPortSettingsToolStripMenuItem.Click += new System.EventHandler(this.showCurrentPortSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data to Write:";
            // 
            // rTxtBoxInput
            // 
            this.rTxtBoxInput.Location = new System.Drawing.Point(10, 47);
            this.rTxtBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTxtBoxInput.Name = "rTxtBoxInput";
            this.rTxtBoxInput.Size = new System.Drawing.Size(330, 63);
            this.rTxtBoxInput.TabIndex = 2;
            this.rTxtBoxInput.Text = "";
            // 
            // rTxtBoxSent
            // 
            this.rTxtBoxSent.Location = new System.Drawing.Point(9, 140);
            this.rTxtBoxSent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTxtBoxSent.Name = "rTxtBoxSent";
            this.rTxtBoxSent.ReadOnly = true;
            this.rTxtBoxSent.Size = new System.Drawing.Size(330, 106);
            this.rTxtBoxSent.TabIndex = 3;
            this.rTxtBoxSent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Sent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Recieved:";
            // 
            // rTxtBoxRecieve
            // 
            this.rTxtBoxRecieve.Location = new System.Drawing.Point(9, 277);
            this.rTxtBoxRecieve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTxtBoxRecieve.Name = "rTxtBoxRecieve";
            this.rTxtBoxRecieve.ReadOnly = true;
            this.rTxtBoxRecieve.Size = new System.Drawing.Size(330, 106);
            this.rTxtBoxRecieve.TabIndex = 6;
            this.rTxtBoxRecieve.Text = "";
            // 
            // WriteDataBttn
            // 
            this.WriteDataBttn.Location = new System.Drawing.Point(9, 387);
            this.WriteDataBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WriteDataBttn.Name = "WriteDataBttn";
            this.WriteDataBttn.Size = new System.Drawing.Size(130, 29);
            this.WriteDataBttn.TabIndex = 7;
            this.WriteDataBttn.Text = "Write Data";
            this.WriteDataBttn.UseVisualStyleBackColor = true;
            this.WriteDataBttn.Click += new System.EventHandler(this.WriteDataBttn_Click);
            // 
            // ClearRecievedBttn
            // 
            this.ClearRecievedBttn.Location = new System.Drawing.Point(214, 387);
            this.ClearRecievedBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearRecievedBttn.Name = "ClearRecievedBttn";
            this.ClearRecievedBttn.Size = new System.Drawing.Size(124, 29);
            this.ClearRecievedBttn.TabIndex = 8;
            this.ClearRecievedBttn.Text = "Clear Recieved Data";
            this.ClearRecievedBttn.UseVisualStyleBackColor = true;
            this.ClearRecievedBttn.Click += new System.EventHandler(this.ClearRecievedBttn_Click);
            // 
            // activePort
            // 
            this.activePort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.activePort_DataReceived);
            // 
            // transmitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 426);
            this.Controls.Add(this.ClearRecievedBttn);
            this.Controls.Add(this.WriteDataBttn);
            this.Controls.Add(this.rTxtBoxRecieve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rTxtBoxSent);
            this.Controls.Add(this.rTxtBoxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "transmitForm";
            this.Text = "Serial Communication G.U.I";
            this.Load += new System.EventHandler(this.TransmitForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTxtBoxInput;
        private System.Windows.Forms.RichTextBox rTxtBoxSent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTxtBoxRecieve;
        private System.Windows.Forms.Button WriteDataBttn;
        private System.Windows.Forms.Button ClearRecievedBttn;
        private System.Windows.Forms.ToolStripMenuItem showCurrentPortSettingsToolStripMenuItem;
        private System.IO.Ports.SerialPort activePort;
    }
}