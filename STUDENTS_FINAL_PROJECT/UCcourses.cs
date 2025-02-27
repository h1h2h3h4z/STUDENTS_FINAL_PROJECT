using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENTS_FINAL_PROJECT
{
    public partial class UCcourses : UserControl
    {
        public string AdminName { get; set; }
        public int Adminid { get; set; }
        int _courseid = -1;
        public UCcourses()
        {
            InitializeComponent();
            ApplyAdvancedStyle(dgvcourse);
            refreshdgv();
            ApplyButtonStyle(btnnew, Color.Blue, Color.DarkBlue);
            ApplyButtonStyle(btndelete, Color.Red, Color.DarkRed);
            ApplyButtonStyle(btnupdate, Color.Black, Color.Black);
            ApplyButtonStyle(btnadd, Color.Green, Color.DarkGreen);
        }
        public void SetAdminName(string adminname)
        {
            AdminName = adminname;
        }
        public void SetAdminId(int adminid)
        {
            Adminid = adminid;
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
        private void btnnew_Click(object sender, EventArgs e)
        {
            txtscoursename.Text = "";
            _courseid = -1;
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


        private void refreshdgv()
        {
            COURSES course = new COURSES();
            DataTable dt = course.Fillcourses();
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvcourse.Show();
                dgvcourse.DataSource = dt;
                dgvcourse.Columns["COURSE_ID"].Visible = false;
                dgvcourse.Columns["COURSE_NAME"].HeaderText = "Course Name";
                dgvcourse.Columns["ADMIN_NAME"].HeaderText = "Admin Name";
                dgvcourse.Columns["DATE_CREATED"].HeaderText = "Created At";
                dgvcourse.Columns["DATE_UPDATED"].HeaderText = "Updated In";
                dgvcourse.Columns["ADMIN_ID"].Visible = false;
                dgvcourse.Columns["ADMIN_ID1"].Visible = false;
                dgvcourse.Columns["ADMIN_PASSWORD"].Visible = false;

            }
            else
            {
                dgvcourse.Hide();
            }

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtscoursename.Text != "")
            {
                COURSES course = new COURSES();
                if (course.AddCourse(txtscoursename.Text, Adminid)) {

                    MessageBox.Show("Course Added Successfully!");
                    txtscoursename.Text = "";
                    _courseid = -1;
                    refreshdgv();
                }
                else
                {
                    MessageBox.Show("Error in Adding course");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields!", "Error");
            }
        }

        private void dgvcourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            DataGridViewRow row = dgvcourse.Rows[e.RowIndex];
            _courseid = Convert.ToInt32(row.Cells["COURSE_ID"].Value);
            txtscoursename.Text = row.Cells["COURSE_NAME"].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (_courseid != -1)
            {
                if (txtscoursename.Text != "")
                {
                    COURSES course = new COURSES();
                    if (course.UpdateCourse(_courseid, txtscoursename.Text, Adminid))
                    {

                        MessageBox.Show("Updated Suceessfully!");
                        refreshdgv();
                        txtscoursename.Text = "";
                        _courseid = -1;

                    }
                    else
                    {
                        MessageBox.Show("Error in Updating !");
                    }
                }

                else
                {
                    MessageBox.Show("Fields not be empty!");
                }
                }
                else
                {
                    MessageBox.Show("Select Course to update " +
                        "!");
                }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (_courseid != -1) {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Are you sure want to delete this course", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes) {
                    COURSES course = new COURSES();
                    if (course.DeleteCourse(_courseid))
                    {
                        MessageBox.Show("Deleted successfully !");
                        txtscoursename.Text = "";
                        refreshdgv();
                        _courseid = -1;
                    }
                }

               
            }
            else
            {
                MessageBox.Show("No row Selected !");
            }
        }
    }
}
