namespace STUDENTS_FINAL_PROJECT
{
    partial class Manager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnenrollement = new System.Windows.Forms.Button();
            this.btncourses = new System.Windows.Forms.Button();
            this.btnteachers = new System.Windows.Forms.Button();
            this.btnstudents = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.uCenrollement1 = new STUDENTS_FINAL_PROJECT.UCenrollement();
            this.uCcourses1 = new STUDENTS_FINAL_PROJECT.UCcourses();
            this.uCteachers1 = new STUDENTS_FINAL_PROJECT.UCteachers();
            this.ucStudents1 = new STUDENTS_FINAL_PROJECT.ucStudents();
            this.uCdashboard1 = new STUDENTS_FINAL_PROJECT.UCdashboard();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnenrollement);
            this.panel1.Controls.Add(this.btncourses);
            this.panel1.Controls.Add(this.btnteachers);
            this.panel1.Controls.Add(this.btnstudents);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 648);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(4, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Hello :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Red;
            this.lblname.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblname.Location = new System.Drawing.Point(103, 119);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 37);
            this.lblname.TabIndex = 36;
            // 
            // btnlogout
            // 
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.icons8_logout_96__1___1_;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 583);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(244, 61);
            this.btnlogout.TabIndex = 35;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnenrollement
            // 
            this.btnenrollement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenrollement.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnenrollement.FlatAppearance.BorderSize = 0;
            this.btnenrollement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenrollement.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenrollement.ForeColor = System.Drawing.Color.White;
            this.btnenrollement.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.enrollment;
            this.btnenrollement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnenrollement.Location = new System.Drawing.Point(3, 453);
            this.btnenrollement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnenrollement.Name = "btnenrollement";
            this.btnenrollement.Size = new System.Drawing.Size(241, 69);
            this.btnenrollement.TabIndex = 34;
            this.btnenrollement.Text = "Enrollement";
            this.btnenrollement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnenrollement.UseVisualStyleBackColor = true;
            this.btnenrollement.Click += new System.EventHandler(this.btnenrollement_Click);
            // 
            // btncourses
            // 
            this.btncourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncourses.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btncourses.FlatAppearance.BorderSize = 0;
            this.btncourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncourses.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncourses.ForeColor = System.Drawing.Color.White;
            this.btncourses.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.courses_icon_15337__2_;
            this.btncourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncourses.Location = new System.Drawing.Point(3, 378);
            this.btncourses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btncourses.Name = "btncourses";
            this.btncourses.Size = new System.Drawing.Size(241, 67);
            this.btncourses.TabIndex = 33;
            this.btncourses.Text = "Courses";
            this.btncourses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncourses.UseVisualStyleBackColor = true;
            this.btncourses.Click += new System.EventHandler(this.btncourses_Click);
            // 
            // btnteachers
            // 
            this.btnteachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnteachers.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnteachers.FlatAppearance.BorderSize = 0;
            this.btnteachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteachers.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteachers.ForeColor = System.Drawing.Color.White;
            this.btnteachers.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.icons8_teacher_48__1_;
            this.btnteachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteachers.Location = new System.Drawing.Point(3, 309);
            this.btnteachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnteachers.Name = "btnteachers";
            this.btnteachers.Size = new System.Drawing.Size(241, 61);
            this.btnteachers.TabIndex = 32;
            this.btnteachers.Text = "Teachers";
            this.btnteachers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnteachers.UseVisualStyleBackColor = true;
            this.btnteachers.Click += new System.EventHandler(this.btnteachers_Click);
            // 
            // btnstudents
            // 
            this.btnstudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstudents.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnstudents.FlatAppearance.BorderSize = 0;
            this.btnstudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstudents.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudents.ForeColor = System.Drawing.Color.White;
            this.btnstudents.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.icons8_student_48__1_;
            this.btnstudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstudents.Location = new System.Drawing.Point(3, 242);
            this.btnstudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnstudents.Name = "btnstudents";
            this.btnstudents.Size = new System.Drawing.Size(241, 59);
            this.btnstudents.TabIndex = 31;
            this.btnstudents.Text = "Students";
            this.btnstudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstudents.UseVisualStyleBackColor = true;
            this.btnstudents.Click += new System.EventHandler(this.btnstudents_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.dashboard__1_;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 173);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(244, 61);
            this.btndashboard.TabIndex = 30;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(87, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "School MS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.WhatsApp_Image_2025_02_11_at_7_38_20_AM_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Location = new System.Drawing.Point(237, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 38);
            this.panel2.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = global::STUDENTS_FINAL_PROJECT.Properties.Resources.icons8_x_521;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(1081, 0);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(40, 38);
            this.btnexit.TabIndex = 36;
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // uCenrollement1
            // 
            this.uCenrollement1.BackColor = System.Drawing.Color.White;
            this.uCenrollement1.Location = new System.Drawing.Point(249, 45);
            this.uCenrollement1.Name = "uCenrollement1";
            this.uCenrollement1.Size = new System.Drawing.Size(1122, 585);
            this.uCenrollement1.TabIndex = 6;
            // 
            // uCcourses1
            // 
            this.uCcourses1.Adminid = 0;
            this.uCcourses1.AdminName = null;
            this.uCcourses1.BackColor = System.Drawing.Color.White;
            this.uCcourses1.Location = new System.Drawing.Point(249, 45);
            this.uCcourses1.Name = "uCcourses1";
            this.uCcourses1.Size = new System.Drawing.Size(1122, 585);
            this.uCcourses1.TabIndex = 5;
            // 
            // uCteachers1
            // 
            this.uCteachers1.Adminid = 0;
            this.uCteachers1.AdminName = null;
            this.uCteachers1.BackColor = System.Drawing.Color.White;
            this.uCteachers1.Location = new System.Drawing.Point(249, 45);
            this.uCteachers1.Name = "uCteachers1";
            this.uCteachers1.Size = new System.Drawing.Size(1122, 585);
            this.uCteachers1.TabIndex = 4;
            // 
            // ucStudents1
            // 
            this.ucStudents1.BackColor = System.Drawing.Color.White;
            this.ucStudents1.Location = new System.Drawing.Point(249, 45);
            this.ucStudents1.Name = "ucStudents1";
            this.ucStudents1.Size = new System.Drawing.Size(1122, 585);
            this.ucStudents1.TabIndex = 3;
            this.ucStudents1.Load += new System.EventHandler(this.ucStudents1_Load);
            // 
            // uCdashboard1
            // 
            this.uCdashboard1.BackColor = System.Drawing.Color.White;
            this.uCdashboard1.Location = new System.Drawing.Point(249, 45);
            this.uCdashboard1.Name = "uCdashboard1";
            this.uCdashboard1.Size = new System.Drawing.Size(1122, 585);
            this.uCdashboard1.TabIndex = 2;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 642);
            this.Controls.Add(this.uCenrollement1);
            this.Controls.Add(this.uCcourses1);
            this.Controls.Add(this.uCteachers1);
            this.Controls.Add(this.ucStudents1);
            this.Controls.Add(this.uCdashboard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnstudents;
        private System.Windows.Forms.Button btnteachers;
        private System.Windows.Forms.Button btncourses;
        private System.Windows.Forms.Button btnenrollement;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel2;
        private UCdashboard uCdashboard1;
        private ucStudents ucStudents1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private UCteachers uCteachers1;
        private UCcourses uCcourses1;
        private UCenrollement uCenrollement1;
    }
}
