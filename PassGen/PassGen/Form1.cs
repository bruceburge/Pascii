using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskBar tmp = new taskBar();
            ConfigForm ConfigFrm = new ConfigForm(this);
            ConfigFrm.Location = tmp.touchSysTray(ConfigFrm);
            this.TopMost = false;
            ConfigFrm.TopMost = true;
            ConfigFrm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taskBar tmp = new taskBar();
            this.Location = tmp.touchSysTray(this);
            
            if (PassGen.Properties.Settings.Default.PrivateKey.Length < 1)
            {
                string mixedChars = PassGen.Properties.Settings.Default.PassChars + PassGen.Properties.Settings.Default.ForcedSpecials;
                string pkey = Functions.GetRandomString(new Random(),256,mixedChars);
                MessageBox.Show(
                    "No Private key found one will be generated for you" + Environment.NewLine + 
                    "To manually change your key, right click on the systray icon and click \"Configuration\"" + Environment.NewLine +
                    "=Auto Generated Key="+Environment.NewLine+ pkey,
                    "Pascii 1st Time Configuration Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PassGen.Properties.Settings.Default.PrivateKey = pkey;
                PassGen.Properties.Settings.Default.Save();
            }
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == true)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

       
        private void btnGenerate_Click(object sender, EventArgs e)
        {            
            if (PassGen.Properties.Settings.Default.UserNameNonCaseSensative == true)
            {
                txtUserName.Text = txtUserName.Text.ToLower();
            }
            string userInput = txtUserName.Text;

            Random strRand = new Random(Functions.str2int(PassGen.Properties.Settings.Default.PrivateKey) - Functions.str2int(userInput));
            txtPassword.Text = Functions.GenPassword(strRand);
            txtPassword.Focus();
            txtPassword.SelectAll();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (PassGen.Properties.Settings.Default.TurnOffBalloon == false)
            {
                notifyIcon1.ShowBalloonTip(1000, "Pascii Started", "For more apps goto http://bruceburge.com", ToolTipIcon.Info);
            }
        }

        private void generatedRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Functions.GenPassword(new Random()), TextDataFormat.Text);
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                showHideToolStripMenuItem.Text = "Show";
                this.Hide();
            }
            else
            {
                showHideToolStripMenuItem.Text = "Hide";
                this.Show();
            }            
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("http://bruceburge.com");           
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                showHideToolStripMenuItem.Text = "Show";                
            }
            else
            {
                showHideToolStripMenuItem.Text = "Hide";
            }   
        }
    }
}