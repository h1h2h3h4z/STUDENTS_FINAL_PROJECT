namespace STUDENTS_FINAL_PROJECT
{
    partial class StudentDetail_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDetail_Form));
            this.lblemail = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnamedate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.studentimage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentimage)).BeginInit();
            this.SuspendLayout();
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
            this.lblemail.TabIndex = 20;
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
            this.lblphone.TabIndex = 19;
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
            this.lblid.TabIndex = 18;
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
            this.lblnamedate.TabIndex = 17;
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
            this.label5.Size = new System.Drawing.Size(198, 62);
            this.label5.TabIndex = 16;
            this.label5.Text = "Student";
            // 
            // exitbtn
            // 
            this.exitbtn.BackgroundImage = global::STUDENTS_FINAL_PROJECT.Properties.Resources.pngwing1;
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Location = new System.Drawing.Point(605, 1);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(34, 31);
            this.exitbtn.TabIndex = 21;
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // studentimage
            // 
            this.studentimage.Location = new System.Drawing.Point(12, 12);
            this.studentimage.Name = "studentimage";
            this.studentimage.Size = new System.Drawing.Size(264, 258);
            this.studentimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentimage.TabIndex = 15;
            this.studentimage.TabStop = false;
            // 
            // StudentDetail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 301);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblnamedate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentDetail_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDetail_Form";
            this.Load += new System.EventHandler(this.StudentDetail_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnamedate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox studentimage;
        private System.Windows.Forms.Button exitbtn;
    }
}