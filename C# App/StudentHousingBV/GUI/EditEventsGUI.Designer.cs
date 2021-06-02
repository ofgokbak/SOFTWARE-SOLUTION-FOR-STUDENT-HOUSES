namespace StudentHousingBV.GUI
{
    partial class EditEventsGUI
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
            this.lbxEvents = new System.Windows.Forms.ListBox();
            this.btnEventsReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveAndReturn = new System.Windows.Forms.Button();
            this.rbxDescription = new System.Windows.Forms.RichTextBox();
            this.btnClearText = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbback = new System.Windows.Forms.PictureBox();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbselectdate = new System.Windows.Forms.LinkLabel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnAnouncements = new System.Windows.Forms.Button();
            this.btnComplains = new System.Windows.Forms.Button();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.btnMyTimetable = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbpenaltypoints = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltime = new System.Windows.Forms.Label();
            this.pictureex = new System.Windows.Forms.PictureBox();
            this.picturemessage = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lbback)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxEvents
            // 
            this.lbxEvents.Font = new System.Drawing.Font("Arial", 12F);
            this.lbxEvents.FormattingEnabled = true;
            this.lbxEvents.ItemHeight = 18;
            this.lbxEvents.Location = new System.Drawing.Point(239, 98);
            this.lbxEvents.Name = "lbxEvents";
            this.lbxEvents.Size = new System.Drawing.Size(433, 382);
            this.lbxEvents.TabIndex = 40;
            // 
            // btnEventsReset
            // 
            this.btnEventsReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.btnEventsReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventsReset.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnEventsReset.ForeColor = System.Drawing.Color.White;
            this.btnEventsReset.Location = new System.Drawing.Point(534, 490);
            this.btnEventsReset.Name = "btnEventsReset";
            this.btnEventsReset.Size = new System.Drawing.Size(229, 37);
            this.btnEventsReset.TabIndex = 43;
            this.btnEventsReset.Text = "Reset Changes";
            this.btnEventsReset.UseVisualStyleBackColor = false;
            this.btnEventsReset.Click += new System.EventHandler(this.btnEventsReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(684, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 37);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add Event";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(480, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 37);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete Event";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveAndReturn
            // 
            this.btnSaveAndReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.btnSaveAndReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndReturn.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveAndReturn.ForeColor = System.Drawing.Color.White;
            this.btnSaveAndReturn.Location = new System.Drawing.Point(239, 490);
            this.btnSaveAndReturn.Name = "btnSaveAndReturn";
            this.btnSaveAndReturn.Size = new System.Drawing.Size(289, 37);
            this.btnSaveAndReturn.TabIndex = 46;
            this.btnSaveAndReturn.Text = "Save and Return";
            this.btnSaveAndReturn.UseVisualStyleBackColor = false;
            this.btnSaveAndReturn.Click += new System.EventHandler(this.btnSaveAndReturn_Click);
            // 
            // rbxDescription
            // 
            this.rbxDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbxDescription.Location = new System.Drawing.Point(684, 126);
            this.rbxDescription.Name = "rbxDescription";
            this.rbxDescription.Size = new System.Drawing.Size(255, 354);
            this.rbxDescription.TabIndex = 49;
            this.rbxDescription.Text = "Type your announcement here...";
            this.rbxDescription.Click += new System.EventHandler(this.rbxDescription_Click);
            // 
            // btnClearText
            // 
            this.btnClearText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.btnClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearText.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnClearText.ForeColor = System.Drawing.Color.White;
            this.btnClearText.Location = new System.Drawing.Point(769, 490);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(170, 37);
            this.btnClearText.TabIndex = 50;
            this.btnClearText.Text = "Clear Text";
            this.btnClearText.UseVisualStyleBackColor = false;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(282, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 37);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbback
            // 
            this.lbback.Image = global::StudentHousingBV.Properties.Resources.back_35px;
            this.lbback.Location = new System.Drawing.Point(239, 50);
            this.lbback.Name = "lbback";
            this.lbback.Size = new System.Drawing.Size(37, 37);
            this.lbback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lbback.TabIndex = 54;
            this.lbback.TabStop = false;
            this.lbback.Click += new System.EventHandler(this.lbback_Click);
            // 
            // cbxTime
            // 
            this.cbxTime.BackColor = System.Drawing.SystemColors.Window;
            this.cbxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Items.AddRange(new object[] {
            "09:00-11:00",
            "11:00-13:00",
            "13:00-15:00",
            "15:00-17:00",
            "17:00-19:00",
            "19:00-21:00"});
            this.cbxTime.Location = new System.Drawing.Point(736, 98);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(203, 22);
            this.cbxTime.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(684, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 56;
            this.label1.Text = "Time:";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(699, 315);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 57;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbselectdate
            // 
            this.lbselectdate.AutoSize = true;
            this.lbselectdate.Font = new System.Drawing.Font("Arial", 12F);
            this.lbselectdate.Location = new System.Drawing.Point(839, 69);
            this.lbselectdate.Name = "lbselectdate";
            this.lbselectdate.Size = new System.Drawing.Size(100, 18);
            this.lbselectdate.TabIndex = 58;
            this.lbselectdate.TabStop = true;
            this.lbselectdate.Text = "Select a date";
            this.lbselectdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbselectdate_LinkClicked);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.panelSideMenu.Controls.Add(this.btnSettings);
            this.panelSideMenu.Controls.Add(this.btnInbox);
            this.panelSideMenu.Controls.Add(this.panel14);
            this.panelSideMenu.Controls.Add(this.btnAnouncements);
            this.panelSideMenu.Controls.Add(this.btnComplains);
            this.panelSideMenu.Controls.Add(this.lbLogout);
            this.panelSideMenu.Controls.Add(this.btnMyTimetable);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(194, 550);
            this.panelSideMenu.TabIndex = 66;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::StudentHousingBV.Properties.Resources.settings_30px;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 419);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(194, 53);
            this.btnSettings.TabIndex = 41;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInbox.FlatAppearance.BorderSize = 0;
            this.btnInbox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnInbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInbox.ForeColor = System.Drawing.Color.White;
            this.btnInbox.Image = global::StudentHousingBV.Properties.Resources.sms_32px;
            this.btnInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.Location = new System.Drawing.Point(0, 366);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(194, 53);
            this.btnInbox.TabIndex = 40;
            this.btnInbox.Text = "My Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(10, 506);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(175, 1);
            this.panel14.TabIndex = 34;
            // 
            // btnAnouncements
            // 
            this.btnAnouncements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnouncements.FlatAppearance.BorderSize = 0;
            this.btnAnouncements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnAnouncements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnAnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnouncements.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnouncements.ForeColor = System.Drawing.Color.White;
            this.btnAnouncements.Image = global::StudentHousingBV.Properties.Resources.megaphone_30px;
            this.btnAnouncements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnouncements.Location = new System.Drawing.Point(0, 313);
            this.btnAnouncements.Name = "btnAnouncements";
            this.btnAnouncements.Size = new System.Drawing.Size(194, 53);
            this.btnAnouncements.TabIndex = 38;
            this.btnAnouncements.Text = "Notifications";
            this.btnAnouncements.UseVisualStyleBackColor = true;
            this.btnAnouncements.Click += new System.EventHandler(this.btnAnouncements_Click);
            // 
            // btnComplains
            // 
            this.btnComplains.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComplains.FlatAppearance.BorderSize = 0;
            this.btnComplains.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnComplains.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnComplains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplains.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComplains.ForeColor = System.Drawing.Color.White;
            this.btnComplains.Image = global::StudentHousingBV.Properties.Resources.strike_30px;
            this.btnComplains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplains.Location = new System.Drawing.Point(0, 260);
            this.btnComplains.Name = "btnComplains";
            this.btnComplains.Size = new System.Drawing.Size(194, 53);
            this.btnComplains.TabIndex = 37;
            this.btnComplains.Text = "Complains";
            this.btnComplains.UseVisualStyleBackColor = true;
            this.btnComplains.Click += new System.EventHandler(this.btnComplains_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbLogout.LinkColor = System.Drawing.Color.White;
            this.lbLogout.Location = new System.Drawing.Point(12, 518);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(49, 14);
            this.lbLogout.TabIndex = 33;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Log out";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLogout_LinkClicked);
            // 
            // btnMyTimetable
            // 
            this.btnMyTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyTimetable.FlatAppearance.BorderSize = 0;
            this.btnMyTimetable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnMyTimetable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnMyTimetable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyTimetable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMyTimetable.ForeColor = System.Drawing.Color.White;
            this.btnMyTimetable.Image = global::StudentHousingBV.Properties.Resources.calendar_34px;
            this.btnMyTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyTimetable.Location = new System.Drawing.Point(0, 207);
            this.btnMyTimetable.Name = "btnMyTimetable";
            this.btnMyTimetable.Size = new System.Drawing.Size(194, 53);
            this.btnMyTimetable.TabIndex = 36;
            this.btnMyTimetable.Text = "My Timetable";
            this.btnMyTimetable.UseVisualStyleBackColor = true;
            this.btnMyTimetable.Click += new System.EventHandler(this.btnMyTimetable_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.CausesValidation = false;
            this.panelLogo.Controls.Add(this.panel4);
            this.panelLogo.Controls.Add(this.lbpenaltypoints);
            this.panelLogo.Controls.Add(this.panel3);
            this.panelLogo.Controls.Add(this.panel15);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(194, 207);
            this.panelLogo.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 110);
            this.panel4.TabIndex = 53;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentHousingBV.Properties.Resources.user_male_circle_filled_80px;
            this.pictureBox2.Location = new System.Drawing.Point(58, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbpenaltypoints
            // 
            this.lbpenaltypoints.AutoSize = true;
            this.lbpenaltypoints.ForeColor = System.Drawing.Color.White;
            this.lbpenaltypoints.Location = new System.Drawing.Point(55, 180);
            this.lbpenaltypoints.Name = "lbpenaltypoints";
            this.lbpenaltypoints.Size = new System.Drawing.Size(86, 14);
            this.lbpenaltypoints.TabIndex = 34;
            this.lbpenaltypoints.Text = "Penalty Points: 0";
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.lbUsername);
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 27);
            this.panel3.TabIndex = 53;
            // 
            // lbUsername
            // 
            this.lbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(0, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(194, 27);
            this.lbUsername.TabIndex = 32;
            this.lbUsername.Text = "User";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel15.Controls.Add(this.pictureBox1);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 37);
            this.panel15.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentHousingBV.Properties.Resources._6adfef68_1ce3_423c_843e_8a400fc3cf37_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(-91, -70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labeltime);
            this.panel1.Controls.Add(this.pictureex);
            this.panel1.Controls.Add(this.picturemessage);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 37);
            this.panel1.TabIndex = 67;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.labeltime.Location = new System.Drawing.Point(6, 9);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(72, 18);
            this.labeltime.TabIndex = 67;
            this.labeltime.Text = "labeldate";
            // 
            // pictureex
            // 
            this.pictureex.Image = global::StudentHousingBV.Properties.Resources.exclamation_mark_32px;
            this.pictureex.Location = new System.Drawing.Point(730, 5);
            this.pictureex.Name = "pictureex";
            this.pictureex.Size = new System.Drawing.Size(15, 22);
            this.pictureex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureex.TabIndex = 4;
            this.pictureex.TabStop = false;
            this.pictureex.Click += new System.EventHandler(this.pictureex_Click);
            // 
            // picturemessage
            // 
            this.picturemessage.Image = global::StudentHousingBV.Properties.Resources.message_32px;
            this.picturemessage.Location = new System.Drawing.Point(700, 5);
            this.picturemessage.Name = "picturemessage";
            this.picturemessage.Size = new System.Drawing.Size(32, 32);
            this.picturemessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturemessage.TabIndex = 3;
            this.picturemessage.TabStop = false;
            this.picturemessage.Click += new System.EventHandler(this.picturemessage_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::StudentHousingBV.Properties.Resources.multiply_filled_30px;
            this.closeBtn.Location = new System.Drawing.Point(784, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // EditEventsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.lbselectdate);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTime);
            this.Controls.Add(this.lbback);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.rbxDescription);
            this.Controls.Add(this.btnSaveAndReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEventsReset);
            this.Controls.Add(this.lbxEvents);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditEventsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEventsGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditEventsGUI_FormClosed);
            this.Load += new System.EventHandler(this.EditEventsGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbback)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturemessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxEvents;
        private System.Windows.Forms.Button btnEventsReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveAndReturn;
        private System.Windows.Forms.RichTextBox rbxDescription;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox lbback;
        private System.Windows.Forms.ComboBox cbxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lbselectdate;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnAnouncements;
        private System.Windows.Forms.Button btnComplains;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.Button btnMyTimetable;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbpenaltypoints;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.PictureBox pictureex;
        private System.Windows.Forms.PictureBox picturemessage;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}