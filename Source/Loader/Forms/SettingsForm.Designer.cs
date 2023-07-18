namespace Loader
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            UseSeperateSavesCheckbox = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            CopySavesButton = new System.Windows.Forms.Button();
            RestoreSteamButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            Steam64IDText = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            GameLanguageText = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SteamUserNameText = new System.Windows.Forms.TextBox();
            SaveGoldBergSettingButton = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // UseSeperateSavesCheckbox
            // 
            UseSeperateSavesCheckbox.AutoSize = true;
            UseSeperateSavesCheckbox.Location = new System.Drawing.Point(26, 27);
            UseSeperateSavesCheckbox.Name = "UseSeperateSavesCheckbox";
            UseSeperateSavesCheckbox.Size = new System.Drawing.Size(147, 19);
            UseSeperateSavesCheckbox.TabIndex = 0;
            UseSeperateSavesCheckbox.Text = "Use seperate save files?";
            UseSeperateSavesCheckbox.UseVisualStyleBackColor = true;
            UseSeperateSavesCheckbox.CheckedChanged += SettingChanged;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(45, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(448, 97);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // CopySavesButton
            // 
            CopySavesButton.Location = new System.Drawing.Point(320, 149);
            CopySavesButton.Name = "CopySavesButton";
            CopySavesButton.Size = new System.Drawing.Size(173, 40);
            CopySavesButton.TabIndex = 2;
            CopySavesButton.Text = "Copy Retail Saves to DS3OS";
            CopySavesButton.UseVisualStyleBackColor = true;
            CopySavesButton.Click += CopySavesClicked;
            // 
            // RestoreSteamButton
            // 
            RestoreSteamButton.Location = new System.Drawing.Point(141, 385);
            RestoreSteamButton.Name = "RestoreSteamButton";
            RestoreSteamButton.Size = new System.Drawing.Size(173, 48);
            RestoreSteamButton.TabIndex = 3;
            RestoreSteamButton.Text = "重置程序/修复正版魂三";
            RestoreSteamButton.UseVisualStyleBackColor = true;
            RestoreSteamButton.Click += RestoreSteamButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Steam64IDText);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(GameLanguageText);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(SteamUserNameText);
            groupBox1.ForeColor = System.Drawing.Color.Red;
            groupBox1.Location = new System.Drawing.Point(26, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(467, 184);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "第一次启动必填！";
            // 
            // Steam64IDText
            // 
            Steam64IDText.Location = new System.Drawing.Point(104, 137);
            Steam64IDText.Name = "Steam64IDText";
            Steam64IDText.Size = new System.Drawing.Size(357, 23);
            Steam64IDText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(19, 140);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 15);
            label4.TabIndex = 4;
            label4.Text = "Steam64位ID";
            // 
            // GameLanguageText
            // 
            GameLanguageText.Location = new System.Drawing.Point(104, 90);
            GameLanguageText.Name = "GameLanguageText";
            GameLanguageText.Size = new System.Drawing.Size(357, 23);
            GameLanguageText.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(19, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "游戏语言";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(19, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Steam用户名";
            // 
            // SteamUserNameText
            // 
            SteamUserNameText.Location = new System.Drawing.Point(104, 37);
            SteamUserNameText.Name = "SteamUserNameText";
            SteamUserNameText.Size = new System.Drawing.Size(357, 23);
            SteamUserNameText.TabIndex = 0;
            // 
            // SaveGoldBergSettingButton
            // 
            SaveGoldBergSettingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            SaveGoldBergSettingButton.Location = new System.Drawing.Point(320, 385);
            SaveGoldBergSettingButton.Name = "SaveGoldBergSettingButton";
            SaveGoldBergSettingButton.Size = new System.Drawing.Size(173, 48);
            SaveGoldBergSettingButton.TabIndex = 6;
            SaveGoldBergSettingButton.Text = "保存设置";
            SaveGoldBergSettingButton.UseVisualStyleBackColor = true;
            SaveGoldBergSettingButton.Click += SaveGoldBergSettingButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(528, 445);
            ControlBox = false;
            Controls.Add(SaveGoldBergSettingButton);
            Controls.Add(groupBox1);
            Controls.Add(RestoreSteamButton);
            Controls.Add(CopySavesButton);
            Controls.Add(label1);
            Controls.Add(UseSeperateSavesCheckbox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "SettingsForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Settings";
            TopMost = true;
            Load += OnLoad;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox UseSeperateSavesCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CopySavesButton;
        private System.Windows.Forms.Button RestoreSteamButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SteamUserNameText;
        private System.Windows.Forms.Button SaveGoldBergSettingButton;
        private System.Windows.Forms.TextBox Steam64IDText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GameLanguageText;
        private System.Windows.Forms.Label label3;
    }
}