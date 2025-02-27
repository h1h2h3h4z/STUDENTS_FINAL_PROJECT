using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENTS_FINAL_PROJECT
{
    public partial class UCdashboard : UserControl
    {
        public UCdashboard()
        {
            InitializeComponent();
            RefreshDashBoard();
        }
        public void RefreshDashBoard()
        {
            Dashboardinformation dh = new Dashboardinformation();
            lbltotalstudents.Text = dh.getStudentsnumber().ToString();
            lbltotalteachers.Text = dh.getTeachersnumber().ToString();
            lbltotalcourses.Text = dh.getCoursesnumber().ToString();

        }
        private void UCdashboard_Load(object sender, EventArgs e)
        {
            RefreshDashBoard();
        }
    }
}
