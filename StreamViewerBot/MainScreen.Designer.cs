﻿namespace StreamViewerBot
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.startStopButton = new System.Windows.Forms.PictureBox();
            this.txtStreamUrl = new System.Windows.Forms.TextBox();
            this.lblStreamUrl = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.checkHeadless = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtProxyList = new System.Windows.Forms.TextBox();
            this.browseProxyList = new System.Windows.Forms.Button();
            this.logScreen = new System.Windows.Forms.TextBox();
            this.lblBrowserLimit = new System.Windows.Forms.Label();
            this.txtBrowserLimit = new System.Windows.Forms.TextBox();
            this.picVulture = new System.Windows.Forms.PictureBox();
            this.numRefreshMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblRefreshMin = new System.Windows.Forms.Label();
            this.tipLimitInfo = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tipRefreshBrowser = new System.Windows.Forms.PictureBox();
            this.lblProxyList = new System.Windows.Forms.LinkLabel();
            this.lblRefreshMin2 = new System.Windows.Forms.Label();
            this.lblRefreshMin3 = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lstQuality = new System.Windows.Forms.ComboBox();
            this.tipQuality = new System.Windows.Forms.PictureBox();
            this.txtLoginInfos = new System.Windows.Forms.TextBox();
            this.btnWithLoggedIn = new System.Windows.Forms.PictureBox();
            this.lblLoginInfoTitle = new System.Windows.Forms.Label();
            this.lblHeadless = new System.Windows.Forms.Label();
            this.picLiveViewer = new System.Windows.Forms.PictureBox();
            this.lblViewer = new System.Windows.Forms.Label();
            this.picBotViewer = new System.Windows.Forms.PictureBox();
            this.lblLiveViewer = new System.Windows.Forms.Label();
            this.tipLiveViewer = new System.Windows.Forms.PictureBox();
            this.lnlResourceSaving = new System.Windows.Forms.Label();
            this.checkLowCpuRam = new System.Windows.Forms.CheckBox();
            this.lblNeedCloudServer = new System.Windows.Forms.Label();
            this.picWebshare = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstserviceType = new System.Windows.Forms.ComboBox();
            this.browseChatMessages = new System.Windows.Forms.Button();
            this.lblChatMessages = new System.Windows.Forms.Label();
            this.txtChatMessages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.browseUserAgentList = new System.Windows.Forms.Button();
            this.txtUserAgentList = new System.Windows.Forms.TextBox();
            this.lblUserAgentList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startStopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVulture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipLimitInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipRefreshBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWithLoggedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipLiveViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebshare)).BeginInit();
            this.SuspendLayout();
            // 
            // startStopButton
            // 
            this.startStopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startStopButton.BackgroundImage")));
            this.startStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startStopButton.Location = new System.Drawing.Point(404, 249);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(71, 32);
            this.startStopButton.TabIndex = 0;
            this.startStopButton.TabStop = false;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // txtStreamUrl
            // 
            this.txtStreamUrl.Location = new System.Drawing.Point(83, 292);
            this.txtStreamUrl.Name = "txtStreamUrl";
            this.txtStreamUrl.Size = new System.Drawing.Size(306, 23);
            this.txtStreamUrl.TabIndex = 1;
            // 
            // lblStreamUrl
            // 
            this.lblStreamUrl.AutoSize = true;
            this.lblStreamUrl.Location = new System.Drawing.Point(12, 295);
            this.lblStreamUrl.Name = "lblStreamUrl";
            this.lblStreamUrl.Size = new System.Drawing.Size(65, 15);
            this.lblStreamUrl.TabIndex = 2;
            this.lblStreamUrl.Text = "Stream Url:";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.White;
            this.lblLog.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblLog.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblLog.Location = new System.Drawing.Point(410, 15);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(45, 15);
            this.lblLog.TabIndex = 4;
            this.lblLog.Text = "Logger";
            // 
            // checkHeadless
            // 
            this.checkHeadless.AutoSize = true;
            this.checkHeadless.Location = new System.Drawing.Point(142, 198);
            this.checkHeadless.Name = "checkHeadless";
            this.checkHeadless.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkHeadless.Size = new System.Drawing.Size(15, 14);
            this.checkHeadless.TabIndex = 5;
            this.checkHeadless.UseVisualStyleBackColor = true;
            this.checkHeadless.CheckedChanged += new System.EventHandler(this.checkHeadless_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtProxyList
            // 
            this.txtProxyList.Location = new System.Drawing.Point(123, 238);
            this.txtProxyList.Name = "txtProxyList";
            this.txtProxyList.Size = new System.Drawing.Size(266, 23);
            this.txtProxyList.TabIndex = 7;
            // 
            // browseProxyList
            // 
            this.browseProxyList.Location = new System.Drawing.Point(81, 238);
            this.browseProxyList.Name = "browseProxyList";
            this.browseProxyList.Size = new System.Drawing.Size(34, 23);
            this.browseProxyList.TabIndex = 8;
            this.browseProxyList.Text = "...";
            this.browseProxyList.UseVisualStyleBackColor = true;
            this.browseProxyList.Click += new System.EventHandler(this.browseProxyList_Click);
            // 
            // logScreen
            // 
            this.logScreen.Location = new System.Drawing.Point(9, 12);
            this.logScreen.Multiline = true;
            this.logScreen.Name = "logScreen";
            this.logScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logScreen.Size = new System.Drawing.Size(467, 137);
            this.logScreen.TabIndex = 10;
            // 
            // lblBrowserLimit
            // 
            this.lblBrowserLimit.AutoSize = true;
            this.lblBrowserLimit.Location = new System.Drawing.Point(12, 162);
            this.lblBrowserLimit.Name = "lblBrowserLimit";
            this.lblBrowserLimit.Size = new System.Drawing.Size(85, 15);
            this.lblBrowserLimit.TabIndex = 11;
            this.lblBrowserLimit.Text = "Browser Limit :";
            this.lblBrowserLimit.Visible = false;
            // 
            // txtBrowserLimit
            // 
            this.txtBrowserLimit.Enabled = false;
            this.txtBrowserLimit.Location = new System.Drawing.Point(100, 157);
            this.txtBrowserLimit.Name = "txtBrowserLimit";
            this.txtBrowserLimit.PlaceholderText = "0";
            this.txtBrowserLimit.Size = new System.Drawing.Size(40, 23);
            this.txtBrowserLimit.TabIndex = 12;
            this.txtBrowserLimit.Visible = false;
            this.txtBrowserLimit.TextChanged += new System.EventHandler(this.txtBrowserLimit_TextChanged);
            // 
            // picVulture
            // 
            this.picVulture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVulture.BackgroundImage")));
            this.picVulture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picVulture.Location = new System.Drawing.Point(207, 337);
            this.picVulture.Name = "picVulture";
            this.picVulture.Size = new System.Drawing.Size(160, 39);
            this.picVulture.TabIndex = 13;
            this.picVulture.TabStop = false;
            this.picVulture.Click += new System.EventHandler(this.pictureBox2_Click);
            this.picVulture.MouseEnter += new System.EventHandler(this.picVulture_MouseEnter);
            this.picVulture.MouseLeave += new System.EventHandler(this.picVulture_MouseLeave);
            // 
            // numRefreshMinutes
            // 
            this.numRefreshMinutes.Location = new System.Drawing.Point(265, 160);
            this.numRefreshMinutes.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numRefreshMinutes.Name = "numRefreshMinutes";
            this.numRefreshMinutes.Size = new System.Drawing.Size(64, 23);
            this.numRefreshMinutes.TabIndex = 14;
            this.numRefreshMinutes.Tag = "Refresh Browsers (Min.)";
            this.numRefreshMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblRefreshMin
            // 
            this.lblRefreshMin.AutoSize = true;
            this.lblRefreshMin.Location = new System.Drawing.Point(183, 171);
            this.lblRefreshMin.Name = "lblRefreshMin";
            this.lblRefreshMin.Size = new System.Drawing.Size(53, 15);
            this.lblRefreshMin.TabIndex = 15;
            this.lblRefreshMin.Text = "(Minute)";
            // 
            // tipLimitInfo
            // 
            this.tipLimitInfo.BackgroundImage = global::StreamViewerBot.Properties.Resources.info;
            this.tipLimitInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tipLimitInfo.Location = new System.Drawing.Point(142, 155);
            this.tipLimitInfo.Name = "tipLimitInfo";
            this.tipLimitInfo.Size = new System.Drawing.Size(16, 16);
            this.tipLimitInfo.TabIndex = 16;
            this.tipLimitInfo.TabStop = false;
            this.tipLimitInfo.Visible = false;
            this.tipLimitInfo.MouseHover += new System.EventHandler(this.picLimitInfo_MouseHover);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.BackColor = System.Drawing.Color.Aqua;
            this.toolTip.InitialDelay = 300;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // tipRefreshBrowser
            // 
            this.tipRefreshBrowser.BackgroundImage = global::StreamViewerBot.Properties.Resources.info;
            this.tipRefreshBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tipRefreshBrowser.Location = new System.Drawing.Point(335, 158);
            this.tipRefreshBrowser.Name = "tipRefreshBrowser";
            this.tipRefreshBrowser.Size = new System.Drawing.Size(16, 16);
            this.tipRefreshBrowser.TabIndex = 16;
            this.tipRefreshBrowser.TabStop = false;
            this.tipRefreshBrowser.MouseHover += new System.EventHandler(this.refreshInterval_MouseHover);
            // 
            // lblProxyList
            // 
            this.lblProxyList.AutoSize = true;
            this.lblProxyList.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.lblProxyList.Location = new System.Drawing.Point(12, 243);
            this.lblProxyList.Name = "lblProxyList";
            this.lblProxyList.Size = new System.Drawing.Size(61, 15);
            this.lblProxyList.TabIndex = 17;
            this.lblProxyList.TabStop = true;
            this.lblProxyList.Text = "Proxy List:";
            this.lblProxyList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProxyList_LinkClicked);
            // 
            // lblRefreshMin2
            // 
            this.lblRefreshMin2.AutoSize = true;
            this.lblRefreshMin2.Location = new System.Drawing.Point(164, 157);
            this.lblRefreshMin2.Name = "lblRefreshMin2";
            this.lblRefreshMin2.Size = new System.Drawing.Size(88, 15);
            this.lblRefreshMin2.TabIndex = 15;
            this.lblRefreshMin2.Text = "Refresh Interval";
            // 
            // lblRefreshMin3
            // 
            this.lblRefreshMin3.AutoSize = true;
            this.lblRefreshMin3.Location = new System.Drawing.Point(251, 162);
            this.lblRefreshMin3.Name = "lblRefreshMin3";
            this.lblRefreshMin3.Size = new System.Drawing.Size(10, 15);
            this.lblRefreshMin3.TabIndex = 15;
            this.lblRefreshMin3.Text = ":";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(187, 197);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(72, 15);
            this.lblQuality.TabIndex = 19;
            this.lblQuality.Text = "Quality        :";
            // 
            // lstQuality
            // 
            this.lstQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstQuality.Location = new System.Drawing.Point(265, 193);
            this.lstQuality.Name = "lstQuality";
            this.lstQuality.Size = new System.Drawing.Size(64, 23);
            this.lstQuality.TabIndex = 20;
            this.lstQuality.SelectedIndexChanged += new System.EventHandler(this.lstQuality_SelectedIndexChanged);
            // 
            // tipQuality
            // 
            this.tipQuality.BackgroundImage = global::StreamViewerBot.Properties.Resources.info;
            this.tipQuality.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tipQuality.Location = new System.Drawing.Point(335, 191);
            this.tipQuality.Name = "tipQuality";
            this.tipQuality.Size = new System.Drawing.Size(16, 16);
            this.tipQuality.TabIndex = 16;
            this.tipQuality.TabStop = false;
            this.tipQuality.MouseHover += new System.EventHandler(this.streamQuality_MouseHover);
            // 
            // txtLoginInfos
            // 
            this.txtLoginInfos.Location = new System.Drawing.Point(520, 26);
            this.txtLoginInfos.Multiline = true;
            this.txtLoginInfos.Name = "txtLoginInfos";
            this.txtLoginInfos.PlaceholderText = "Format is =>Username{Blank}Password{Enter}";
            this.txtLoginInfos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLoginInfos.Size = new System.Drawing.Size(288, 308);
            this.txtLoginInfos.TabIndex = 21;
            this.txtLoginInfos.WordWrap = false;
            // 
            // btnWithLoggedIn
            // 
            this.btnWithLoggedIn.BackgroundImage = global::StreamViewerBot.Properties.Resources.withLoggedInUsers1;
            this.btnWithLoggedIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWithLoggedIn.Location = new System.Drawing.Point(485, 109);
            this.btnWithLoggedIn.Name = "btnWithLoggedIn";
            this.btnWithLoggedIn.Size = new System.Drawing.Size(29, 144);
            this.btnWithLoggedIn.TabIndex = 22;
            this.btnWithLoggedIn.TabStop = false;
            this.btnWithLoggedIn.Click += new System.EventHandler(this.btnWithLoggedIn_Click);
            // 
            // lblLoginInfoTitle
            // 
            this.lblLoginInfoTitle.AutoSize = true;
            this.lblLoginInfoTitle.Location = new System.Drawing.Point(522, 9);
            this.lblLoginInfoTitle.Name = "lblLoginInfoTitle";
            this.lblLoginInfoTitle.Size = new System.Drawing.Size(279, 15);
            this.lblLoginInfoTitle.TabIndex = 23;
            this.lblLoginInfoTitle.Text = "Login Credentials (Required for Facebook and Bigo)";
            // 
            // lblHeadless
            // 
            this.lblHeadless.AutoSize = true;
            this.lblHeadless.Location = new System.Drawing.Point(11, 197);
            this.lblHeadless.Name = "lblHeadless";
            this.lblHeadless.Size = new System.Drawing.Size(126, 15);
            this.lblHeadless.TabIndex = 24;
            this.lblHeadless.Text = "Headless                       :";
            // 
            // picLiveViewer
            // 
            this.picLiveViewer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLiveViewer.BackgroundImage")));
            this.picLiveViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLiveViewer.Location = new System.Drawing.Point(425, 157);
            this.picLiveViewer.Name = "picLiveViewer";
            this.picLiveViewer.Size = new System.Drawing.Size(28, 26);
            this.picLiveViewer.TabIndex = 25;
            this.picLiveViewer.TabStop = false;
            // 
            // lblViewer
            // 
            this.lblViewer.Location = new System.Drawing.Point(376, 186);
            this.lblViewer.MaximumSize = new System.Drawing.Size(50, 13);
            this.lblViewer.Name = "lblViewer";
            this.lblViewer.Size = new System.Drawing.Size(32, 13);
            this.lblViewer.TabIndex = 26;
            this.lblViewer.Text = "0";
            this.lblViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBotViewer
            // 
            this.picBotViewer.BackgroundImage = global::StreamViewerBot.Properties.Resources.bot;
            this.picBotViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBotViewer.Location = new System.Drawing.Point(376, 157);
            this.picBotViewer.Name = "picBotViewer";
            this.picBotViewer.Size = new System.Drawing.Size(32, 26);
            this.picBotViewer.TabIndex = 27;
            this.picBotViewer.TabStop = false;
            // 
            // lblLiveViewer
            // 
            this.lblLiveViewer.Location = new System.Drawing.Point(414, 186);
            this.lblLiveViewer.MaximumSize = new System.Drawing.Size(50, 13);
            this.lblLiveViewer.Name = "lblLiveViewer";
            this.lblLiveViewer.Size = new System.Drawing.Size(50, 13);
            this.lblLiveViewer.TabIndex = 28;
            this.lblLiveViewer.Text = "0";
            this.lblLiveViewer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipLiveViewer
            // 
            this.tipLiveViewer.BackgroundImage = global::StreamViewerBot.Properties.Resources.info;
            this.tipLiveViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tipLiveViewer.Location = new System.Drawing.Point(459, 155);
            this.tipLiveViewer.Name = "tipLiveViewer";
            this.tipLiveViewer.Size = new System.Drawing.Size(16, 16);
            this.tipLiveViewer.TabIndex = 29;
            this.tipLiveViewer.TabStop = false;
            this.tipLiveViewer.MouseHover += new System.EventHandler(this.tipLiveViewer_MouseHover);
            // 
            // lnlResourceSaving
            // 
            this.lnlResourceSaving.AutoSize = true;
            this.lnlResourceSaving.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnlResourceSaving.Location = new System.Drawing.Point(12, 217);
            this.lnlResourceSaving.Name = "lnlResourceSaving";
            this.lnlResourceSaving.Size = new System.Drawing.Size(125, 15);
            this.lnlResourceSaving.TabIndex = 30;
            this.lnlResourceSaving.Text = "Use Low CPU&&RAM   :";
            this.lnlResourceSaving.Visible = false;
            // 
            // checkLowCpuRam
            // 
            this.checkLowCpuRam.AutoSize = true;
            this.checkLowCpuRam.Location = new System.Drawing.Point(143, 217);
            this.checkLowCpuRam.Name = "checkLowCpuRam";
            this.checkLowCpuRam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkLowCpuRam.Size = new System.Drawing.Size(15, 14);
            this.checkLowCpuRam.TabIndex = 31;
            this.checkLowCpuRam.UseVisualStyleBackColor = true;
            this.checkLowCpuRam.Visible = false;
            // 
            // lblNeedCloudServer
            // 
            this.lblNeedCloudServer.AutoSize = true;
            this.lblNeedCloudServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNeedCloudServer.Location = new System.Drawing.Point(207, 319);
            this.lblNeedCloudServer.Name = "lblNeedCloudServer";
            this.lblNeedCloudServer.Size = new System.Drawing.Size(159, 15);
            this.lblNeedCloudServer.TabIndex = 0;
            this.lblNeedCloudServer.Text = "Run this app on cloud server!";
            // 
            // picWebshare
            // 
            this.picWebshare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWebshare.BackgroundImage")));
            this.picWebshare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWebshare.Location = new System.Drawing.Point(51, 337);
            this.picWebshare.Name = "picWebshare";
            this.picWebshare.Size = new System.Drawing.Size(119, 39);
            this.picWebshare.TabIndex = 32;
            this.picWebshare.TabStop = false;
            this.picWebshare.Click += new System.EventHandler(this.picWebshare_Click);
            this.picWebshare.MouseEnter += new System.EventHandler(this.picWebshare_MouseEnter);
            this.picWebshare.MouseLeave += new System.EventHandler(this.picWebshare_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Need private proxies?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Service:";
            // 
            // lstserviceType
            // 
            this.lstserviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstserviceType.Location = new System.Drawing.Point(396, 211);
            this.lstserviceType.Name = "lstserviceType";
            this.lstserviceType.Size = new System.Drawing.Size(79, 23);
            this.lstserviceType.TabIndex = 41;
            this.lstserviceType.Tag = "";
            this.lstserviceType.SelectedIndexChanged += new System.EventHandler(this.lstServiceType_SelectedIndexChanged);
            // 
            // browseChatMessages
            // 
            this.browseChatMessages.Location = new System.Drawing.Point(609, 340);
            this.browseChatMessages.Name = "browseChatMessages";
            this.browseChatMessages.Size = new System.Drawing.Size(34, 23);
            this.browseChatMessages.TabIndex = 42;
            this.browseChatMessages.Text = "...";
            this.browseChatMessages.UseVisualStyleBackColor = true;
            this.browseChatMessages.Click += new System.EventHandler(this.chatMessagesList_Click);
            // 
            // lblChatMessages
            // 
            this.lblChatMessages.AutoSize = true;
            this.lblChatMessages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChatMessages.Location = new System.Drawing.Point(517, 343);
            this.lblChatMessages.Name = "lblChatMessages";
            this.lblChatMessages.Size = new System.Drawing.Size(92, 15);
            this.lblChatMessages.TabIndex = 43;
            this.lblChatMessages.Text = "Chat Messages :";
            // 
            // txtChatMessages
            // 
            this.txtChatMessages.Location = new System.Drawing.Point(649, 340);
            this.txtChatMessages.Name = "txtChatMessages";
            this.txtChatMessages.Size = new System.Drawing.Size(159, 23);
            this.txtChatMessages.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(575, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Sends messages randomly between";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(585, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "1-10 minutes for each viewer.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = ">";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = ">";
            // 
            // browseUserAgentList
            // 
            this.browseUserAgentList.Location = new System.Drawing.Point(109, 265);
            this.browseUserAgentList.Name = "browseUserAgentList";
            this.browseUserAgentList.Size = new System.Drawing.Size(34, 23);
            this.browseUserAgentList.TabIndex = 50;
            this.browseUserAgentList.Text = "...";
            this.browseUserAgentList.UseVisualStyleBackColor = true;
            this.browseUserAgentList.Click += new System.EventHandler(this.browseUserAgentList_Click);
            // 
            // txtUserAgentList
            // 
            this.txtUserAgentList.Location = new System.Drawing.Point(151, 265);
            this.txtUserAgentList.Name = "txtUserAgentList";
            this.txtUserAgentList.Size = new System.Drawing.Size(238, 23);
            this.txtUserAgentList.TabIndex = 49;
            // 
            // lblUserAgentList
            // 
            this.lblUserAgentList.AutoSize = true;
            this.lblUserAgentList.Location = new System.Drawing.Point(12, 269);
            this.lblUserAgentList.Name = "lblUserAgentList";
            this.lblUserAgentList.Size = new System.Drawing.Size(91, 15);
            this.lblUserAgentList.TabIndex = 51;
            this.lblUserAgentList.Text = "User-Agent List:";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(813, 396);
            this.Controls.Add(this.lblUserAgentList);
            this.Controls.Add(this.browseUserAgentList);
            this.Controls.Add(this.txtUserAgentList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChatMessages);
            this.Controls.Add(this.lblChatMessages);
            this.Controls.Add(this.browseChatMessages);
            this.Controls.Add(this.checkHeadless);
            this.Controls.Add(this.lstserviceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWebshare);
            this.Controls.Add(this.lblNeedCloudServer);
            this.Controls.Add(this.checkLowCpuRam);
            this.Controls.Add(this.lnlResourceSaving);
            this.Controls.Add(this.tipLiveViewer);
            this.Controls.Add(this.lblLiveViewer);
            this.Controls.Add(this.picBotViewer);
            this.Controls.Add(this.lblViewer);
            this.Controls.Add(this.picLiveViewer);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblHeadless);
            this.Controls.Add(this.lblLoginInfoTitle);
            this.Controls.Add(this.btnWithLoggedIn);
            this.Controls.Add(this.txtLoginInfos);
            this.Controls.Add(this.tipQuality);
            this.Controls.Add(this.lstQuality);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.lblRefreshMin3);
            this.Controls.Add(this.lblRefreshMin2);
            this.Controls.Add(this.lblProxyList);
            this.Controls.Add(this.tipRefreshBrowser);
            this.Controls.Add(this.tipLimitInfo);
            this.Controls.Add(this.lblRefreshMin);
            this.Controls.Add(this.numRefreshMinutes);
            this.Controls.Add(this.picVulture);
            this.Controls.Add(this.txtBrowserLimit);
            this.Controls.Add(this.lblBrowserLimit);
            this.Controls.Add(this.browseProxyList);
            this.Controls.Add(this.txtProxyList);
            this.Controls.Add(this.lblStreamUrl);
            this.Controls.Add(this.txtStreamUrl);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.logScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(836, 435);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WE STAND WITH UKRAINE! - Stream Viewer Bot";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.Shown += new System.EventHandler(this.MainScreen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.startStopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVulture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipLimitInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipRefreshBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWithLoggedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLiveViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBotViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipLiveViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWebshare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox startStopButton;
        private System.Windows.Forms.TextBox txtStreamUrl;
        private System.Windows.Forms.Label lblStreamUrl;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.CheckBox checkHeadless;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseProxyList;
        private System.Windows.Forms.TextBox txtProxyList;
        private System.Windows.Forms.TextBox logScreen;
        private System.Windows.Forms.Label lblBrowserLimit;
        private System.Windows.Forms.TextBox txtBrowserLimit;
        private System.Windows.Forms.PictureBox picVulture;
        private System.Windows.Forms.NumericUpDown numRefreshMinutes;
        private System.Windows.Forms.Label lblRefreshMin;
        private System.Windows.Forms.PictureBox tipLimitInfo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox tipRefreshBrowser;
        private System.Windows.Forms.LinkLabel lblProxyList;
        private System.Windows.Forms.Label lblRefreshMin2;
        private System.Windows.Forms.Label lblRefreshMin3;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.ComboBox lstQuality;
        private System.Windows.Forms.PictureBox tipQuality;
        private System.Windows.Forms.TextBox txtLoginInfos;
        private System.Windows.Forms.PictureBox btnWithLoggedIn;
        private System.Windows.Forms.Label lblLoginInfoTitle;
        private System.Windows.Forms.Label lblHeadless;
        private System.Windows.Forms.PictureBox picLiveViewer;
        private System.Windows.Forms.Label lblViewer;
        private System.Windows.Forms.PictureBox picBotViewer;
        private System.Windows.Forms.Label lblLiveViewer;
        private System.Windows.Forms.PictureBox tipLiveViewer;
        private System.Windows.Forms.Label lnlResourceSaving;
        private System.Windows.Forms.CheckBox checkLowCpuRam;
        private System.Windows.Forms.Label lblNeedCloudServer;
        private System.Windows.Forms.PictureBox picWebshare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lstserviceType;
        private System.Windows.Forms.Button browseChatMessages;
        private System.Windows.Forms.Label lblChatMessages;
        private System.Windows.Forms.TextBox txtChatMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button browseUserAgentList;
        private System.Windows.Forms.TextBox txtUserAgentList;
        private System.Windows.Forms.Label lblUserAgentList;
    }
}

