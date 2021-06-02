namespace StudentHousingBV.GUI
{
    partial class LoginGUI
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
            this.passline = new System.Windows.Forms.Panel();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.userline = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picpass = new System.Windows.Forms.PictureBox();
            this.picuser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            this.SuspendLayout();
            // 
            // passline
            // 
            this.passline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.passline.Location = new System.Drawing.Point(56, 264);
            this.passline.Name = "passline";
            this.passline.Size = new System.Drawing.Size(208, 1);
            this.passline.TabIndex = 29;
            // 
            // tbpassword
            // 
            this.tbpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpassword.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.tbpassword.Location = new System.Drawing.Point(90, 238);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(174, 20);
            this.tbpassword.TabIndex = 28;
            this.tbpassword.Text = "Password";
            this.tbpassword.Click += new System.EventHandler(this.tbpassword_Click);
            // 
            // userline
            // 
            this.userline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.userline.Location = new System.Drawing.Point(56, 178);
            this.userline.Name = "userline";
            this.userline.Size = new System.Drawing.Size(208, 1);
            this.userline.TabIndex = 27;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(100, 296);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(131, 47);
            this.btnlogin.TabIndex = 26;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // tbusername
            // 
            this.tbusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusername.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(138)))));
            this.tbusername.Location = new System.Drawing.Point(90, 152);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(174, 20);
            this.tbusername.TabIndex = 25;
            this.tbusername.Text = "Username";
            this.tbusername.Click += new System.EventHandler(this.tbusername_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::StudentHousingBV.Properties.Resources.multiply_filled_30px;
            this.closeBtn.Location = new System.Drawing.Point(288, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentHousingBV.Properties.Resources._50f099e6_63c6_427e_afd5_2b5d4f64ca0a_200x2001;
            this.pictureBox1.Location = new System.Drawing.Point(56, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 135);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // picpass
            // 
            this.picpass.Image = global::StudentHousingBV.Properties.Resources.password_35px1;
            this.picpass.Location = new System.Drawing.Point(56, 227);
            this.picpass.Name = "picpass";
            this.picpass.Size = new System.Drawing.Size(35, 35);
            this.picpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picpass.TabIndex = 31;
            this.picpass.TabStop = false;
            // 
            // picuser
            // 
            this.picuser.Image = global::StudentHousingBV.Properties.Resources.user_35px1;
            this.picuser.Location = new System.Drawing.Point(56, 141);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(35, 35);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picuser.TabIndex = 30;
            this.picuser.TabStop = false;
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(193)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(323, 386);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picpass);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.passline);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.userline);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbusername);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picpass;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.Panel passline;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Panel userline;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}