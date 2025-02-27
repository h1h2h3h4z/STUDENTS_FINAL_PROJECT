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
    public partial class UCiamteacher : UserControl
    {
        public UCiamteacher()
        {
            InitializeComponent();
        }

        private void btnteacherlogin_Click(object sender, EventArgs e)
        {
            if (txtteacheremail.Text != "" && txtteacherpassword.Text != "")
            {
                TEACHERS th = new TEACHERS();

                if (th.CheckTeacherEmail(txtteacheremail.Text, txtteacherpassword.Text))
                {
                    MessageBox.Show("Teacher Registry Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TeacherPage teacherpage = new TeacherPage(th.getTeacherid(txtteacheremail.Text, txtteacherpassword.Text));
                    teacherpage.Show();
                    Form parentForm = this.FindForm(); 
                    if (parentForm != null)
                    {
                        parentForm.Hide();  
                    }

                }
                else
                {
                    MessageBox.Show("Teacher Not Founded!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Fill All Fields!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void panelteacher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
