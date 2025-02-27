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
    public partial class UCAdminregister : UserControl
    {
        public UCAdminregister()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                txtadminpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtadminpassword.UseSystemPasswordChar = true;

            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            ADMINS admin = new ADMINS();
            if (txtadminname.Text.Trim() != "" && txtadminpassword.Text.Trim() != "")
            {
                if (admin.CheckAdmin(txtadminname.Text.Trim(), txtadminpassword.Text.Trim()))
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int adminid = admin.getadminid(txtadminname.Text.Trim(), txtadminpassword.Text.Trim());
                    string adminname = txtadminname.Text;
                    
                    Manager manager = new Manager(adminname, adminid);
                    manager.Show();
                    Form parentForm = this.FindForm(); // Finds the parent form (Role)
                    if (parentForm != null)
                    {
                        parentForm.Hide();  // Option 1: Just hide the Role form
                                            // parentForm.Close(); // Option 2: Completely close the Role form
                    }

                }
                else
                {
                    MessageBox.Show("Admin Are not exist !", "Missing");
                }
            }
            else
            {
                MessageBox.Show("All feilds are required !", "Error");
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnnotadmin_Click(object sender, EventArgs e)
        {
            UCuser uc = new UCuser();
            this.Controls.Clear();  // Optional: Clear the current controls
            this.Controls.Add(uc);
        }

        private void UCAdminregister_Load(object sender, EventArgs e)
        {
           
        }
       
    }
}
