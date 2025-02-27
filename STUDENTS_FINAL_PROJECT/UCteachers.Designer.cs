namespace STUDENTS_FINAL_PROJECT
{
    partial class UCteachers
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
            this.label9 = new System.Windows.Forms.Label();
            this.dgvteacher = new System.Windows.Forms.DataGridView();
            this.txtteacherphone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.txtteacherpassword = new System.Windows.Forms.TextBox();
            this.teacherbirthdate = new System.Windows.Forms.DateTimePicker();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btngenerateemail = new System.Windows.Forms.Button();
            this.txtteacherid = new System.Windows.Forms.TextBox();
            this.txtteachername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtteacheremail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.teacherpicture = new System.Windows.Forms.PictureBox();
            this.btnimport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(763, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "Teacher List";
            // 
            // dgvteacher
            // 
            this.dgvteacher.BackgroundColor = System.Drawing.Color.White;
            this.dgvteacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvteacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteacher.GridColor = System.Drawing.Color.White;
            this.dgvteacher.Location = new System.Drawing.Point(444, 104);
            this.dgvteacher.Name = "dgvteacher";
            this.dgvteacher.ReadOnly = true;
            this.dgvteacher.Size = new System.Drawing.Size(663, 472);
            this.dgvteacher.TabIndex = 63;
            this.dgvteacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvteacher_CellClick);
            // 
            // txtteacherphone
            // 
            this.txtteacherphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherphone.Location = new System.Drawing.Point(226, 290);
            this.txtteacherphone.Name = "txtteacherphone";
            this.txtteacherphone.Size = new System.Drawing.Size(212, 29);
            this.txtteacherphone.TabIndex = 62;
            this.txtteacherphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtteacherphone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(223, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 61;
            this.label8.Text = "Teacher Phone";
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.BackColor = System.Drawing.Color.Transparent;
            this.showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassword.ForeColor = System.Drawing.Color.Black;
            this.showpassword.Location = new System.Drawing.Point(93, 325);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(126, 21);
            this.showpassword.TabIndex = 60;
            this.showpassword.Text = "Show Password";
            this.showpassword.UseVisualStyleBackColor = false;
            this.showpassword.CheckedChanged += new System.EventHandler(this.showpassword_CheckedChanged);
            // 
            // txtteacherpassword
            // 
            this.txtteacherpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherpassword.Location = new System.Drawing.Point(7, 289);
            this.txtteacherpassword.Name = "txtteacherpassword";
            this.txtteacherpassword.Size = new System.Drawing.Size(212, 30);
            this.txtteacherpassword.TabIndex = 59;
            this.txtteacherpassword.UseSystemPasswordChar = true;
            // 
            // teacherbirthdate
            // 
            this.teacherbirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherbirthdate.Location = new System.Drawing.Point(226, 366);
            this.teacherbirthdate.Name = "teacherbirthdate";
            this.teacherbirthdate.Size = new System.Drawing.Size(212, 27);
            this.teacherbirthdate.TabIndex = 58;
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(7, 368);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(212, 28);
            this.cbgender.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(223, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Birth-Date";
            // 
            // btngenerateemail
            // 
            this.btngenerateemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngenerateemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerateemail.FlatAppearance.BorderSize = 0;
            this.btngenerateemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerateemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerateemail.ForeColor = System.Drawing.Color.White;
            this.btngenerateemail.Location = new System.Drawing.Point(226, 220);
            this.btngenerateemail.Name = "btngenerateemail";
            this.btngenerateemail.Size = new System.Drawing.Size(212, 29);
            this.btngenerateemail.TabIndex = 54;
            this.btngenerateemail.Text = "generate email";
            this.btngenerateemail.UseVisualStyleBackColor = false;
            this.btngenerateemail.Click += new System.EventHandler(this.btngenerateemail_Click);
            // 
            // txtteacherid
            // 
            this.txtteacherid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacherid.Location = new System.Drawing.Point(7, 155);
            this.txtteacherid.Name = "txtteacherid";
            this.txtteacherid.Size = new System.Drawing.Size(212, 29);
            this.txtteacherid.TabIndex = 53;
            this.txtteacherid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtteacherid_KeyPress);
            // 
            // txtteachername
            // 
            this.txtteachername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteachername.Location = new System.Drawing.Point(226, 155);
            this.txtteachername.Name = "txtteachername";
            this.txtteachername.Size = new System.Drawing.Size(212, 29);
            this.txtteachername.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(223, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Teacher Name";
            // 
            // txtteacheremail
            // 
            this.txtteacheremail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteacheremail.Location = new System.Drawing.Point(7, 220);
            this.txtteacheremail.Name = "txtteacheremail";
            this.txtteacheremail.ReadOnly = true;
            this.txtteacheremail.Size = new System.Drawing.Size(212, 29);
            this.txtteacheremail.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 64);
            this.panel1.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(506, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Teachers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(4, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Teacher Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 72;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 71;
            this.label3.Text = "Teacher Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "Teacher Email";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.icons8_teacher_48__1_;
            this.pictureBox2.Location = new System.Drawing.Point(174, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(147, 542);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(291, 40);
            this.btndelete.TabIndex = 64;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Blue;
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(147, 498);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(291, 38);
            this.btnupdate.TabIndex = 65;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(147, 452);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(291, 40);
            this.btnadd.TabIndex = 66;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(147, 402);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(291, 44);
            this.btnnew.TabIndex = 67;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // teacherpicture
            // 
            this.teacherpicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.teacherpicture.Location = new System.Drawing.Point(7, 402);
            this.teacherpicture.Name = "teacherpicture";
            this.teacherpicture.Size = new System.Drawing.Size(134, 134);
            this.teacherpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacherpicture.TabIndex = 68;
            this.teacherpicture.TabStop = false;
            // 
            // btnimport
            // 
            this.btnimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnimport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimport.FlatAppearance.BorderSize = 0;
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.ForeColor = System.Drawing.Color.White;
            this.btnimport.Location = new System.Drawing.Point(7, 542);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(134, 40);
            this.btnimport.TabIndex = 69;
            this.btnimport.Text = "import";
            this.btnimport.UseVisualStyleBackColor = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // UCteachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.teacherpicture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvteacher);
            this.Controls.Add(this.txtteacherphone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.txtteacherpassword);
            this.Controls.Add(this.teacherbirthdate);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btngenerateemail);
            this.Controls.Add(this.txtteacherid);
            this.Controls.Add(this.txtteachername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtteacheremail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "UCteachers";
            this.Size = new System.Drawing.Size(1122, 585);
            ((System.ComponentModel.ISupportInitialize)(this.dgvteacher)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvteacher;
        private System.Windows.Forms.TextBox txtteacherphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.TextBox txtteacherpassword;
        private System.Windows.Forms.DateTimePicker teacherbirthdate;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btngenerateemail;
        private System.Windows.Forms.TextBox txtteacherid;
        private System.Windows.Forms.TextBox txtteachername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtteacheremail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.PictureBox teacherpicture;
        private System.Windows.Forms.Button btnimport;
    }
}
