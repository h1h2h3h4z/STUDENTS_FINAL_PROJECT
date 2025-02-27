namespace STUDENTS_FINAL_PROJECT
{
    partial class TeacherPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPage));
            this.label1 = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnamedate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherimage = new System.Windows.Forms.PictureBox();
            this.exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teacherimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "My Student\'s Profile";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.BackColor = System.Drawing.Color.Silver;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblemail.ForeColor = System.Drawing.Color.Black;
            this.lblemail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblemail.Location = new System.Drawing.Point(282, 174);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(102, 37);
            this.lblemail.TabIndex = 25;
            this.lblemail.Text = "Email : ";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.BackColor = System.Drawing.Color.Silver;
            this.lblphone.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblphone.ForeColor = System.Drawing.Color.Black;
            this.lblphone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblphone.Location = new System.Drawing.Point(282, 123);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(112, 37);
            this.lblphone.TabIndex = 24;
            this.lblphone.Text = "Phone : ";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Silver;
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblid.ForeColor = System.Drawing.Color.Black;
            this.lblid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblid.Location = new System.Drawing.Point(282, 233);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(60, 37);
            this.lblid.TabIndex = 23;
            this.lblid.Text = "Id : ";
            // 
            // lblnamedate
            // 
            this.lblnamedate.AutoSize = true;
            this.lblnamedate.BackColor = System.Drawing.Color.Transparent;
            this.lblnamedate.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblnamedate.ForeColor = System.Drawing.Color.Black;
            this.lblnamedate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblnamedate.Location = new System.Drawing.Point(286, 74);
            this.lblnamedate.Name = "lblnamedate";
            this.lblnamedate.Size = new System.Drawing.Size(242, 37);
            this.lblnamedate.TabIndex = 22;
            this.lblnamedate.Text = "Student - birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(282, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 62);
            this.label5.TabIndex = 21;
            this.label5.Text = "Teacher";
            // 
            // teacherimage
            // 
            this.teacherimage.Location = new System.Drawing.Point(12, 12);
            this.teacherimage.Name = "teacherimage";
            this.teacherimage.Size = new System.Drawing.Size(264, 258);
            this.teacherimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teacherimage.TabIndex = 20;
            this.teacherimage.TabStop = false;
            // 
            // exitbtn
            // 
            this.exitbtn.BackgroundImage = global::STUDENTS_FINAL_PROJECT.Properties.Resources.pngwing1;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Location = new System.Drawing.Point(949, 0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(34, 31);
            this.exitbtn.TabIndex = 28;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 601);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblnamedate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teacherimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherPage";
            this.Load += new System.EventHandler(this.TeacherPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnamedate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox teacherimage;
        private System.Windows.Forms.Button exitbtn;
    }
}