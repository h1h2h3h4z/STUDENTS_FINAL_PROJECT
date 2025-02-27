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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            this.Hide();
            role.Show();
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
            if(txtadminname.Text.Trim()!="" && txtadminpassword.Text.Trim() != "")
            {
                if (admin.CheckAdmin(txtadminname.Text.Trim(),txtadminpassword.Text.Trim())) 
                {
                    MessageBox.Show("Success Registry","Success");
                    int adminid =admin.getadminid(txtadminname.Text.Trim(), txtadminpassword.Text.Trim());
                    string adminname = txtadminname.Text;
                    Manager manager = new Manager(adminname,adminid);
                    manager.Show();
                    
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

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
