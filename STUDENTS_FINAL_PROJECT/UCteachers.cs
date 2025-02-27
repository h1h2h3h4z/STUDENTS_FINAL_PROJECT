using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace STUDENTS_FINAL_PROJECT
{
    public partial class UCteachers : UserControl
    {
        public UCteachers()
        {
            InitializeComponent();
            ApplyAdvancedStyle(dgvteacher);
            refreshdgv();
            ApplyButtonStyle(btnnew, Color.Blue, Color.DarkBlue);
            ApplyButtonStyle(btnimport, Color.Red, Color.Red);
            ApplyButtonStyle(btndelete, Color.Red, Color.DarkRed);
            ApplyButtonStyle(btnupdate, Color.Black, Color.Black);
            ApplyButtonStyle(btnadd, Color.Green, Color.DarkGreen);
        }

        public string AdminName { get; set; }
        public int Adminid { get; set; }
        private int _thid = -1;
        private string _originalImagePath; 

        private void btngenerateemail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtteacherid.Text) && !string.IsNullOrWhiteSpace(txtteachername.Text))
            {
                string sanitizedName = txtteachername.Text.Trim().ToUpper().Replace(" ", "_");
                txtteacheremail.Text = $"{txtteacherid.Text}-{sanitizedName}@UN.com";
            }
            else
            {
                MessageBox.Show("Please enter teacher ID and Name first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SetAdminName(string adminName)
        {
            AdminName = adminName;
        }

        public void SetAdminId(int adminid)
        {
            Adminid = adminid;
        }

        private void refreshdgv()
        {
            TEACHERS teacher = new TEACHERS();
            DataTable dt = teacher.Filldata();

            if (dt != null && dt.Rows.Count > 0)
            {
                dgvteacher.Show();
                dgvteacher.DataSource = dt;

                // Set column headers
                dgvteacher.Columns["TEACHER_ID"].HeaderText = "ID";
                dgvteacher.Columns["TEACHER_NAME"].HeaderText = "NAME";
                dgvteacher.Columns["TEACHER_EMAIL"].HeaderText = "EMAIL";
                dgvteacher.Columns["TEACHER_PASSWORD"].HeaderText = "PASSWORD";
                dgvteacher.Columns["TEACHER_PHONE"].HeaderText = "PHONE";
                dgvteacher.Columns["TEACHER_GENDER"].HeaderText = "GENDER";
                dgvteacher.Columns["TEACHER_BIRTHDATE"].HeaderText = "BIRTHDATE";

                // Hide unnecessary columns
                dgvteacher.Columns["TEACHER_IMAGE"].Visible = false;
                dgvteacher.Columns["DATE_CREATED"].Visible = false;
                dgvteacher.Columns["DATE_UPDATED"].Visible = false;
                dgvteacher.Columns["ADMIN_ID"].Visible = false;
                dgvteacher.Columns["ADMIN_ID1"].Visible = false;
                dgvteacher.Columns["ADMIN_PASSWORD"].Visible = false;

                dgvteacher.Columns["ADMIN_NAME"].HeaderText = "ADMIN";
            }
            else
            {
                dgvteacher.Hide();
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            Clearfields();
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


        private void Clearfields()
        {
            txtteacherid.Text = "";
            txtteachername.Text = "";
            txtteacheremail.Text = "";
            txtteacherphone.Text = "";
            txtteacherpassword.Text = "";

            // Dispose of the current image before clearing it
            if (teacherpicture.Image != null)
            {
                teacherpicture.Image.Dispose();
                teacherpicture.Image = null;
            }

            teacherpicture.ImageLocation = null; // Reset image location
            teacherbirthdate.Value = DateTime.Now;
            _thid = -1;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            TEACHERS teacher = new TEACHERS();

            if (string.IsNullOrWhiteSpace(txtteacherid.Text) ||
                string.IsNullOrWhiteSpace(txtteachername.Text) ||
                string.IsNullOrWhiteSpace(txtteacherpassword.Text) ||
                string.IsNullOrWhiteSpace(txtteacheremail.Text) ||
                string.IsNullOrWhiteSpace(txtteacherphone.Text) ||
                string.IsNullOrWhiteSpace(cbgender.Text) ||
                teacherbirthdate.Value == null || teacherpicture.Image == null)
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            if (teacher.checkTEACHERid(Convert.ToInt32(txtteacherid.Text),txtteacheremail.Text))
            {
                string savePath = Path.Combine(Application.StartupPath, "Images", $"{txtteachername.Text}-{txtteacherid.Text}{Path.GetExtension(teacherpicture.ImageLocation)}");

                try
                {
                    // Ensure the "Images" directory exists
                    Directory.CreateDirectory(Path.GetDirectoryName(savePath));

                    // Save the new image
                    File.Copy(teacherpicture.ImageLocation, savePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (teacher.AddTEACHER(
                    Convert.ToInt32(txtteacherid.Text),
                    txtteachername.Text,
                    txtteacherpassword.Text,
                    txtteacheremail.Text,
                    txtteacherphone.Text,
                    cbgender.Text,
                    teacherbirthdate.Value,
                    savePath,
                    Adminid))
                {
                    MessageBox.Show("Teacher Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshdgv();
                    Clearfields();
                }
                else
                {
                    MessageBox.Show("Error adding teacher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Teacher ID OR EMAIL already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        teacherpicture.ImageLocation = dialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvteacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }

            DataGridViewRow row = dgvteacher.Rows[e.RowIndex];
            _thid = Convert.ToInt32(row.Cells["TEACHER_ID"].Value);
            txtteacherid.Text = row.Cells["TEACHER_ID"].Value.ToString();
            txtteachername.Text = row.Cells["TEACHER_NAME"].Value.ToString();
            txtteacheremail.Text = row.Cells["TEACHER_EMAIL"].Value.ToString();
            txtteacherpassword.Text = row.Cells["TEACHER_PASSWORD"].Value.ToString();
            txtteacherphone.Text = row.Cells["TEACHER_PHONE"].Value.ToString();
            cbgender.Text = row.Cells["TEACHER_GENDER"].Value.ToString();
            teacherbirthdate.Value = Convert.ToDateTime(row.Cells["TEACHER_BIRTHDATE"].Value); // Use Value instead of Text
            string imagePath = row.Cells["TEACHER_IMAGE"].Value?.ToString();
            _originalImagePath = imagePath; 

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                teacherpicture.Image = Image.FromFile(imagePath);
                teacherpicture.ImageLocation = imagePath; 
            }
            else
            {
                teacherpicture.Image = null;
                teacherpicture.ImageLocation = null;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (_thid == -1)
            {
                MessageBox.Show("Select teacher to delete");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete teacher?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    TEACHERS teacher = new TEACHERS();
                    if (teacher.DeleteTEACHER(_thid))
                    {
                        MessageBox.Show("Delete successfully!");
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            TEACHERS teacher = new TEACHERS();
            string savePath = _originalImagePath; 

            if (!string.IsNullOrWhiteSpace(teacherpicture.ImageLocation) && teacherpicture.ImageLocation != _originalImagePath)
            {
                savePath = Path.Combine(Application.StartupPath, "Images", $"{txtteachername.Text}-{txtteacherid.Text}{Path.GetExtension(teacherpicture.ImageLocation)}");

                try
                {
                    
                    Directory.CreateDirectory(Path.GetDirectoryName(savePath));

                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }

                    File.Copy(teacherpicture.ImageLocation, savePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtteacherid.Text) ||
               string.IsNullOrWhiteSpace(txtteachername.Text) ||
               string.IsNullOrWhiteSpace(txtteacherpassword.Text) ||
               string.IsNullOrWhiteSpace(txtteacheremail.Text) ||
               string.IsNullOrWhiteSpace(txtteacherphone.Text) ||
               string.IsNullOrWhiteSpace(cbgender.Text) ||
               teacherbirthdate.Value == null || teacherpicture.Image == null)
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (teacher.UpdateTEACHER(
                Convert.ToInt32(txtteacherid.Text),
                txtteachername.Text,
                txtteacherpassword.Text,
                txtteacheremail.Text,
                txtteacherphone.Text,
                cbgender.Text,
                teacherbirthdate.Value,
                savePath))
            {
                MessageBox.Show("Teacher Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshdgv();
                Clearfields();
            }
            else
            {
                MessageBox.Show("Error updating teacher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtteacherid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtteacherphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
    {
                e.Handled = true; 
            }
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {

            if (showpassword.Checked)
            {
                txtteacherpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtteacherpassword.UseSystemPasswordChar = true;

            }
        }
    }
}