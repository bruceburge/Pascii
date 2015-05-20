namespace PassGen
{
    partial class ConfigForm
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
            this.txtSaveConfig = new System.Windows.Forms.Button();
            this.btnGenerateSeed = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassChars = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkNonCaseSensative = new System.Windows.Forms.CheckBox();
            this.chkIncludedSpecials = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForceSpecial = new System.Windows.Forms.TextBox();
            this.chkForceSpecial = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trbDefaultLength = new System.Windows.Forms.TrackBar();
            this.chkUnlockKeyGen = new System.Windows.Forms.CheckBox();
            this.chkTurnOffBalloon = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDefaultLength)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSaveConfig
            // 
            this.txtSaveConfig.Location = new System.Drawing.Point(412, 395);
            this.txtSaveConfig.Name = "txtSaveConfig";
            this.txtSaveConfig.Size = new System.Drawing.Size(106, 23);
            this.txtSaveConfig.TabIndex = 8;
            this.txtSaveConfig.Text = "Save Configuration";
            this.txtSaveConfig.UseVisualStyleBackColor = true;
            this.txtSaveConfig.Click += new System.EventHandler(this.txtSaveConfig_Click);
            // 
            // btnGenerateSeed
            // 
            this.btnGenerateSeed.Enabled = false;
            this.btnGenerateSeed.Location = new System.Drawing.Point(301, 395);
            this.btnGenerateSeed.Name = "btnGenerateSeed";
            this.btnGenerateSeed.Size = new System.Drawing.Size(107, 23);
            this.btnGenerateSeed.TabIndex = 9;
            this.btnGenerateSeed.Text = "Generate New Key";
            this.btnGenerateSeed.UseVisualStyleBackColor = true;
            this.btnGenerateSeed.Click += new System.EventHandler(this.btnGenerateSeed_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPrivateKey);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(499, 116);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Private Key";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PassGen.Properties.Settings.Default, "PrivateKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivateKey.Location = new System.Drawing.Point(3, 16);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(493, 97);
            this.txtPrivateKey.TabIndex = 0;
            this.txtPrivateKey.Text = global::PassGen.Properties.Settings.Default.PrivateKey;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassChars);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 50);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possible Password Characters";
            // 
            // txtPassChars
            // 
            this.txtPassChars.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PassGen.Properties.Settings.Default, "PassChars", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPassChars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassChars.Location = new System.Drawing.Point(3, 16);
            this.txtPassChars.Name = "txtPassChars";
            this.txtPassChars.Size = new System.Drawing.Size(493, 20);
            this.txtPassChars.TabIndex = 3;
            this.txtPassChars.Text = global::PassGen.Properties.Settings.Default.PassChars;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkNonCaseSensative);
            this.groupBox4.Controls.Add(this.chkIncludedSpecials);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtForceSpecial);
            this.groupBox4.Controls.Add(this.chkForceSpecial);
            this.groupBox4.Location = new System.Drawing.Point(12, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(502, 134);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Password Generation Options";
            // 
            // chkNonCaseSensative
            // 
            this.chkNonCaseSensative.AutoSize = true;
            this.chkNonCaseSensative.Checked = global::PassGen.Properties.Settings.Default.UserNameNonCaseSensative;
            this.chkNonCaseSensative.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNonCaseSensative.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PassGen.Properties.Settings.Default, "UserNameNonCaseSensative", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkNonCaseSensative.Location = new System.Drawing.Point(6, 21);
            this.chkNonCaseSensative.Name = "chkNonCaseSensative";
            this.chkNonCaseSensative.Size = new System.Drawing.Size(169, 17);
            this.chkNonCaseSensative.TabIndex = 18;
            this.chkNonCaseSensative.Text = "Username non case sensative";
            this.chkNonCaseSensative.UseVisualStyleBackColor = true;
            // 
            // chkIncludedSpecials
            // 
            this.chkIncludedSpecials.AutoSize = true;
            this.chkIncludedSpecials.Checked = global::PassGen.Properties.Settings.Default.IncludeSpecials;
            this.chkIncludedSpecials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludedSpecials.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PassGen.Properties.Settings.Default, "IncludeSpecials", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkIncludedSpecials.Location = new System.Drawing.Point(6, 67);
            this.chkIncludedSpecials.Name = "chkIncludedSpecials";
            this.chkIncludedSpecials.Size = new System.Drawing.Size(324, 17);
            this.chkIncludedSpecials.TabIndex = 5;
            this.chkIncludedSpecials.Text = "Force special characters to be intermixed through out password";
            this.chkIncludedSpecials.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Possible special characters";
            // 
            // txtForceSpecial
            // 
            this.txtForceSpecial.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::PassGen.Properties.Settings.Default, "ForcedSpecials", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtForceSpecial.Location = new System.Drawing.Point(147, 89);
            this.txtForceSpecial.Name = "txtForceSpecial";
            this.txtForceSpecial.Size = new System.Drawing.Size(233, 20);
            this.txtForceSpecial.TabIndex = 6;
            this.txtForceSpecial.Text = global::PassGen.Properties.Settings.Default.ForcedSpecials;
            // 
            // chkForceSpecial
            // 
            this.chkForceSpecial.AutoSize = true;
            this.chkForceSpecial.Checked = global::PassGen.Properties.Settings.Default.ForceSpecial;
            this.chkForceSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkForceSpecial.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PassGen.Properties.Settings.Default, "ForceSpecial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkForceSpecial.Location = new System.Drawing.Point(6, 44);
            this.chkForceSpecial.Name = "chkForceSpecial";
            this.chkForceSpecial.Size = new System.Drawing.Size(381, 17);
            this.chkForceSpecial.TabIndex = 4;
            this.chkForceSpecial.Text = "Force a random character to be added to the start and end of the password";
            this.chkForceSpecial.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trbDefaultLength);
            this.groupBox2.Location = new System.Drawing.Point(13, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 59);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password Length";
            // 
            // trbDefaultLength
            // 
            this.trbDefaultLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PassGen.Properties.Settings.Default, "DefaultLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trbDefaultLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbDefaultLength.Location = new System.Drawing.Point(3, 16);
            this.trbDefaultLength.Maximum = 256;
            this.trbDefaultLength.Minimum = 6;
            this.trbDefaultLength.Name = "trbDefaultLength";
            this.trbDefaultLength.Size = new System.Drawing.Size(490, 40);
            this.trbDefaultLength.TabIndex = 1;
            this.trbDefaultLength.Value = global::PassGen.Properties.Settings.Default.DefaultLength;
            this.trbDefaultLength.Scroll += new System.EventHandler(this.trbDefaultLength_Scroll);
            // 
            // chkUnlockKeyGen
            // 
            this.chkUnlockKeyGen.AutoSize = true;
            this.chkUnlockKeyGen.Location = new System.Drawing.Point(161, 399);
            this.chkUnlockKeyGen.Name = "chkUnlockKeyGen";
            this.chkUnlockKeyGen.Size = new System.Drawing.Size(141, 17);
            this.chkUnlockKeyGen.TabIndex = 7;
            this.chkUnlockKeyGen.Text = "Unlock Key Modification";
            this.chkUnlockKeyGen.UseVisualStyleBackColor = true;
            this.chkUnlockKeyGen.CheckedChanged += new System.EventHandler(this.chkUnlockKeyGen_CheckedChanged);
            // 
            // chkTurnOffBalloon
            // 
            this.chkTurnOffBalloon.AutoSize = true;
            this.chkTurnOffBalloon.Checked = global::PassGen.Properties.Settings.Default.TurnOffBalloon;
            this.chkTurnOffBalloon.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PassGen.Properties.Settings.Default, "TurnOffBalloon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTurnOffBalloon.Location = new System.Drawing.Point(15, 399);
            this.chkTurnOffBalloon.Name = "chkTurnOffBalloon";
            this.chkTurnOffBalloon.Size = new System.Drawing.Size(138, 17);
            this.chkTurnOffBalloon.TabIndex = 17;
            this.chkTurnOffBalloon.Text = "Turn off start up balloon";
            this.chkTurnOffBalloon.UseVisualStyleBackColor = true;
            this.chkTurnOffBalloon.CheckedChanged += new System.EventHandler(this.chkTurnOffBalloon_CheckedChanged);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 426);
            this.Controls.Add(this.chkTurnOffBalloon);
            this.Controls.Add(this.chkUnlockKeyGen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSaveConfig);
            this.Controls.Add(this.btnGenerateSeed);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pascii Configuration";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDefaultLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtSaveConfig;
        private System.Windows.Forms.Button btnGenerateSeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassChars;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForceSpecial;
        private System.Windows.Forms.CheckBox chkForceSpecial;
        private System.Windows.Forms.CheckBox chkIncludedSpecials;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trbDefaultLength;
        private System.Windows.Forms.CheckBox chkUnlockKeyGen;
        private System.Windows.Forms.CheckBox chkTurnOffBalloon;
        private System.Windows.Forms.CheckBox chkNonCaseSensative;
    }
}