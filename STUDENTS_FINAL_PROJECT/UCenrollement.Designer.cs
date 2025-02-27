namespace STUDENTS_FINAL_PROJECT
{
    partial class UCenrollement
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
            this.cbstudents = new System.Windows.Forms.ComboBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgvenrolle = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cbteacher = new System.Windows.Forms.ComboBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvenrolle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 67);
            this.panel1.TabIndex = 49;
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
            this.label5.Size = new System.Drawing.Size(191, 37);
            this.label5.TabIndex = 30;
            this.label5.Text = "Enrollements";
            // 
            // cbstudents
            // 
            this.cbstudents.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbstudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbstudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstudents.ForeColor = System.Drawing.Color.White;
            this.cbstudents.FormattingEnabled = true;
            this.cbstudents.Location = new System.Drawing.Point(32, 100);
            this.cbstudents.Name = "cbstudents";
            this.cbstudents.Size = new System.Drawing.Size(306, 33);
            this.cbstudents.TabIndex = 50;
            this.cbstudents.SelectedIndexChanged += new System.EventHandler(this.cbstudents_SelectedIndexChanged);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.White;
            this.btnnew.Location = new System.Drawing.Point(32, 355);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(306, 43);
            this.btnnew.TabIndex = 71;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(32, 445);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(306, 42);
            this.btnadd.TabIndex = 70;
            this.btnadd.Text = "Enrolle";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(32, 539);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(306, 43);
            this.btndelete.TabIndex = 68;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dgvenrolle
            // 
            this.dgvenrolle.BackgroundColor = System.Drawing.Color.White;
            this.dgvenrolle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvenrolle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvenrolle.GridColor = System.Drawing.Color.White;
            this.dgvenrolle.Location = new System.Drawing.Point(383, 115);
            this.dgvenrolle.Name = "dgvenrolle";
            this.dgvenrolle.ReadOnly = true;
            this.dgvenrolle.Size = new System.Drawing.Size(724, 453);
            this.dgvenrolle.TabIndex = 72;
            this.dgvenrolle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvenrolle_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(700, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 19);
            this.label9.TabIndex = 73;
            this.label9.Text = "Enrollement List";
            // 
            // cbteacher
            // 
            this.cbteacher.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbteacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbteacher.ForeColor = System.Drawing.Color.White;
            this.cbteacher.FormattingEnabled = true;
            this.cbteacher.Location = new System.Drawing.Point(32, 187);
            this.cbteacher.Name = "cbteacher";
            this.cbteacher.Size = new System.Drawing.Size(306, 33);
            this.cbteacher.TabIndex = 74;
            // 
            // cbcourse
            // 
            this.cbcourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbcourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcourse.ForeColor = System.Drawing.Color.White;
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Location = new System.Drawing.Point(32, 288);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(306, 33);
            this.cbcourse.TabIndex = 75;
            // 
            // UCenrollement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.cbteacher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvenrolle);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cbstudents);
            this.Controls.Add(this.panel1);
            this.Name = "UCenrollement";
            this.Size = new System.Drawing.Size(1122, 585);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvenrolle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbstudents;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgvenrolle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbteacher;
        private System.Windows.Forms.ComboBox cbcourse;
    }
}
