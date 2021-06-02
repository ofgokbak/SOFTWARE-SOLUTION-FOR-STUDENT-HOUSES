namespace StudentHousingBV.AdminGUI
{
    partial class AdminComplainsGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btndeletecomplain = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btninbox = new System.Windows.Forms.Button();
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
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(219, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(767, 357);
            this.panel5.TabIndex = 62;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.From,
            this.Topic,
            this.Content});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 357);
            this.dataGridView1.TabIndex = 58;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 10;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 10;
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Topic";
            this.Topic.MinimumWidth = 10;
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.MinimumWidth = 10;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(239, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 35);
            this.panel2.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(287, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Complains";
            // 
            // btndeletecomplain
            // 
            this.btndeletecomplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btndeletecomplain.FlatAppearance.BorderSize = 0;
            this.btndeletecomplain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletecomplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndeletecomplain.ForeColor = System.Drawing.Color.White;
            this.btndeletecomplain.Location = new System.Drawing.Point(491, 493);
            this.btndeletecomplain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndeletecomplain.Name = "btndeletecomplain";
            this.btndeletecomplain.Size = new System.Drawing.Size(223, 39);
            this.btndeletecomplain.TabIndex = 66;
            this.btndeletecomplain.Text = "Delete Complain";
            this.btndeletecomplain.UseVisualStyleBackColor = false;
            this.btndeletecomplain.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelSideMenu.Controls.Add(this.btninbox);
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
            this.panelSideMenu.TabIndex = 67;
            // 
            // btninbox
            // 
            this.btninbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninbox.FlatAppearance.BorderSize = 0;
            this.btninbox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btninbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btninbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btninbox.ForeColor = System.Drawing.Color.White;
            this.btninbox.Image = global::StudentHousingBV.Properties.Resources.sms_32px1;
            this.btninbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninbox.Location = new System.Drawing.Point(0, 375);
            this.btninbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btninbox.Name = "btninbox";
            this.btninbox.Size = new System.Drawing.Size(194, 53);
            this.btninbox.TabIndex = 40;
            this.btninbox.Text = "Inbox";
            this.btninbox.UseVisualStyleBackColor = true;
            this.btninbox.Click += new System.EventHandler(this.btninbox_Click);
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
            this.btnCheckTasks.Click += new System.EventHandler(this.btnCheckTasks_Click_1);
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
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click_1);
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
            this.btnComplains.Click += new System.EventHandler(this.btnComplains_Click_1);
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
            this.btnMyTimetable.Image = global::StudentHousingBV.Properties.Resources.plus_math_filled_35px;
            this.btnMyTimetable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyTimetable.Location = new System.Drawing.Point(0, 163);
            this.btnMyTimetable.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMyTimetable.Name = "btnMyTimetable";
            this.btnMyTimetable.Size = new System.Drawing.Size(194, 53);
            this.btnMyTimetable.TabIndex = 36;
            this.btnMyTimetable.Text = "Add or Delete ";
            this.btnMyTimetable.UseVisualStyleBackColor = true;
            this.btnMyTimetable.Click += new System.EventHandler(this.btnMyTimetable_Click);
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
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 37);
            this.panel1.TabIndex = 68;
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
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // AdminComplainsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.btndeletecomplain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminComplainsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.AdminComplainsGUI_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndeletecomplain;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btninbox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
    }
}