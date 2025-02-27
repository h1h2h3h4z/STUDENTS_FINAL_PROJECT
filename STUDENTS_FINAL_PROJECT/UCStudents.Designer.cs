namespace STUDENTS_FINAL_PROJECT
{
    partial class ucStudents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudentemail = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btngenerateemail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.studentbirthdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.txtstudentpassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstudentphone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnimport = new System.Windows.Forms.Button();
            this.dgvstd = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.studentpicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentpicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 64);
            this.panel1.TabIndex = 1;
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
            this.label5.Size = new System.Drawing.Size(133, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Students";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Students Email";
            // 
            // txtstudentemail
            // 
            this.txtstudentemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentemail.Location = new System.Drawing.Point(20, 219);
            this.txtstudentemail.Name = "txtstudentemail";
            this.txtstudentemail.ReadOnly = true;
            this.txtstudentemail.Size = new System.Drawing.Size(199, 29);
            this.txtstudentemail.TabIndex = 7;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentname.Location = new System.Drawing.Point(238, 154);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(200, 29);
            this.txtstudentname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(235, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Students Name";
            // 
            // btngenerateemail
            // 
            this.btngenerateemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngenerateemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerateemail.FlatAppearance.BorderSize = 0;
            this.btngenerateemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerateemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerateemail.ForeColor = System.Drawing.Color.White;
            this.btngenerateemail.Location = new System.Drawing.Point(238, 219);
            this.btngenerateemail.Name = "btngenerateemail";
            this.btngenerateemail.Size = new System.Drawing.Size(200, 29);
            this.btngenerateemail.TabIndex = 28;
            this.btngenerateemail.Text = "generate email";
            this.btngenerateemail.UseVisualStyleBackColor = false;
            this.btngenerateemail.Click += new System.EventHandler(this.btngenerateemail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(38, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(235, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Birth-Date";
            // 
            // cbgender
            // 
            this.cbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(20, 366);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(199, 28);
            this.cbgender.TabIndex = 32;
            // 
            // studentbirthdate
            // 
            this.studentbirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentbirthdate.Location = new System.Drawing.Point(238, 367);
            this.studentbirthdate.Name = "studentbirthdate";
            this.studentbirthdate.Size = new System.Drawing.Size(200, 27);
            this.studentbirthdate.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(38, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Students Id";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentid.Location = new System.Drawing.Point(20, 154);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(199, 29);
            this.txtstudentid.TabIndex = 11;
            this.txtstudentid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstudentid_KeyPress);
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.BackColor = System.Drawing.Color.Transparent;
            this.showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassword.ForeColor = System.Drawing.Color.Black;
            this.showpassword.Location = new System.Drawing.Point(93, 337);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(126, 21);
            this.showpassword.TabIndex = 36;
            this.showpassword.Text = "Show Password";
            this.showpassword.UseVisualStyleBackColor = false;
            this.showpassword.CheckedChanged += new System.EventHandler(this.showpassword_CheckedChanged);
            // 
            // txtstudentpassword
            // 
            this.txtstudentpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentpassword.Location = new System.Drawing.Point(20, 288);
            this.txtstudentpassword.Name = "txtstudentpassword";
            this.txtstudentpassword.Size = new System.Drawing.Size(199, 30);
            this.txtstudentpassword.TabIndex = 34;
            this.txtstudentpassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(19, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Students Password";
            // 
            // txtstudentphone
            // 
            this.txtstudentphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentphone.Location = new System.Drawing.Point(238, 289);
            this.txtstudentphone.Name = "txtstudentphone";
            this.txtstudentphone.Size = new System.Drawing.Size(200, 29);
            this.txtstudentphone.TabIndex = 39;
            this.txtstudentphone.TextChanged += new System.EventHandler(this.txtstudentphone_TextChanged);
            this.txtstudentphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstudentphone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(235, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 38;
            this.label8.Text = "Students Phone";
            // 
            // btnimport
            // 
            this.btnimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnimport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimport.FlatAppearance.BorderSize = 0;
            this.btnimport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimport.ForeColor = System.Drawing.Color.White;
            this.btnimport.Location = new System.Drawing.Point(17, 537);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(124, 42);
            this.btnimport.TabIndex = 42;
            this.btnimport.Text = "import";
            this.btnimport.UseVisualStyleBackColor = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // dgvstd
            // 
            this.dgvstd.BackgroundColor = System.Drawing.Color.White;
            this.dgvstd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvstd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstd.GridColor = System.Drawing.Color.White;
            this.dgvstd.Location = new System.Drawing.Point(444, 113);
            this.dgvstd.Name = "dgvstd";
            this.dgvstd.ReadOnly = true;
            this.dgvstd.Size = new System.Drawing.Size(663, 472);
            this.dgvstd.TabIndex = 43;
            this.dgvstd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstd_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(147, 537);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(291, 42);
            this.btndelete.TabIndex = 44;
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
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(147, 491);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(291, 40);
            this.btnupdate.TabIndex = 45;
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
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(147, 449);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(291, 36);
            this.btnadd.TabIndex = 46;
            this.btnadd.Text = " Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(147, 403);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(291, 40);
            this.btnnew.TabIndex = 47;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(763, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 19);
            this.label9.TabIndex = 31;
            this.label9.Text = "Student List";
            // 
            // studentpicture
            // 
            this.studentpicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.studentpicture.Location = new System.Drawing.Point(17, 403);
            this.studentpicture.Name = "studentpicture";
            this.studentpicture.Size = new System.Drawing.Size(124, 128);
            this.studentpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentpicture.TabIndex = 40;
            this.studentpicture.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources._130manstudent2_100617;
            this.pictureBox2.Location = new System.Drawing.Point(192, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(19, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "Students Id";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(65, 321);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 49;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.DarkGray;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtsearch.Location = new System.Drawing.Point(444, 79);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(225, 24);
            this.txtsearch.TabIndex = 50;
            this.txtsearch.Text = "Search Student";
            this.txtsearch.Click += new System.EventHandler(this.txtsearch_Click);
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ucStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dgvstd);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.studentpicture);
            this.Controls.Add(this.txtstudentphone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showpassword);
            this.Controls.Add(this.txtstudentpassword);
            this.Controls.Add(this.studentbirthdate);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btngenerateemail);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstudentemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "ucStudents";
            this.Size = new System.Drawing.Size(1122, 585);
            this.Load += new System.EventHandler(this.ucStudents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentpicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstudentemail;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngenerateemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.DateTimePicker studentbirthdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.TextBox txtstudentpassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstudentphone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox studentpicture;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.DataGridView dgvstd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.TextBox txtsearch;
    }
}
