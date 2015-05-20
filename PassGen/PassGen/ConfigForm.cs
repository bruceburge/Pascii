using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassGen
{
    public partial class ConfigForm : Form
    {
        private Form1 m_parent;

        public ConfigForm(Form1 tmp)
        {
            InitializeComponent();
            m_parent = tmp;
        }

        private void btnGenerateSeed_Click(object sender, EventArgs e)
        {
            string mixedChars = PassGen.Properties.Settings.Default.PassChars + PassGen.Properties.Settings.Default.ForcedSpecials;
            txtPrivateKey.Text = Functions.GetRandomString(new Random(), 256, mixedChars);
        }

        private void txtSaveConfig_Click(object sender, EventArgs e)
        {
            PassGen.Properties.Settings.Default.PrivateKey = txtPrivateKey.Text;
            PassGen.Properties.Settings.Default.PassChars = txtPassChars.Text;
            PassGen.Properties.Settings.Default.DefaultLength = trbDefaultLength.Value;
            PassGen.Properties.Settings.Default.ForceSpecial = chkForceSpecial.Checked;
            PassGen.Properties.Settings.Default.IncludeSpecials = chkIncludedSpecials.Checked;
            PassGen.Properties.Settings.Default.ForcedSpecials = txtForceSpecial.Text;
            PassGen.Properties.Settings.Default.TurnOffBalloon = chkTurnOffBalloon.Checked;
            PassGen.Properties.Settings.Default.UserNameNonCaseSensative = chkNonCaseSensative.Checked;

            PassGen.Properties.Settings.Default.Save();
            PassGen.Properties.Settings.Default.Reload();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            groupBox2.Text = "Password Length :" + trbDefaultLength.Value;
        }

        private void chkUnlockKeyGen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnlockKeyGen.Checked == true)
            {
               DialogResult result = MessageBox.Show(
                   "Changing your Key will make it impossible to replicate passwords created in the past!"+Environment.NewLine+"Are you sure you want to Generate a new key?",
                    "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);                

               if (result == DialogResult.Yes)
               {
                   txtPrivateKey.ReadOnly = false;
                   btnGenerateSeed.Enabled = true;
               }
            }
            else
            {
                txtPrivateKey.ReadOnly = true;
                btnGenerateSeed.Enabled = false;
            }
        }

        private void chkTurnOffBalloon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_parent.TopMost = true;
        }

        private void trbDefaultLength_Scroll(object sender, EventArgs e)
        {
            groupBox2.Text = "Password Length :" + trbDefaultLength.Value;
        }
    }
}