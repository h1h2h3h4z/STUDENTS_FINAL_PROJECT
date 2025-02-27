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
    public partial class UCenrollement : UserControl
    {
        public UCenrollement()
        {
            InitializeComponent();
            FillStudents();
            FillTeacher();
            FillCourse();
            refreshdgv();
            ApplyAdvancedStyle(dgvenrolle);
            ApplyButtonStyle(btnnew, Color.Blue, Color.DarkBlue);
           Clearfields();
            ApplyButtonStyle(btndelete, Color.Red, Color.DarkRed);
           
            ApplyButtonStyle(btnadd, Color.Green, Color.DarkGreen);

        }
        int _enrolleid=-1;
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name; // Display Name in the ComboBox
            }
        }
        private int AdminId { get; set; }
        private string AdminName { get; set; }

        public class Teacher
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name; // Display Name in the ComboBox
            }
           
        }
        public void SetAdminName(string adminname)

        {
            AdminName = adminname;
        }
        public void SetAdminId(int adminid)

        {
            AdminId = adminid;
        }
        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name; // Display Name in the ComboBox
            }
        }
        public void FillStudents()
        {
            try
            {
                ENROLLEMENT en = new ENROLLEMENT();
                var students = en.FillStudents(); // Assuming this method returns a list of students.

                cbstudents.Items.Clear(); // Clear existing items

                if (students != null && students.Any())
                {
                    cbstudents.Items.Add(new Student { Id = 0, Name = "Select Student" });

                    // Placeholder for selection
                    foreach (var student in students)
                    {
                        cbstudents.Items.Add(new Student { Id = student.Id, Name = student.Name });
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
            cbstudents.DisplayMember = "Name";
            cbstudents.ValueMember = "Id";
           
            cbstudents.SelectedValue = 0;
            
            
        }
        public void FillTeacher()
        {
            try
            {
                ENROLLEMENT en = new ENROLLEMENT();
                var teachers = en.FillTeachers();
                cbteacher.Items.Clear();
                if (teachers != null)
                {
                    cbteacher.Items.Add(new Teacher { Id = 0, Name = "Select Teacher" });
                    foreach (var teacher in teachers)
                    {
                        cbteacher.Items.Add(new Teacher { Id = teacher.Id, Name = teacher.Name });

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");

            }
            cbteacher.DisplayMember = "Name";
            cbteacher.ValueMember = "Id";
            cbteacher.SelectedValue = 0;
        }
        public void FillCourse()
        {
            try
            {
                ENROLLEMENT en = new ENROLLEMENT();
                var courses = en.FillCourses(); 
                cbcourse.Items.Clear(); 

                if (courses != null && courses.Any())
                {

                    cbcourse.Items.Add(new Course { Id = 0, Name = "Select Course" }); 
                    foreach (var course in courses)
                    {
                        cbcourse.Items.Add(new Course { Id = course.Id, Name = course.Name });
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
            cbcourse.DisplayMember = "Name";
            cbcourse.ValueMember = "Id";
            
            cbcourse.SelectedValue = 0;
        }
        public void refreshdgv()
        {
            ENROLLEMENT en = new ENROLLEMENT();
            DataTable dt = en.Filldata();
            if (dt != null && dt.Rows.Count > 0)
            {


                dgvenrolle.Show();
                dgvenrolle.DataSource = dt;

                dgvenrolle.Columns["STUDENT_ID"].HeaderText = "STUDENT ID";
                dgvenrolle.Columns["STUDENT_NAME"].HeaderText = "STUDENT NAME";
                dgvenrolle.Columns["STUDENT_EMAIL"].Visible = false;
                dgvenrolle.Columns["STUDENT_PASSWORD"].Visible = false;
                dgvenrolle.Columns["STUDENT_PHONE"].Visible = false;
                dgvenrolle.Columns["STUDENT_GENDER"].Visible = false;
                dgvenrolle.Columns["STUDENT_BIRTHDATE"].Visible = false;

                // Hide unnecessary columns
                dgvenrolle.Columns["STUDENT_IMAGE"].Visible = false;
                dgvenrolle.Columns["STUDENT_CREATED"].Visible = false;
                dgvenrolle.Columns["STUDENT_UPDATED"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID1"].Visible = false;
                dgvenrolle.Columns["ADMIN_PASSWORD"].Visible = false;
                dgvenrolle.Columns["ADMIN_NAME"].HeaderText = "ADMIN NAME";
                dgvenrolle.Columns["COURSE_ID"].Visible = false;
                dgvenrolle.Columns["COURSE_NAME"].HeaderText = "Course Name";

                dgvenrolle.Columns["DATE_CREATED"].Visible = false;
                dgvenrolle.Columns["DATE_UPDATED"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID1"].Visible = false;
                dgvenrolle.Columns["ADMIN_PASSWORD"].Visible = false;
                dgvenrolle.Columns["TEACHER_ID"].HeaderText = "TEACHER ID";
                dgvenrolle.Columns["TEACHER_NAME"].HeaderText = "TEACHER NAME";
                dgvenrolle.Columns["TEACHER_EMAIL"].Visible = false;
                dgvenrolle.Columns["TEACHER_PASSWORD"].Visible = false;
                dgvenrolle.Columns["TEACHER_PHONE"].Visible = false;
                dgvenrolle.Columns["TEACHER_GENDER"].Visible = false;
                dgvenrolle.Columns["TEACHER_BIRTHDATE"].Visible = false;

                // Hide unnecessary columns
                dgvenrolle.Columns["TEACHER_IMAGE"].Visible = false;
                dgvenrolle.Columns["DATE_CREATED"].Visible = false;
                dgvenrolle.Columns["DATE_UPDATED"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID1"].Visible = false;
                dgvenrolle.Columns["ADMIN_PASSWORD"].Visible = false;

                dgvenrolle.Columns["ENROLLEMENT_CREATED"].Visible = false;

                dgvenrolle.Columns["STUDENT_ID1"].Visible = false;
                dgvenrolle.Columns["TEACHER_ID1"].Visible = false;
                dgvenrolle.Columns["COURSE_ID1"].Visible = false;
                dgvenrolle.Columns["DATE_CREATED1"].Visible = false;
                dgvenrolle.Columns["DATE_UPDATED1"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID4"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID2"].Visible = false;
                dgvenrolle.Columns["ADMIN_ID3"].Visible = false;
            }
            else
            {
                dgvenrolle.Hide();
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
        private void btnnew_Click(object sender, EventArgs e)
        {
            Clearfields();
        }
        public void Clearfields()
        {
            if (cbcourse.Items.Cast<Course>().Any(c => c.Id == 0))
            {
                cbcourse.SelectedItem = cbcourse.Items.Cast<Course>().First(c => c.Id == 0);
            }
            else
            {
                cbcourse.SelectedIndex = -1;
            }
            if (cbstudents.Items.Cast<Student>().Any(s => s.Id == 0))
            {
                cbstudents.SelectedItem = cbstudents.Items.Cast<Student>().First(s => s.Id == 0);
            }
            else
            {
                cbstudents.SelectedIndex = -1;
            }
            if (cbteacher.Items.Cast<Teacher>().Any(t => t.Id == 0))
            {
                cbteacher.SelectedItem = cbteacher.Items.Cast<Teacher>().First(t => t.Id == 0);
            }
            else
            {
                cbteacher.SelectedIndex = -1;
            }
            _enrolleid = -1;
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


        private void cbstudents_SelectedIndexChanged(object sender, EventArgs e)
        {

            //var selectedStudent = cbstudents.SelectedItem as Student;
            //if (selectedStudent != null && selectedStudent.Id != 0)
            //{
            //    // You can do something with the selected student, like displaying more information
            //    MessageBox.Show($"Student {selectedStudent.Name} selected with ID: {selectedStudent.Id}");
            //}
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int selectestudentId=0;
            int selecteteacherId=0;
            int selectcourseId=0;
            if (cbstudents.SelectedItem is Student selectedStudent && selectedStudent.Id != 0)
            {
                selectestudentId = selectedStudent.Id;

            }
            if (cbteacher.SelectedItem is Teacher selectedTeacher && selectedTeacher.Id != 0)
            {
                selecteteacherId = selectedTeacher.Id;

            }
            if (cbcourse.SelectedItem is Course selectedCourse && selectedCourse.Id != 0)
            {
                selectcourseId = selectedCourse.Id;

            }
            if(selectestudentId != 0 && selecteteacherId != 0 && selectcourseId != 0)
            {
                ENROLLEMENT en = new ENROLLEMENT();
                if (en.AddEnrolle(selectestudentId, selecteteacherId,selectcourseId,AdminId))
                
                {
                    MessageBox.Show("Added Succeessfully!");
                    Clearfields();
                    refreshdgv();
                }
                else{
                    MessageBox.Show("Error in Adding");
                }
            }
            else
            {
                MessageBox.Show("Select all fields");
            }


        }

        private void dgvenrolle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; 

            DataGridViewRow row = dgvenrolle.Rows[e.RowIndex];

            _enrolleid = Convert.ToInt32(row.Cells["ENROLLEMENT_ID"].Value); 
            int selectedStudentId = Convert.ToInt32(row.Cells["STUDENT_ID"].Value); 
            int selectedTeacherId = row.Cells["TEACHER_ID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["TEACHER_ID"].Value) : 0; // Handle nulls
            int selectedCourseId = row.Cells["COURSE_ID"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["COURSE_ID"].Value) : 0;

            if (cbstudents.Items.Cast<Student>().Any(s => s.Id == selectedStudentId))
                cbstudents.SelectedItem = cbstudents.Items.Cast<Student>().First(s => s.Id == selectedStudentId);

            if (cbteacher.Items.Cast<Teacher>().Any(t => t.Id == selectedTeacherId))
                cbteacher.SelectedItem = cbteacher.Items.Cast<Teacher>().First(t => t.Id == selectedTeacherId);

            if (cbcourse.Items.Cast<Course>().Any(c => c.Id == selectedCourseId))
                cbcourse.SelectedItem = cbcourse.Items.Cast<Course>().First(c => c.Id == selectedCourseId);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (_enrolleid == -1)
            {
                MessageBox.Show("No row selected");
                return;
            }
            else
            {
                ENROLLEMENT en = new ENROLLEMENT();
                if (en.DeleteEnrolle(_enrolleid))
                {
                    MessageBox.Show("Deleted Successfully !","Success");
                    refreshdgv();
                    Clearfields();
                }
            }
        }
    }
}