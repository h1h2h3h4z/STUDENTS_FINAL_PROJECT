namespace STUDENTS_FINAL_PROJECT
{
    partial class Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role));
            this.picexit = new System.Windows.Forms.PictureBox();
            this.uCuser1 = new STUDENTS_FINAL_PROJECT.UCuser();
            this.ucAdminregister1 = new STUDENTS_FINAL_PROJECT.UCAdminregister();
            ((System.ComponentModel.ISupportInitialize)(this.picexit)).BeginInit();
            this.SuspendLayout();
            // 
            // picexit
            // 
            this.picexit.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picexit, "picexit");
            this.picexit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picexit.Image = global::STUDENTS_FINAL_PROJECT.Properties.Resources.pngwing1;
            this.picexit.Name = "picexit";
            this.picexit.TabStop = false;
            this.picexit.Click += new System.EventHandler(this.picexit_Click);
            // 
            // uCuser1
            // 
            this.uCuser1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uCuser1, "uCuser1");
            this.uCuser1.Name = "uCuser1";
            this.uCuser1.Load += new System.EventHandler(this.uCuser1_Load);
            // 
            // ucAdminregister1
            // 
            this.ucAdminregister1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucAdminregister1, "ucAdminregister1");
            this.ucAdminregister1.Name = "ucAdminregister1";
            // 
            // Role
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STUDENTS_FINAL_PROJECT.Properties.Resources.bgn;
            this.ControlBox = false;
            this.Controls.Add(this.picexit);
            this.Controls.Add(this.uCuser1);
            this.Controls.Add(this.ucAdminregister1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picexit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UCAdminregister ucAdminregister1;
        private UCuser uCuser1;
        private System.Windows.Forms.PictureBox picexit;
    }
}

