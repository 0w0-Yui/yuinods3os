/*
 * Dark Souls 3 - Open Server
 * Copyright (C) 2021 Tim Leonard
 *
 * This program is free software; licensed under the MIT license. 
 * You should have received a copy of the license along with this program. 
 * If not, see <https://opensource.org/licenses/MIT>.
 */

namespace Loader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "Name", "Players", "Description" }, 0);
            ImportButton = new System.Windows.Forms.Button();
            serverListImageList = new System.Windows.Forms.ImageList(components);
            LaunchButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ExeLocationTextBox = new System.Windows.Forms.TextBox();
            ExeLocationBrowseButton = new System.Windows.Forms.Button();
            ImportedServerListView = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            BuildInfoLabel = new System.Windows.Forms.Label();
            ContinualUpdateTimer = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            DiscordLink = new System.Windows.Forms.LinkLabel();
            GithubLink = new System.Windows.Forms.LinkLabel();
            RemoveButton = new System.Windows.Forms.Button();
            serverListRefreshTimer = new System.Windows.Forms.Timer(components);
            RefreshButton = new System.Windows.Forms.Button();
            minimumPlayersBox = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            hidePasswordedBox = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            privateIpBox = new System.Windows.Forms.Label();
            publicIpBox = new System.Windows.Forms.Label();
            serverIpBox = new System.Windows.Forms.Label();
            filterBox = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            SettingsButton = new System.Windows.Forms.Button();
            PingButton = new System.Windows.Forms.Button();
            OldStartModeBox = new System.Windows.Forms.CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimumPlayersBox).BeginInit();
            SuspendLayout();
            // 
            // ImportButton
            // 
            ImportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            ImportButton.ImageIndex = 3;
            ImportButton.ImageList = serverListImageList;
            ImportButton.Location = new System.Drawing.Point(8, 414);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new System.Drawing.Size(122, 35);
            ImportButton.TabIndex = 1;
            ImportButton.Text = "导入服务器";
            ImportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            ImportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += OnImportServerConfig;
            // 
            // serverListImageList
            // 
            serverListImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            serverListImageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("serverListImageList.ImageStream");
            serverListImageList.TransparentColor = System.Drawing.Color.Transparent;
            serverListImageList.Images.SetKeyName(0, "lock.png");
            serverListImageList.Images.SetKeyName(1, "arrow_refresh.png");
            serverListImageList.Images.SetKeyName(2, "cross.png");
            serverListImageList.Images.SetKeyName(3, "add.png");
            serverListImageList.Images.SetKeyName(4, "joystick.png");
            serverListImageList.Images.SetKeyName(5, "magnifier.png");
            serverListImageList.Images.SetKeyName(6, "bullet_star.png");
            serverListImageList.Images.SetKeyName(7, "star.png");
            serverListImageList.Images.SetKeyName(8, "world.png");
            serverListImageList.Images.SetKeyName(9, "folder_magnify.png");
            serverListImageList.Images.SetKeyName(10, "award_star_gold_2.png");
            serverListImageList.Images.SetKeyName(11, "cog.png");
            // 
            // LaunchButton
            // 
            LaunchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            LaunchButton.ImageIndex = 4;
            LaunchButton.ImageList = serverListImageList;
            LaunchButton.Location = new System.Drawing.Point(780, 414);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new System.Drawing.Size(145, 35);
            LaunchButton.TabIndex = 2;
            LaunchButton.Text = "启动游戏";
            LaunchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            LaunchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            LaunchButton.UseVisualStyleBackColor = true;
            LaunchButton.Click += OnLaunch;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label2.Location = new System.Drawing.Point(8, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(146, 15);
            label2.TabIndex = 4;
            label2.Text = "黑魂3游戏执行文件路径:";
            // 
            // ExeLocationTextBox
            // 
            ExeLocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ExeLocationTextBox.Location = new System.Drawing.Point(8, 138);
            ExeLocationTextBox.Name = "ExeLocationTextBox";
            ExeLocationTextBox.ReadOnly = true;
            ExeLocationTextBox.Size = new System.Drawing.Size(868, 23);
            ExeLocationTextBox.TabIndex = 5;
            // 
            // ExeLocationBrowseButton
            // 
            ExeLocationBrowseButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ExeLocationBrowseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            ExeLocationBrowseButton.ImageIndex = 9;
            ExeLocationBrowseButton.ImageList = serverListImageList;
            ExeLocationBrowseButton.Location = new System.Drawing.Point(883, 137);
            ExeLocationBrowseButton.Name = "ExeLocationBrowseButton";
            ExeLocationBrowseButton.Size = new System.Drawing.Size(42, 25);
            ExeLocationBrowseButton.TabIndex = 6;
            ExeLocationBrowseButton.UseVisualStyleBackColor = true;
            ExeLocationBrowseButton.Click += OnBrowseForExecutable;
            // 
            // ImportedServerListView
            // 
            ImportedServerListView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ImportedServerListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ImportedServerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader4, columnHeader2, columnHeader3 });
            ImportedServerListView.FullRowSelect = true;
            ImportedServerListView.GridLines = true;
            ImportedServerListView.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            ImportedServerListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            ImportedServerListView.Location = new System.Drawing.Point(8, 199);
            ImportedServerListView.MultiSelect = false;
            ImportedServerListView.Name = "ImportedServerListView";
            ImportedServerListView.Size = new System.Drawing.Size(917, 209);
            ImportedServerListView.SmallImageList = serverListImageList;
            ImportedServerListView.Sorting = System.Windows.Forms.SortOrder.Descending;
            ImportedServerListView.TabIndex = 7;
            ImportedServerListView.UseCompatibleStateImageBehavior = false;
            ImportedServerListView.View = System.Windows.Forms.View.Details;
            ImportedServerListView.ColumnClick += OnColumnClicked;
            ImportedServerListView.SelectedIndexChanged += OnSelectedServerChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "服务器名";
            columnHeader1.Width = 250;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "玩家数";
            columnHeader4.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "服务器备注";
            columnHeader2.Width = 500;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "延迟";
            // 
            // BuildInfoLabel
            // 
            BuildInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            BuildInfoLabel.Location = new System.Drawing.Point(152, 115);
            BuildInfoLabel.Name = "BuildInfoLabel";
            BuildInfoLabel.Size = new System.Drawing.Size(724, 20);
            BuildInfoLabel.TabIndex = 8;
            BuildInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ContinualUpdateTimer
            // 
            ContinualUpdateTimer.Interval = 5000;
            ContinualUpdateTimer.Tick += OnContinualUpdateTimer;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.Black;
            panel1.BackgroundImage = Properties.Resources.banner1;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel1.Controls.Add(DiscordLink);
            panel1.Controls.Add(GithubLink);
            panel1.Location = new System.Drawing.Point(-2, -2);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(5);
            panel1.Size = new System.Drawing.Size(943, 113);
            panel1.TabIndex = 10;
            // 
            // DiscordLink
            // 
            DiscordLink.ActiveLinkColor = System.Drawing.Color.White;
            DiscordLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            DiscordLink.AutoSize = true;
            DiscordLink.BackColor = System.Drawing.Color.Transparent;
            DiscordLink.Cursor = System.Windows.Forms.Cursors.Hand;
            DiscordLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DiscordLink.ForeColor = System.Drawing.Color.White;
            DiscordLink.LinkColor = System.Drawing.Color.White;
            DiscordLink.Location = new System.Drawing.Point(164, 74);
            DiscordLink.Name = "DiscordLink";
            DiscordLink.Size = new System.Drawing.Size(191, 21);
            DiscordLink.TabIndex = 13;
            DiscordLink.TabStop = true;
            DiscordLink.Text = "作者：0w0-Yui, Sino Ling";
            DiscordLink.VisitedLinkColor = System.Drawing.Color.Gray;
            DiscordLink.LinkClicked += OnClickDiscordLink;
            // 
            // GithubLink
            // 
            GithubLink.ActiveLinkColor = System.Drawing.Color.White;
            GithubLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            GithubLink.AutoSize = true;
            GithubLink.BackColor = System.Drawing.Color.Transparent;
            GithubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            GithubLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            GithubLink.ForeColor = System.Drawing.Color.White;
            GithubLink.LinkColor = System.Drawing.Color.White;
            GithubLink.Location = new System.Drawing.Point(65, 74);
            GithubLink.Name = "GithubLink";
            GithubLink.Size = new System.Drawing.Size(78, 21);
            GithubLink.TabIndex = 12;
            GithubLink.TabStop = true;
            GithubLink.Text = "程序源码";
            GithubLink.VisitedLinkColor = System.Drawing.Color.Gray;
            GithubLink.LinkClicked += OnClickGithubLink;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            RemoveButton.ImageIndex = 2;
            RemoveButton.ImageList = serverListImageList;
            RemoveButton.Location = new System.Drawing.Point(136, 414);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new System.Drawing.Size(37, 35);
            RemoveButton.TabIndex = 9;
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += OnRemoveClicked;
            // 
            // serverListRefreshTimer
            // 
            serverListRefreshTimer.Enabled = true;
            serverListRefreshTimer.Interval = 30000;
            serverListRefreshTimer.Tick += OnServerRefreshTimer;
            // 
            // RefreshButton
            // 
            RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            RefreshButton.ImageIndex = 1;
            RefreshButton.ImageList = serverListImageList;
            RefreshButton.Location = new System.Drawing.Point(180, 414);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new System.Drawing.Size(37, 35);
            RefreshButton.TabIndex = 11;
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += OnRefreshClicked;
            // 
            // minimumPlayersBox
            // 
            minimumPlayersBox.Location = new System.Drawing.Point(131, 169);
            minimumPlayersBox.Name = "minimumPlayersBox";
            minimumPlayersBox.Size = new System.Drawing.Size(53, 23);
            minimumPlayersBox.TabIndex = 12;
            minimumPlayersBox.Visible = false;
            minimumPlayersBox.ValueChanged += OnFilterPropertyChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(190, 173);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 13;
            label1.Text = "最小玩家数";
            label1.Visible = false;
            // 
            // hidePasswordedBox
            // 
            hidePasswordedBox.AutoSize = true;
            hidePasswordedBox.Location = new System.Drawing.Point(8, 172);
            hidePasswordedBox.Name = "hidePasswordedBox";
            hidePasswordedBox.Size = new System.Drawing.Size(78, 19);
            hidePasswordedBox.TabIndex = 14;
            hidePasswordedBox.Text = "隐藏密码";
            hidePasswordedBox.UseVisualStyleBackColor = true;
            hidePasswordedBox.CheckedChanged += OnFilterPropertyChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label3.Location = new System.Drawing.Point(309, 424);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 20);
            label3.TabIndex = 15;
            label3.Text = "Server IP";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label4.Location = new System.Drawing.Point(466, 424);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 17;
            label4.Text = "Private IP";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label5.Location = new System.Drawing.Point(623, 424);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 20);
            label5.TabIndex = 19;
            label5.Text = "Public IP";
            // 
            // privateIpBox
            // 
            privateIpBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            privateIpBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            privateIpBox.Location = new System.Drawing.Point(527, 424);
            privateIpBox.Name = "privateIpBox";
            privateIpBox.Size = new System.Drawing.Size(90, 20);
            privateIpBox.TabIndex = 21;
            privateIpBox.Text = "255.255.255.255";
            // 
            // publicIpBox
            // 
            publicIpBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            publicIpBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            publicIpBox.Location = new System.Drawing.Point(684, 424);
            publicIpBox.Name = "publicIpBox";
            publicIpBox.Size = new System.Drawing.Size(90, 20);
            publicIpBox.TabIndex = 22;
            publicIpBox.Text = "255.255.255.255";
            // 
            // serverIpBox
            // 
            serverIpBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            serverIpBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            serverIpBox.Location = new System.Drawing.Point(370, 424);
            serverIpBox.Name = "serverIpBox";
            serverIpBox.Size = new System.Drawing.Size(90, 20);
            serverIpBox.TabIndex = 23;
            serverIpBox.Text = "255.255.255.255";
            // 
            // filterBox
            // 
            filterBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            filterBox.Location = new System.Drawing.Point(549, 168);
            filterBox.Name = "filterBox";
            filterBox.Size = new System.Drawing.Size(376, 23);
            filterBox.TabIndex = 24;
            filterBox.TextChanged += OnFilterPropertyChanged;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.magnifier;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel2.Location = new System.Drawing.Point(520, 168);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(23, 23);
            panel2.TabIndex = 25;
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            SettingsButton.ImageIndex = 11;
            SettingsButton.ImageList = serverListImageList;
            SettingsButton.Location = new System.Drawing.Point(266, 414);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new System.Drawing.Size(37, 35);
            SettingsButton.TabIndex = 26;
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // PingButton
            // 
            PingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            PingButton.Image = (System.Drawing.Image)resources.GetObject("PingButton.Image");
            PingButton.Location = new System.Drawing.Point(223, 414);
            PingButton.Name = "PingButton";
            PingButton.Size = new System.Drawing.Size(37, 35);
            PingButton.TabIndex = 27;
            PingButton.UseVisualStyleBackColor = true;
            PingButton.Click += OnPingClicked;
            // 
            // OldStartModeBox
            // 
            OldStartModeBox.AutoSize = true;
            OldStartModeBox.Location = new System.Drawing.Point(300, 172);
            OldStartModeBox.Name = "OldStartModeBox";
            OldStartModeBox.Size = new System.Drawing.Size(208, 19);
            OldStartModeBox.TabIndex = 28;
            OldStartModeBox.Text = "兼容模式（联机失败尝试此项）";
            OldStartModeBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(942, 459);
            Controls.Add(OldStartModeBox);
            Controls.Add(PingButton);
            Controls.Add(SettingsButton);
            Controls.Add(panel2);
            Controls.Add(filterBox);
            Controls.Add(serverIpBox);
            Controls.Add(publicIpBox);
            Controls.Add(privateIpBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(hidePasswordedBox);
            Controls.Add(label1);
            Controls.Add(minimumPlayersBox);
            Controls.Add(RefreshButton);
            Controls.Add(panel1);
            Controls.Add(RemoveButton);
            Controls.Add(BuildInfoLabel);
            Controls.Add(ImportedServerListView);
            Controls.Add(ExeLocationBrowseButton);
            Controls.Add(ExeLocationTextBox);
            Controls.Add(label2);
            Controls.Add(LaunchButton);
            Controls.Add(ImportButton);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(950, 490);
            Name = "MainForm";
            Text = "黑魂III - Lioat启动器";
            Load += OnLoaded;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimumPlayersBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExeLocationTextBox;
        private System.Windows.Forms.Button ExeLocationBrowseButton;
        private System.Windows.Forms.ListView ImportedServerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label BuildInfoLabel;
        private System.Windows.Forms.Timer ContinualUpdateTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Timer serverListRefreshTimer;
        private System.Windows.Forms.ImageList serverListImageList;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.NumericUpDown minimumPlayersBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hidePasswordedBox;
        private System.Windows.Forms.LinkLabel DiscordLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label privateIpBox;
        private System.Windows.Forms.Label publicIpBox;
        private System.Windows.Forms.Label serverIpBox;
        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.CheckBox OldStartModeBox;
    }
}

