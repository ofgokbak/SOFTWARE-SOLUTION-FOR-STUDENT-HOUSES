namespace StudentHousingBV.AdminGUI
{
    partial class AdminAddRule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.tbruletext = new System.Windows.Forms.RichTextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 37);
            this.panel1.TabIndex = 66;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::StudentHousingBV.Properties.Resources.multiply_filled_35px;
            this.closeBtn.Location = new System.Drawing.Point(395, 3);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(35, 35);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tbruletext
            // 
            this.tbruletext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbruletext.Location = new System.Drawing.Point(61, 100);
            this.tbruletext.Name = "tbruletext";
            this.tbruletext.Size = new System.Drawing.Size(311, 243);
            this.tbruletext.TabIndex = 67;
            this.tbruletext.Text = "";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnregister.ForeColor = System.Drawing.Color.White;
            this.btnregister.Location = new System.Drawing.Point(163, 360);
            this.btnregister.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(120, 39);
            this.btnregister.TabIndex = 69;
            this.btnregister.Text = "Add Rule";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label8.Location = new System.Drawing.Point(150, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "Rule Content";
            // 
            // AdminAddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(432, 411);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.tbruletext);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAddRule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddRule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.RichTextBox tbruletext;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label8;
    }
}