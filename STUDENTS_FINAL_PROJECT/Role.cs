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
    public partial class Role : Form
    {
        public Role()

        {
            InitializeComponent();
            uCuser1.Hide();
            picexit.BorderStyle = BorderStyle.None;
        }

        private void Role_Load(object sender, EventArgs e)
        {
            ucAdminregister1.Show();
           
            
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {

        }
        public void Showuc(string re)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
           
        }

        private void btnteacher_Click_1(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            ucAdminregister1.Hide();
            picexit.Hide();
           
            uCuser1.Show();
        }

        private void picexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void uCuser1_Load(object sender, EventArgs e)
        {

        }
    }
}
