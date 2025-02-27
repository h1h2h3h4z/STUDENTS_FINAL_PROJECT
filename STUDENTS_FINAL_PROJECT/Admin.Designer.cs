namespace STUDENTS_FINAL_PROJECT
{
    partial class Admin
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
            this.btncancle = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadminname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancle
            // 
            this.btncancle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancle.FlatAppearance.BorderSize = 0;
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancle.ForeColor = System.Drawing.Color.White;
            this.btncancle.Location = new System.Drawing.Point(412, 353);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(96, 34);
            this.btncancle.TabIndex = 27;
            this.btncancle.Text = "Cancle";
            this.btncancle.UseVisualStyleBackColor = false;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(514, 353);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(96, 34);
            this.btnlogin.TabIndex = 26;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.BackColor = System.Drawing.Color.Transparent;
            this.showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassword.ForeColor = System.Drawing.Color.White;
            this.showpassword.Location = new System.Drawing.Point(484, 309);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(126, 21);
            this.showpassword.TabIndex = 25;
            this.showpassword.Text = "Show Password";
            this.showpassword.UseVisualStyleBackColor = false;
            this.showpassword.CheckedChanged += new System.EventHandler(this.showpassword_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Admin Password";
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminpassword.Location = new System.Drawing.Point(415, 264);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.Size = new System.Drawing.Size(195, 30);
            this.txtadminpassword.TabIndex = 23;
            this.txtadminpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Admin Name";
            // 
            // txtadminname
            // 
            this.txtadminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminname.Location = new System.Drawing.Point(415, 210);
            this.txtadminname.Name = "txtadminname";
            this.txtadminname.Size = new System.Drawing.Size(195, 30);
            this.txtadminname.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.admin_person_user_man_2839;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(323, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(399, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "Admin Login";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STUDENTS_FINAL_PROJECT.Properties.Resources._1000_F_210618714_u6VAPB1UEYSisqMzQAJomasWDM2Ae4uO;
            this.ClientSize = new System.Drawing.Size(652, 428);
            this.ControlBox = false;
            this.Controls.Add(this.btncancle);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadminpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadminname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadminpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadminname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}