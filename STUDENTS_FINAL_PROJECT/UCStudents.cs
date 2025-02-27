using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace STUDENTS_FINAL_PROJECT
{
    public partial class ucStudents : UserControl
    {
        private string AdminName { get; set; }
        private int Adminid { get; set; }
        public ucStudents()
        {
            InitializeComponent();
            refreshdgv();
            ApplyButtonStyle(btnnew, Color.Blue, Color.DarkBlue);
            ApplyButtonStyle(btnimport, Color.Red, Color.Red);
            ApplyButtonStyle(btndelete, Color.Red, Color.DarkRed);
            ApplyButtonStyle(btnupdate, Color.Black, Color.Black);
            ApplyButtonStyle(btnadd, Color.Green, Color.DarkGreen);

        }

        private int _stdid = -1;
        private string _originalImagePath; 
        private bool isPictureChanged = false;

        public void SetAdminName(string adminName)
        {
            AdminName = adminName;
        }

        public void SetAdminId(int adminid)
        {
            Adminid = adminid;
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {

            if (showpassword.Checked)
            {
                txtstudentpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtstudentpassword.UseSystemPasswordChar = true;

            }
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            refreshdgv();
            ApplyAdvancedStyle(dgvstd);
        }

        private void refreshdgv()
        {
            STUDENTS student = new STUDENTS();
            DataTable dt = student.Filldata();

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvstd.DataSource = dt;
                dgvstd.Show();
                // Set column headers
                dgvstd.Columns["STUDENT_ID"].HeaderText = "ID";
                dgvstd.Columns["STUDENT_NAME"].HeaderText = "NAME";
                dgvstd.Columns["STUDENT_EMAIL"].HeaderText = "EMAIL";
                dgvstd.Columns["STUDENT_PASSWORD"].HeaderText = "PASSWORD";
                dgvstd.Columns["STUDENT_PHONE"].HeaderText = "PHONE";
                dgvstd.Columns["STUDENT_GENDER"].HeaderText = "GENDER";
                dgvstd.Columns["STUDENT_BIRTHDATE"].HeaderText = "BIRTHDATE";

                // Hide unnecessary columns
                dgvstd.Columns["STUDENT_IMAGE"].Visible = false;
                dgvstd.Columns["STUDENT_CREATED"].Visible = false;
                dgvstd.Columns["STUDENT_UPDATED"].Visible = false;
                dgvstd.Columns["ADMIN_ID"].Visible = false;
                dgvstd.Columns["ADMIN_ID1"].Visible = false;
                dgvstd.Columns["ADMIN_PASSWORD"].Visible = false;

                dgvstd.Columns["ADMIN_NAME"].HeaderText = "ADMIN";
            }
            else
            {
                dgvstd.Hide();
            }
        }

        private void ApplyAdvancedStyle(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Green;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeight = 40;
            dgv.EnableHeadersVisualStyles = false;

            // Remove unnecessary borders
            dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            dgv.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;

            // Row styling
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dgv.GridColor = Color.Gray;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.RowHeadersVisible = true;
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.Green;
            dgv.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.RowHeadersWidth = 40;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void SetTextBoxBorderColor(TextBox textBox, Color borderColor)
        {
            textBox.BorderStyle = BorderStyle.None; // Remove default border
            textBox.Parent.Paint += (sender, e) =>
            {
                using (Pen pen = new Pen(borderColor, 2))
                {
                    Rectangle rect = new Rectangle(textBox.Location.X - 1, textBox.Location.Y - 1, textBox.Width + 1, textBox.Height + 1);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
            textBox.Parent.Invalidate(); // Redraw the form
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Image Files(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        studentpicture.ImageLocation = dialog.FileName;
                        isPictureChanged = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string generateimage(string studentid, string haveimage)
        {

            return studentid;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            STUDENTS student = new STUDENTS();

            if (string.IsNullOrWhiteSpace(txtstudentid.Text) ||
                string.IsNullOrWhiteSpace(txtstudentname.Text) ||
                string.IsNullOrWhiteSpace(txtstudentpassword.Text) ||
                string.IsNullOrWhiteSpace(txtstudentemail.Text) ||
                string.IsNullOrWhiteSpace(txtstudentphone.Text) ||
                string.IsNullOrWhiteSpace(cbgender.Text) ||
                studentbirthdate.Value == null || studentpicture.Image == null)
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtstudentpassword.Text.Length < 6)
            {
                lblerror.Text = "Email should be at least 6 digits";
                SetTextBoxBorderColor(txtstudentpassword, Color.Red);
                return;
            }


            if (student.checkstudentid(txtstudentid.Text, txtstudentemail.Text))
            {
                string savePath = Path.Combine(Application.StartupPath, "Images", $"{txtstudentname.Text}-{txtstudentid.Text}{Path.GetExtension(studentpicture.ImageLocation)}");

                try
                {
                    
                    Directory.CreateDirectory(Path.GetDirectoryName(savePath));

                    File.Copy(studentpicture.ImageLocation, savePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (student.AddStudent(
                    Convert.ToInt32(txtstudentid.Text),
                    txtstudentname.Text,
                    txtstudentpassword.Text,
                    txtstudentemail.Text,
                    txtstudentphone.Text,
                    cbgender.Text,
                    studentbirthdate.Value,
                    savePath,
                    Adminid))
                {
                    MessageBox.Show("student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshdgv();
                    Clearfields();
                }
                else
                {
                    MessageBox.Show("Error adding student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Student ID  or EMAIL already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btngenerateemail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtstudentid.Text) && !string.IsNullOrWhiteSpace(txtstudentname.Text))
            {
                txtstudentemail.Text = $"{txtstudentid.Text}-{txtstudentname.Text.Trim().ToUpper()}@UN.com";
            }
            else
            {
                MessageBox.Show("Please enter Student ID and Name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clearfields()
        {
            txtstudentid.Text = "";
            txtstudentname.Text = "";
            txtstudentemail.Text = "";
            txtstudentphone.Text = "";
            txtstudentpassword.Text = "";
            isPictureChanged = false;

            if (studentpicture.Image != null)
            {
                studentpicture.Image.Dispose();
                studentpicture.Image = null;
            }

            studentbirthdate.Value = DateTime.Now;
            _stdid = -1;
            lblerror.Text = "";
            SetTextBoxBorderColor(txtstudentpassword, Color.Black);
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvstd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }

            DataGridViewRow row = dgvstd.Rows[e.RowIndex];
            _stdid = Convert.ToInt32(row.Cells["STUDENT_ID"].Value);
            txtstudentid.Text = row.Cells["STUDENT_ID"].Value.ToString();
            txtstudentname.Text = row.Cells["STUDENT_NAME"].Value.ToString();
            txtstudentemail.Text = row.Cells["STUDENT_EMAIL"].Value.ToString();
            txtstudentpassword.Text = row.Cells["STUDENT_PASSWORD"].Value.ToString();
            txtstudentphone.Text = row.Cells["STUDENT_PHONE"].Value.ToString();
            cbgender.Text = row.Cells["STUDENT_GENDER"].Value.ToString();
            studentbirthdate.Text = row.Cells["STUDENT_BIRTHDATE"].Value.ToString();
            string imagePath = row.Cells["STUDENT_IMAGE"].Value?.ToString();
            _originalImagePath = imagePath; 
            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                studentpicture.Image = Image.FromFile(imagePath);
                studentpicture.ImageLocation = imagePath; 
            }
            else
            {
                studentpicture.Image = null;
                studentpicture.ImageLocation = null;
            }



        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (_stdid == -1)
            {
                MessageBox.Show("Select Student to delete");
            }
            else
            {

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Are you sure you want to delete student?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    STUDENTS student = new STUDENTS();
                    if (student.DeleteStudent(_stdid))
                    {
                        MessageBox.Show("Delete suceessefully !");
                        Clearfields();
                        refreshdgv();

                    }
                    else
                    {
                        MessageBox.Show("Error in Deleting");
                    }
                }
            }
        }
        private void ApplyButtonStyle(Button button, Color color, Color bgc)
        {
            // Default button style
            button.BackColor = color;
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat;

            // Border radius for rounded corners
            int radius = 20; // You can adjust this value for more or less rounded corners
            button.Region = new Region(CreateRoundPath(button.ClientRectangle, radius));

            // Button appearance when hovered or clicked
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = bgc; // Dark green on hover
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 139, 34); // Forest green on click

            // Set cursor to hand and apply padding for better appearance
            button.Cursor = Cursors.Hand;
            button.Padding = new Padding(5);
        }

        private GraphicsPath CreateRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }




        private void btnupdate_Click(object sender, EventArgs e)
        {
            STUDENTS student = new STUDENTS();
            string savePath = _originalImagePath; 
            if (!string.IsNullOrWhiteSpace(studentpicture.ImageLocation) && studentpicture.ImageLocation != _originalImagePath)
            {
                savePath = Path.Combine(Application.StartupPath, "Images", $"{txtstudentname.Text}-{txtstudentid.Text}{Path.GetExtension(studentpicture.ImageLocation)}");

                try
                {
                    
                    Directory.CreateDirectory(Path.GetDirectoryName(savePath));

                  
                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }

                    // Save the new image
                    File.Copy(studentpicture.ImageLocation, savePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtstudentid.Text) ||
               string.IsNullOrWhiteSpace(txtstudentname.Text) ||
               string.IsNullOrWhiteSpace(txtstudentpassword.Text) ||
               string.IsNullOrWhiteSpace(txtstudentemail.Text) ||
               string.IsNullOrWhiteSpace(txtstudentphone.Text) ||
               string.IsNullOrWhiteSpace(cbgender.Text) ||
               studentbirthdate.Value == null || studentpicture.Image == null)
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (student.UpdateStudent(
                Convert.ToInt32(txtstudentid.Text),
                txtstudentname.Text,
                txtstudentpassword.Text,
                txtstudentemail.Text,
                txtstudentphone.Text,
                cbgender.Text,
                studentbirthdate.Value,
                savePath))
            {
                MessageBox.Show("student Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshdgv();
                Clearfields();
            }
            else
            {
                MessageBox.Show("Error updating student!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtsearch.Text.Trim();
            dgvstd.CurrentCell = null;

            foreach (DataGridViewRow row in dgvstd.Rows)
            {

                if (row.IsNewRow)
                    continue;

                if (row.Cells["STUDENT_NAME"].Value != null &&
                    row.Cells["STUDENT_NAME"].Value.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
            txtsearch.ForeColor = Color.Black;

        }

        private void txtstudentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtstudentphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstudentphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
        
    }
    

