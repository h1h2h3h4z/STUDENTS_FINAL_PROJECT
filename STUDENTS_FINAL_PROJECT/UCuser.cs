using System;
using System.Windows.Forms;

namespace STUDENTS_FINAL_PROJECT
{
    public partial class UCuser : UserControl
    {
        public UCuser()
        {
            InitializeComponent();
            uCiamstudent1.Show();
            uCiamteacher1.Hide();
            btniamteacher.Show();
            btniamstudent.Hide();
            lbliamadmins.Show();
            lbliamadmint.Hide();
        }

        private void uCiamteacher1_Load(object sender, EventArgs e)
        {

        }

        private void btniamteacher_Click(object sender, EventArgs e)
        {
            uCiamstudent1.Hide();
            uCiamteacher1.Show();
            btniamteacher.Hide();
            btniamstudent.Show();
            lbliamadmint.Show();
            lbliamadmins.Hide();
        }

        private void btniamstudent_Click(object sender, EventArgs e)
        {
            uCiamstudent1.Show();
            uCiamteacher1.Hide();
            btniamteacher.Show();
            btniamstudent.Hide();
            lbliamadmint.Hide();
            lbliamadmins.Show();
        }

        private void lbliamadmins_Click(object sender, EventArgs e)
        {
            UCAdminregister uca = new UCAdminregister();
            this.Controls.Clear();
            this.Controls.Add(uca);
        }

        private void lbliamadmint_Click(object sender, EventArgs e)
        {
            
            UCAdminregister uca = new UCAdminregister();
            this.Controls.Clear();
            this.Controls.Add(uca);
        }
    }
}
