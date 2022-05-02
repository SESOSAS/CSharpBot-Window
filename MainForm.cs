using CSharpBot_API;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBot_Window
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
            savecheckbox.Checked = MSettings.Default.IsSaved;
            channelidtextbox.Text = MSettings.Default.ChannelID;
            if (MSettings.Default.IsSaved)
            {
                channelidtextbox.Enabled = false;
            }
            else
            {
                channelidtextbox.Enabled = true;
            }
            rpccombobox.SelectedIndex = MSettings.Default.RPCMode;
            rpctextbox.Text = MSettings.Default.RPCText;
            verificationroletextbox.Text = MSettings.Default.VerificationRole;
            prefixtextbox.Text = MSettings.Default.Prefix;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MSettings.Default.IsSaved = savecheckbox.Checked;
            MSettings.Default.ChannelID = channelidtextbox.Text;
            if (MSettings.Default.IsSaved)
            {
                channelidtextbox.Enabled = false;
            }
            else
            {
                channelidtextbox.Enabled = true;
            }
            MSettings.Default.RPCMode = rpccombobox.SelectedIndex;
            MSettings.Default.RPCText = rpctextbox.Text;
            MSettings.Default.Save();

            if (DBot.IsOnline)
            {
                statuslabel.Text = String.Format("Status: {0}", "Online");
            }
            else
            {
                statuslabel.Text = String.Format("Status: {0}", "Offline");
            }
            MSettings.Default.Prefix = prefixtextbox.Text;
            MSettings.Default.VerificationRole = verificationroletextbox.Text;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            if (DBot.IsOnline)
                return;
            DBot.ClientStart();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            if (!DBot.IsOnline)
                return;
            DBot.ClientStop();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            if (!DBot.IsOnline)
                return;
            MSettings.Default.ChannelID = channelidtextbox.Text;
            DBot.ClientSendMessage(MSettings.Default.ChannelID, channelidrichtextbox.Text);
        }

        private void updaterpcbutton_Click(object sender, EventArgs e)
        {
            if (!DBot.IsOnline)
                return;
            DBot.ClientChangeRPC(rpccombobox.SelectedIndex, rpctextbox.Text, rpcurltextbox.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MSettings.Default.Save();
            DBot.ClientStop();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            channellist.Items.Clear();

            foreach (DiscordGuild guild in DBot.ArrayGuilds)
            {
                foreach(var channel in guild.Channels)
                {
                    channellist.Items.Add(channel.Value.Id.ToString());
                }
            }
        }

        private void channellist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DBot.IsOnline)
                return;
            if (channellist.SelectedItems.Count >= 1)
            {
                DBot.ChannelName(channellist.SelectedItems[0].Text);
                selectedchannel.Text = "Name: " + DBot.FetchedChannelName;
                MSettings.Default.ChannelID = channellist.SelectedItems[0].Text;
                channelidtextbox.Text = MSettings.Default.ChannelID;
            }
        }

        private void updatevirificationrole_Click(object sender, EventArgs e)
        {
            DBot.VerificationRoleID = verificationroletextbox.Text;
            MSettings.Default.VerificationRole = DBot.VerificationRoleID;
        }

        private void prefixbutton_Click(object sender, EventArgs e)
        {
            DBot.prefix = prefixtextbox.Text;
            MSettings.Default.Prefix = DBot.prefix;
        }
    }
}
