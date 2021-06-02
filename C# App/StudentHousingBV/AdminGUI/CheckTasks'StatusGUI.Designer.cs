namespace StudentHousingBV.AdminGUI
{
    partial class CheckTasks_StatusGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnCheckTasks = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnComplains = new System.Windows.Forms.Button();
            this.lbLogout = new System.Windows.Forms.LinkLabel();
            this.btnMyTimetable = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltime = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfloor = new System.Windows.Forms.Label();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timetablegridView = new System.Windows.Forms.DataGridView();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.cmboxFloors = new System.Windows.Forms.ComboBox();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetablegridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.panel14);
            this.panelSideMenu.Controls.Add(this.btnCheckTasks);
            this.panelSideMenu.Controls.Add(this.btnRules);
            this.panelSideMenu.Controls.Add(this.btnComplains);
            this.panelSideMenu.Controls.Add(this.lbLogout);
            this.panelSideMenu.Controls.Add(this.btnMyTimetable);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(194, 550);
            this.panelSideMenu.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::StudentHousingBV.Properties.Resources.sms_32px1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 53);
            this.button1.TabIndex = 40;
            this.button1.Text = "Inbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnInbox_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Location = new System.Drawing.Point(10, 506);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(175, 1);
            this.panel14.TabIndex = 34;
            // 
            // btnCheckTasks
            // 
            this.btnCheckTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckTasks.FlatAppearance.BorderSize = 0;
            this.btnCheckTasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnCheckTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnCheckTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckTasks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckTasks.ForeColor = System.Drawing.Color.White;
            this.btnCheckTasks.Image = global::StudentHousingBV.Properties.Resources.checkmark_32px;
            this.btnCheckTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckTasks.Location = new System.Drawing.Point(0, 322);
            this.btnCheckTasks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCheckTasks.Name = "btnCheckTasks";
            this.btnCheckTasks.Size = new System.Drawing.Size(194, 53);
            this.btnCheckTasks.TabIndex = 39;
            this.btnCheckTasks.Text = " Check Tasks";
            this.btnCheckTasks.UseVisualStyleBackColor = true;
            this.btnCheckTasks.Click += new System.EventHandler(this.BtnCheckTasks_Click);
            // 
            // btnRules
            // 
            this.btnRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRules.FlatAppearance.BorderSize = 0;
            this.btnRules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnRules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRules.ForeColor = System.Drawing.Color.White;
            this.btnRules.Image = global::StudentHousingBV.Properties.Resources.asdfasdfasdfasdf;
            this.btnRules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRules.Location = new System.Drawing.Point(0, 269);
            this.btnRules.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(194, 53);
            this.btnRules.TabIndex = 38;
            this.btnRules.Text = "Manage Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.BtnManageRules_Click);
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
            this.btnComplains.Image = global::StudentHousingBV.Properties.Resources.strike_30px1;
            this.btnComplains.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComplains.Location = new System.Drawing.Point(0, 216);
            this.btnComplains.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnComplains.Name = "btnComplains";
            this.btnComplains.Size = new System.Drawing.Size(194, 53);
            this.btnComplains.TabIndex = 37;
            this.btnComplains.Text = "Complains";
            this.btnComplains.UseVisualStyleBackColor = true;
            this.btnComplains.Click += new System.EventHandler(this.BtnComplains_Click);
            // 
            // lbLogout
            // 
            this.lbLogout.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lbLogout.AutoSize = true;
            this.lbLogout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbLogout.LinkColor = System.Drawing.Color.White;
            this.lbLogout.Location = new System.Drawing.Point(12, 518);
            this.lbLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(49, 14);
            this.lbLogout.TabIndex = 33;
            this.lbLogout.TabStop = true;
            this.lbLogout.Text = "Log out";
            this.lbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbLogout_LinkClicked);
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
            this.btnMyTimetable.Image = global::StudentHousingBV.Properties.Resources.plus_math_filled_35px;
            this.btnMyTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyTimetable.Location = new System.Drawing.Point(0, 163);
            this.btnMyTimetable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMyTimetable.Name = "btnMyTimetable";
            this.btnMyTimetable.Size = new System.Drawing.Size(194, 53);
            this.btnMyTimetable.TabIndex = 36;
            this.btnMyTimetable.Text = "Add or Delete ";
            this.btnMyTimetable.UseVisualStyleBackColor = true;
            this.btnMyTimetable.Click += new System.EventHandler(this.BtnAddOrDeleteStudent_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.CausesValidation = false;
            this.panelLogo.Controls.Add(this.panel15);
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Controls.Add(this.lbUsername);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(194, 163);
            this.panelLogo.TabIndex = 35;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel15.Controls.Add(this.pictureBox1);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(194, 37);
            this.panel15.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentHousingBV.Properties.Resources._5bd9cd33_49d3_45c5_aec6_232dbc709d4e_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(-91, -70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentHousingBV.Properties.Resources.user_male_circle_filled_80px;
            this.pictureBox2.Location = new System.Drawing.Point(54, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(69, 136);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(53, 18);
            this.lbUsername.TabIndex = 32;
            this.lbUsername.Text = "Admin";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labeltime);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 37);
            this.panel1.TabIndex = 73;
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltime.ForeColor = System.Drawing.Color.Black;
            this.labeltime.Location = new System.Drawing.Point(17, 9);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(72, 18);
            this.labeltime.TabIndex = 4;
            this.labeltime.Text = "labeldate";
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::StudentHousingBV.Properties.Resources.multiply_filled_35px;
            this.closeBtn.Location = new System.Drawing.Point(780, 2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 35);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(239, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 35);
            this.panel2.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(238, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Check Task  Status";
            // 
            // lbfloor
            // 
            this.lbfloor.AutoSize = true;
            this.lbfloor.BackColor = System.Drawing.SystemColors.Control;
            this.lbfloor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbfloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.lbfloor.Location = new System.Drawing.Point(507, 87);
            this.lbfloor.Name = "lbfloor";
            this.lbfloor.Size = new System.Drawing.Size(66, 22);
            this.lbfloor.TabIndex = 75;
            this.lbfloor.Text = "Floor:";
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelDataGridView.Controls.Add(this.label1);
            this.panelDataGridView.Controls.Add(this.timetablegridView);
            this.panelDataGridView.Location = new System.Drawing.Point(200, 139);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(808, 356);
            this.panelDataGridView.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "* Not Controlled yet";
            // 
            // timetablegridView
            // 
            this.timetablegridView.AllowUserToAddRows = false;
            this.timetablegridView.AllowUserToDeleteRows = false;
            this.timetablegridView.AllowUserToResizeColumns = false;
            this.timetablegridView.AllowUserToResizeRows = false;
            this.timetablegridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timetablegridView.BackgroundColor = System.Drawing.Color.White;
            this.timetablegridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timetablegridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.timetablegridView.ColumnHeadersHeight = 40;
            this.timetablegridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.timetablegridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timetablegridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.timetablegridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timetablegridView.Enabled = false;
            this.timetablegridView.EnableHeadersVisualStyles = false;
            this.timetablegridView.GridColor = System.Drawing.Color.White;
            this.timetablegridView.Location = new System.Drawing.Point(0, 0);
            this.timetablegridView.Name = "timetablegridView";
            this.timetablegridView.ReadOnly = true;
            this.timetablegridView.RowHeadersWidth = 4;
            this.timetablegridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.timetablegridView.Size = new System.Drawing.Size(808, 356);
            this.timetablegridView.TabIndex = 53;
            // 
            // Person
            // 
            this.Person.HeaderText = "Tasks";
            this.Person.MinimumWidth = 6;
            this.Person.Name = "Person";
            this.Person.ReadOnly = true;
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Monday";
            this.Monday.MinimumWidth = 6;
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Tuesday";
            this.Tuesday.MinimumWidth = 6;
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Wednesday";
            this.Wednesday.MinimumWidth = 6;
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Thursday";
            this.Thursday.MinimumWidth = 6;
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Friday";
            this.Friday.MinimumWidth = 6;
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Saturday";
            this.Saturday.MinimumWidth = 6;
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Sunday";
            this.Sunday.MinimumWidth = 6;
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            // 
            // timeTimer
            // 
            this.timeTimer.Interval = 1000;
            this.timeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // cmboxFloors
            // 
            this.cmboxFloors.BackColor = System.Drawing.SystemColors.Window;
            this.cmboxFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxFloors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmboxFloors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxFloors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.cmboxFloors.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th"});
            this.cmboxFloors.Location = new System.Drawing.Point(581, 84);
            this.cmboxFloors.Name = "cmboxFloors";
            this.cmboxFloors.Size = new System.Drawing.Size(83, 27);
            this.cmboxFloors.TabIndex = 77;
            this.cmboxFloors.SelectedIndexChanged += new System.EventHandler(this.CmboxFloors_SelectedIndexChanged);
            // 
            // CheckTasks_StatusGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.cmboxFloors);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.lbfloor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckTasks_StatusGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckTasksStatusGUI";
            this.Load += new System.EventHandler(this.CheckTasks_StatusGUI_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            this.panelDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetablegridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button btnCheckTasks;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnComplains;
        private System.Windows.Forms.LinkLabel lbLogout;
        private System.Windows.Forms.Button btnMyTimetable;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbfloor;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView timetablegridView;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.ComboBox cmboxFloors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Person;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
    }
}