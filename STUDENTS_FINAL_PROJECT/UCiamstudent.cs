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
    public partial class UCiamstudent : UserControl
    {
        public UCiamstudent()
        {
            InitializeComponent();
        }

        private void btnloginstudent_Click(object sender, EventArgs e)
        {
            if(txtstudentemail.Text!="" && txtstudentpassword.Text != "")
            {
                STUDENT_LOGIN std = new STUDENT_LOGIN();

                if (std.CheckStudent(txtstudentemail.Text, txtstudentpassword.Text)) {
                    MessageBox.Show("Student Registry Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StudentPage studentPage = new StudentPage(std.getStudentid(txtstudentemail.Text,txtstudentpassword.Text));
                    studentPage.Show();
                    Form parentForm = this.FindForm(); // Finds the parent form (Role)
                    if (parentForm != null)
                    {
                        parentForm.Hide();  // Option 1: Just hide the Role form
                                            // parentForm.Close(); // Option 2: Completely close the Role form
                    }

                }
                else
                {
                    MessageBox.Show("Student Not Founded!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Fill All Fields!", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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
    }
}
