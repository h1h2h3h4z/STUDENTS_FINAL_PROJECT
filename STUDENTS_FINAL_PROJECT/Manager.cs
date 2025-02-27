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
    public partial class Manager : Form
    {
        private string adminName;
        private int adminid;
        public Manager(string adminname,int adminid)
        {
            InitializeComponent();
            RoundForm(this, 30);
            this.adminName = adminname;
            this.adminid = adminid;
            lblname.Text = adminname.ToUpper();

            // Pass adminName to UserControls

            ucStudents1.SetAdminName(adminName);
            ucStudents1.SetAdminId(adminid);
            uCteachers1.SetAdminName(adminName);
            uCteachers1.SetAdminId(adminid);
            uCcourses1.SetAdminName(adminName);
            uCcourses1.SetAdminId(adminid);
            uCenrollement1.SetAdminName(adminName);
            uCenrollement1.SetAdminId(adminid);
        }

        private void Manager_Load(object sender, EventArgs e)
        {
          
            uCdashboard1.Show();
            uCteachers1.Hide();
            ucStudents1.Hide();
            uCcourses1.Hide();
            uCenrollement1.Hide();
        }
        public static void RoundForm(Form targetForm, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            // Create rounded rectangle path
            path.AddArc(0, 0, diameter, diameter, 180, 90); // Top-left
            path.AddArc(targetForm.Width - diameter, 0, diameter, diameter, 270, 90); // Top-right
            path.AddArc(targetForm.Width - diameter, targetForm.Height - diameter, diameter, diameter, 0, 90); // Bottom-right
            path.AddArc(0, targetForm.Height - diameter, diameter, diameter, 90, 90); // Bottom-left
            path.CloseFigure();

            // Apply rounded region to the form
            targetForm.Region = new Region(path);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            uCdashboard1.Show();
            uCteachers1.Hide();
            uCdashboard1.RefreshDashBoard();
            ucStudents1.Hide();
            uCcourses1.Hide();
            uCenrollement1.Hide();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {

            uCdashboard1.Hide();
            uCteachers1.Hide();
            ucStudents1.Show();
            uCcourses1.Hide();
            uCenrollement1.Hide();

        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucStudents1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnteachers_Click(object sender, EventArgs e)
        {
            uCdashboard1.Hide();
            uCteachers1.Show();
            ucStudents1.Hide();
            uCcourses1.Hide();
            uCenrollement1.Hide();
        }

        private void btncourses_Click(object sender, EventArgs e)
        {
            uCdashboard1.Hide();
            uCteachers1.Hide();
            ucStudents1.Hide();
            uCcourses1.Show();
            uCenrollement1.Hide();
        }

        private void btnenrollement_Click(object sender, EventArgs e)
        {
            uCdashboard1.Hide();
            uCteachers1.Hide();
            ucStudents1.Hide();
            uCcourses1.Hide();
            uCenrollement1.Show();
            uCenrollement1.refreshdgv();
            uCenrollement1.FillCourse();
            uCenrollement1.FillStudents();
            uCenrollement1.FillTeacher();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are you sure you want to logout ?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) {
                Role role = new Role();
                role.Show();
                this.Close();
            }
           
        }
    }
}
