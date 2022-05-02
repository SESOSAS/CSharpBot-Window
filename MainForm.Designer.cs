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
            this.statuslabel = new System.Windows.Forms.Label();
            this.stopbutton = new System.Windows.Forms.Button();
            this.startbutton = new System.Windows.Forms.Button();
            this.sendmessage = new System.Windows.Forms.TabPage();
            this.selectedchannel = new System.Windows.Forms.Label();
            this.fetchbutton = new System.Windows.Forms.Button();
            this.channellist = new System.Windows.Forms.ListView();
            this.sendbutton = new System.Windows.Forms.Button();
            this.savecheckbox = new System.Windows.Forms.CheckBox();
            this.channelidrichtextbox = new System.Windows.Forms.RichTextBox();
            this.channelidtextbox = new System.Windows.Forms.TextBox();
            this.changerpc = new System.Windows.Forms.TabPage();
            this.updaterpcbutton = new System.Windows.Forms.Button();
            this.rpcurltextbox = new System.Windows.Forms.TextBox();
            this.rpctextbox = new System.Windows.Forms.TextBox();
            this.rpccombobox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.verificationroletextbox = new System.Windows.Forms.TextBox();
            this.updatevirificationrole = new System.Windows.Forms.Button();
            this.prefixbutton = new System.Windows.Forms.Button();
            this.prefixtextbox = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Size = new System.Drawing.Size(411, 221);
            this.tabControl1.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.groupBox1);
            this.settings.Location = new System.Drawing.Point(4, 24);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3);
            this.settings.Size = new System.Drawing.Size(403, 193);
            this.settings.TabIndex = 0;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prefixtextbox);
            this.groupBox1.Controls.Add(this.prefixbutton);
            this.groupBox1.Controls.Add(this.updatevirificationrole);
            this.groupBox1.Controls.Add(this.verificationroletextbox);
            this.groupBox1.Controls.Add(this.statuslabel);
            this.groupBox1.Controls.Add(this.stopbutton);
            this.groupBox1.Controls.Add(this.startbutton);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Location = new System.Drawing.Point(6, 163);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(81, 15);
            this.statuslabel.TabIndex = 1;
            this.statuslabel.Text = "Status: Offline";
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(6, 68);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(379, 23);
            this.stopbutton.TabIndex = 0;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(6, 39);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(379, 23);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // sendmessage
            // 
            this.sendmessage.Controls.Add(this.selectedchannel);
            this.sendmessage.Controls.Add(this.fetchbutton);
            this.sendmessage.Controls.Add(this.channellist);
            this.sendmessage.Controls.Add(this.sendbutton);
            this.sendmessage.Controls.Add(this.savecheckbox);
            this.sendmessage.Controls.Add(this.channelidrichtextbox);
            this.sendmessage.Controls.Add(this.channelidtextbox);
            this.sendmessage.Location = new System.Drawing.Point(4, 24);
            this.sendmessage.Name = "sendmessage";
            this.sendmessage.Padding = new System.Windows.Forms.Padding(3);
            this.sendmessage.Size = new System.Drawing.Size(403, 193);
            this.sendmessage.TabIndex = 1;
            this.sendmessage.Text = "Message";
            this.sendmessage.UseVisualStyleBackColor = true;
            // 
            // selectedchannel
            // 
            this.selectedchannel.AutoSize = true;
            this.selectedchannel.Location = new System.Drawing.Point(6, 11);
            this.selectedchannel.Name = "selectedchannel";
            this.selectedchannel.Size = new System.Drawing.Size(45, 15);
            this.selectedchannel.TabIndex = 6;
            this.selectedchannel.Text = "Name: ";
            // 
            // fetchbutton
            // 
            this.fetchbutton.Location = new System.Drawing.Point(6, 164);
            this.fetchbutton.Name = "fetchbutton";
            this.fetchbutton.Size = new System.Drawing.Size(167, 23);
            this.fetchbutton.TabIndex = 5;
            this.fetchbutton.Text = "Fetch";
            this.fetchbutton.UseVisualStyleBackColor = true;
            this.fetchbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // channellist
            // 
            this.channellist.HideSelection = false;
            this.channellist.Location = new System.Drawing.Point(6, 37);
            this.channellist.Name = "channellist";
            this.channellist.Size = new System.Drawing.Size(167, 121);
            this.channellist.TabIndex = 4;
            this.channellist.UseCompatibleStateImageBehavior = false;
            this.channellist.SelectedIndexChanged += new System.EventHandler(this.channellist_SelectedIndexChanged);
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(179, 164);
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
            this.savecheckbox.Location = new System.Drawing.Point(347, 10);
            this.savecheckbox.Name = "savecheckbox";
            this.savecheckbox.Size = new System.Drawing.Size(50, 19);
            this.savecheckbox.TabIndex = 2;
            this.savecheckbox.Text = "Save";
            this.savecheckbox.UseVisualStyleBackColor = true;
            // 
            // channelidrichtextbox
            // 
            this.channelidrichtextbox.Location = new System.Drawing.Point(179, 37);
            this.channelidrichtextbox.Name = "channelidrichtextbox";
            this.channelidrichtextbox.Size = new System.Drawing.Size(218, 121);
            this.channelidrichtextbox.TabIndex = 1;
            this.channelidrichtextbox.Text = "";
            // 
            // channelidtextbox
            // 
            this.channelidtextbox.Location = new System.Drawing.Point(179, 8);
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
            this.changerpc.Size = new System.Drawing.Size(403, 193);
            this.changerpc.TabIndex = 2;
            this.changerpc.Text = "RPC";
            this.changerpc.UseVisualStyleBackColor = true;
            // 
            // updaterpcbutton
            // 
            this.updaterpcbutton.Location = new System.Drawing.Point(3, 127);
            this.updaterpcbutton.Name = "updaterpcbutton";
            this.updaterpcbutton.Size = new System.Drawing.Size(397, 23);
            this.updaterpcbutton.TabIndex = 3;
            this.updaterpcbutton.Text = "Update";
            this.updaterpcbutton.UseVisualStyleBackColor = true;
            this.updaterpcbutton.Click += new System.EventHandler(this.updaterpcbutton_Click);
            // 
            // rpcurltextbox
            // 
            this.rpcurltextbox.Location = new System.Drawing.Point(3, 98);
            this.rpcurltextbox.Name = "rpcurltextbox";
            this.rpcurltextbox.PlaceholderText = "This is a cool StreamURL!";
            this.rpcurltextbox.Size = new System.Drawing.Size(397, 23);
            this.rpcurltextbox.TabIndex = 2;
            // 
            // rpctextbox
            // 
            this.rpctextbox.Location = new System.Drawing.Point(3, 69);
            this.rpctextbox.Name = "rpctextbox";
            this.rpctextbox.PlaceholderText = "This is a cool text!";
            this.rpctextbox.Size = new System.Drawing.Size(397, 23);
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
            this.rpccombobox.Size = new System.Drawing.Size(397, 23);
            this.rpccombobox.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // verificationroletextbox
            // 
            this.verificationroletextbox.Location = new System.Drawing.Point(6, 97);
            this.verificationroletextbox.Name = "verificationroletextbox";
            this.verificationroletextbox.PlaceholderText = "Verification Role ID";
            this.verificationroletextbox.Size = new System.Drawing.Size(296, 23);
            this.verificationroletextbox.TabIndex = 1;
            // 
            // updatevirificationrole
            // 
            this.updatevirificationrole.Location = new System.Drawing.Point(308, 97);
            this.updatevirificationrole.Name = "updatevirificationrole";
            this.updatevirificationrole.Size = new System.Drawing.Size(77, 23);
            this.updatevirificationrole.TabIndex = 2;
            this.updatevirificationrole.Text = "Update";
            this.updatevirificationrole.UseVisualStyleBackColor = true;
            this.updatevirificationrole.Click += new System.EventHandler(this.updatevirificationrole_Click);
            // 
            // prefixbutton
            // 
            this.prefixbutton.Location = new System.Drawing.Point(308, 126);
            this.prefixbutton.Name = "prefixbutton";
            this.prefixbutton.Size = new System.Drawing.Size(77, 23);
            this.prefixbutton.TabIndex = 3;
            this.prefixbutton.Text = "Update";
            this.prefixbutton.UseVisualStyleBackColor = true;
            this.prefixbutton.Click += new System.EventHandler(this.prefixbutton_Click);
            // 
            // prefixtextbox
            // 
            this.prefixtextbox.Location = new System.Drawing.Point(6, 127);
            this.prefixtextbox.Name = "prefixtextbox";
            this.prefixtextbox.PlaceholderText = "Prefix";
            this.prefixtextbox.Size = new System.Drawing.Size(296, 23);
            this.prefixtextbox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 243);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "CSharpBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.settings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ListView channellist;
        private System.Windows.Forms.Button fetchbutton;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label selectedchannel;
        private System.Windows.Forms.Button updatevirificationrole;
        private System.Windows.Forms.TextBox verificationroletextbox;
        private System.Windows.Forms.TextBox prefixtextbox;
        private System.Windows.Forms.Button prefixbutton;
    }
}