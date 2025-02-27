namespace STUDENTS_FINAL_PROJECT
{
    partial class UCAdminregister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadminname = new System.Windows.Forms.TextBox();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.btnnotadmin = new System.Windows.Forms.Button();
            this.panelimagestudent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(24, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Admin Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(27, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtadminname
            // 
            this.txtadminname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtadminname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadminname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminname.Location = new System.Drawing.Point(31, 154);
            this.txtadminname.Name = "txtadminname";
            this.txtadminname.Size = new System.Drawing.Size(254, 30);
            this.txtadminname.TabIndex = 11;
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtadminpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadminpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminpassword.Location = new System.Drawing.Point(31, 269);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.Size = new System.Drawing.Size(254, 30);
            this.txtadminpassword.TabIndex = 13;
            this.txtadminpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(27, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Black;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(31, 374);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(254, 34);
            this.btnlogin.TabIndex = 29;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.BackColor = System.Drawing.Color.Transparent;
            this.showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassword.ForeColor = System.Drawing.Color.Silver;
            this.showpassword.Location = new System.Drawing.Point(159, 329);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(126, 21);
            this.showpassword.TabIndex = 28;
            this.showpassword.Text = "Show Password";
            this.showpassword.UseVisualStyleBackColor = false;
            this.showpassword.CheckedChanged += new System.EventHandler(this.showpassword_CheckedChanged);
            // 
            // btnnotadmin
            // 
            this.btnnotadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnnotadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnotadmin.FlatAppearance.BorderSize = 0;
            this.btnnotadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnotadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnnotadmin.ForeColor = System.Drawing.Color.White;
            this.btnnotadmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnnotadmin.Location = new System.Drawing.Point(31, 429);
            this.btnnotadmin.Name = "btnnotadmin";
            this.btnnotadmin.Size = new System.Drawing.Size(254, 34);
            this.btnnotadmin.TabIndex = 32;
            this.btnnotadmin.Text = "I\'am not Admin";
            this.btnnotadmin.UseVisualStyleBackColor = false;
            this.btnnotadmin.Click += new System.EventHandler(this.btnnotadmin_Click);
            // 
            // panelimagestudent
            // 
            this.panelimagestudent.BackColor = System.Drawing.Color.Black;
            this.panelimagestudent.BackgroundImage = global::STUDENTS_FINAL_PROJECT.Properties.Resources._4cQ;
            this.panelimagestudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelimagestudent.Location = new System.Drawing.Point(320, 0);
            this.panelimagestudent.Name = "panelimagestudent";
            this.panelimagestudent.Size = new System.Drawing.Size(322, 499);
            this.panelimagestudent.TabIndex = 33;
            // 
            // UCAdminregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelimagestudent);
            this.Controls.Add(this.btnnotadmin);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.txtadminpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtadminname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "UCAdminregister";
            this.Size = new System.Drawing.Size(642, 499);
            this.Load += new System.EventHandler(this.UCAdminregister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadminname;
        private System.Windows.Forms.TextBox txtadminpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.Button btnnotadmin;
        private System.Windows.Forms.Panel panelimagestudent;
    }
}
