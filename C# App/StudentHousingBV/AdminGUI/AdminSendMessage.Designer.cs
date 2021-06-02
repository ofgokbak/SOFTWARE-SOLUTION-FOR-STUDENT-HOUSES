namespace StudentHousingBV.AdminGUI
{
    partial class AdminSendMessage
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
            this.btnsendmessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbto = new System.Windows.Forms.ComboBox();
            this.tbmessage = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsendmessage
            // 
            this.btnsendmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnsendmessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsendmessage.Font = new System.Drawing.Font("Arial Black", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsendmessage.ForeColor = System.Drawing.Color.White;
            this.btnsendmessage.Location = new System.Drawing.Point(139, 279);
            this.btnsendmessage.Name = "btnsendmessage";
            this.btnsendmessage.Size = new System.Drawing.Size(154, 50);
            this.btnsendmessage.TabIndex = 72;
            this.btnsendmessage.Text = "Send Message";
            this.btnsendmessage.UseVisualStyleBackColor = false;
            this.btnsendmessage.Click += new System.EventHandler(this.btnsendmessage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 71;
            this.label1.Text = "Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "To:";
            // 
            // cbto
            // 
            this.cbto.BackColor = System.Drawing.Color.White;
            this.cbto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbto.FormattingEnabled = true;
            this.cbto.Location = new System.Drawing.Point(112, 60);
            this.cbto.Name = "cbto";
            this.cbto.Size = new System.Drawing.Size(121, 26);
            this.cbto.TabIndex = 69;
            // 
            // tbmessage
            // 
            this.tbmessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbmessage.Location = new System.Drawing.Point(112, 98);
            this.tbmessage.Name = "tbmessage";
            this.tbmessage.Size = new System.Drawing.Size(276, 175);
            this.tbmessage.TabIndex = 68;
            this.tbmessage.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 28);
            this.panel1.TabIndex = 67;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::StudentHousingBV.Properties.Resources.multiply_filled_35px;
            this.closeBtn.Location = new System.Drawing.Point(393, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 35);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AdminSendMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(428, 334);
            this.Controls.Add(this.btnsendmessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbto);
            this.Controls.Add(this.tbmessage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminSendMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSendMessage";
            this.Load += new System.EventHandler(this.AdminSendMessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsendmessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbto;
        private System.Windows.Forms.RichTextBox tbmessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}