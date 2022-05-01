using CSharpBot_API;
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
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DBot.DCClientStop();
            Close();
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
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            DBot.DCClientStart();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            DBot.DCClientStop();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            DBot.SendMessage(channelidtextbox.Text, channelidrichtextbox.Text);
        }

        private void updaterpcbutton_Click(object sender, EventArgs e)
        {
            DBot.ChangeRPC(rpccombobox.SelectedIndex, rpctextbox.Text, rpcurltextbox.Text);
        }
    }
}
