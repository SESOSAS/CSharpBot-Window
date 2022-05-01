namespace CSharpBot_Window
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopbutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.sendmessage = new System.Windows.Forms.TabPage();
            this.sendbutton = new System.Windows.Forms.Button();
            this.savecheckbox = new System.Windows.Forms.CheckBox();
            this.channelidrichtextbox = new System.Windows.Forms.RichTextBox();
            this.channelidtextbox = new System.Windows.Forms.TextBox();
            this.changerpc = new System.Windows.Forms.TabPage();
            this.rpctextbox = new System.Windows.Forms.TextBox();
            this.rpccombobox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rpcurltextbox = new System.Windows.Forms.TextBox();
            this.updaterpcbutton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.settings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.sendmessage.SuspendLayout();
            this.changerpc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.settings);
            this.tabControl1.Controls.Add(this.sendmessage);
            this.tabControl1.Controls.Add(this.changerpc);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 221);
            this.tabControl1.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.groupBox1);
            this.settings.Location = new System.Drawing.Point(4, 24);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3);
            this.settings.Size = new System.Drawing.Size(230, 193);
            this.settings.TabIndex = 0;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopbutton);
            this.groupBox1.Controls.Add(this.startbutton);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(6, 101);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(205, 23);
            this.stopbutton.TabIndex = 0;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(6, 72);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(205, 23);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // sendmessage
            // 
            this.sendmessage.Controls.Add(this.sendbutton);
            this.sendmessage.Controls.Add(this.savecheckbox);
            this.sendmessage.Controls.Add(this.channelidrichtextbox);
            this.sendmessage.Controls.Add(this.channelidtextbox);
            this.sendmessage.Location = new System.Drawing.Point(4, 24);
            this.sendmessage.Name = "sendmessage";
            this.sendmessage.Padding = new System.Windows.Forms.Padding(3);
            this.sendmessage.Size = new System.Drawing.Size(230, 193);
            this.sendmessage.TabIndex = 1;
            this.sendmessage.Text = "Message";
            this.sendmessage.UseVisualStyleBackColor = true;
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(6, 162);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(218, 23);
            this.sendbutton.TabIndex = 3;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // savecheckbox
            // 
            this.savecheckbox.AutoSize = true;
            this.savecheckbox.Location = new System.Drawing.Point(174, 8);
            this.savecheckbox.Name = "savecheckbox";
            this.savecheckbox.Size = new System.Drawing.Size(50, 19);
            this.savecheckbox.TabIndex = 2;
            this.savecheckbox.Text = "Save";
            this.savecheckbox.UseVisualStyleBackColor = true;
            // 
            // channelidrichtextbox
            // 
            this.channelidrichtextbox.Location = new System.Drawing.Point(6, 35);
            this.channelidrichtextbox.Name = "channelidrichtextbox";
            this.channelidrichtextbox.Size = new System.Drawing.Size(218, 121);
            this.channelidrichtextbox.TabIndex = 1;
            this.channelidrichtextbox.Text = "";
            // 
            // channelidtextbox
            // 
            this.channelidtextbox.Location = new System.Drawing.Point(6, 6);
            this.channelidtextbox.Name = "channelidtextbox";
            this.channelidtextbox.PlaceholderText = "ChannelID";
            this.channelidtextbox.Size = new System.Drawing.Size(162, 23);
            this.channelidtextbox.TabIndex = 0;
            // 
            // changerpc
            // 
            this.changerpc.Controls.Add(this.updaterpcbutton);
            this.changerpc.Controls.Add(this.rpcurltextbox);
            this.changerpc.Controls.Add(this.rpctextbox);
            this.changerpc.Controls.Add(this.rpccombobox);
            this.changerpc.Location = new System.Drawing.Point(4, 24);
            this.changerpc.Name = "changerpc";
            this.changerpc.Size = new System.Drawing.Size(230, 193);
            this.changerpc.TabIndex = 2;
            this.changerpc.Text = "RPC";
            this.changerpc.UseVisualStyleBackColor = true;
            // 
            // rpctextbox
            // 
            this.rpctextbox.Location = new System.Drawing.Point(3, 69);
            this.rpctextbox.Name = "rpctextbox";
            this.rpctextbox.PlaceholderText = "This is a cool text!";
            this.rpctextbox.Size = new System.Drawing.Size(224, 23);
            this.rpctextbox.TabIndex = 1;
            // 
            // rpccombobox
            // 
            this.rpccombobox.FormattingEnabled = true;
            this.rpccombobox.Items.AddRange(new object[] {
            "Playing",
            "Streaming",
            "ListeningTo",
            "Watching",
            "Custom",
            "Competing"});
            this.rpccombobox.Location = new System.Drawing.Point(3, 40);
            this.rpccombobox.Name = "rpccombobox";
            this.rpccombobox.Size = new System.Drawing.Size(224, 23);
            this.rpccombobox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rpcurltextbox
            // 
            this.rpcurltextbox.Location = new System.Drawing.Point(3, 98);
            this.rpcurltextbox.Name = "rpcurltextbox";
            this.rpcurltextbox.PlaceholderText = "This is a cool StreamURL!";
            this.rpcurltextbox.Size = new System.Drawing.Size(224, 23);
            this.rpcurltextbox.TabIndex = 2;
            // 
            // updaterpcbutton
            // 
            this.updaterpcbutton.Location = new System.Drawing.Point(3, 127);
            this.updaterpcbutton.Name = "updaterpcbutton";
            this.updaterpcbutton.Size = new System.Drawing.Size(224, 23);
            this.updaterpcbutton.TabIndex = 3;
            this.updaterpcbutton.Text = "Update";
            this.updaterpcbutton.UseVisualStyleBackColor = true;
            this.updaterpcbutton.Click += new System.EventHandler(this.updaterpcbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 243);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "CSharpBot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.settings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.sendmessage.ResumeLayout(false);
            this.sendmessage.PerformLayout();
            this.changerpc.ResumeLayout(false);
            this.changerpc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.TabPage sendmessage;
        private System.Windows.Forms.CheckBox savecheckbox;
        private System.Windows.Forms.RichTextBox channelidrichtextbox;
        private System.Windows.Forms.TextBox channelidtextbox;
        private System.Windows.Forms.TabPage changerpc;
        private System.Windows.Forms.TextBox rpctextbox;
        private System.Windows.Forms.ComboBox rpccombobox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.TextBox rpcurltextbox;
        private System.Windows.Forms.Button updaterpcbutton;
    }
}