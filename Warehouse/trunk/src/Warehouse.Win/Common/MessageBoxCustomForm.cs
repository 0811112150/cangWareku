using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.Common;
using System.Media;
using System.IO;

namespace Warehouse.Win
{
    public partial class MessageBoxCustomForm : Form
    {
        private static SoundPlayer soundPlayer;

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public MessageBoxCustomForm(string msg)
        {
            InitializeComponent();

            lblMsg.Text = msg;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MessageBoxCustomForm_Load(object sender, EventArgs e)
        {

            if (soundPlayer == null)
            {
                var alarmFile = Path.Combine(SystemInfo.SystemBaseDir, ConfigHelper.AlarmFileName);
                soundPlayer = new SoundPlayer(alarmFile);
            }

            soundPlayer.PlayLooping();
        }

        private void MessageBoxCustomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (soundPlayer != null)
            {
                soundPlayer.Stop();
            }
        }
    }
}
