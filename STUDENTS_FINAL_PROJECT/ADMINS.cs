using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_FINAL_PROJECT
{
    internal class ADMINS
    {
        SqlConnection _conn = new SqlConnection(@"Data Source=ATLAS-P0SAIV6D2\HUSSEIN;Initial Catalog=STUDENT_REGISTERY;Integrated Security=True;Encrypt=False");
        private int ADMIN_ID {  get; set; }
        private string ADMIN_NAME { get; set; }
        private string ADMIN_PASSWORD { get; set; }
        public bool CheckAdmin(string adminname,string adminpassword)
        {
            bool success = false;
             if(_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string insertQuery = "SELECT COUNT(ADMIN_ID) FROM ADMINS WHERE ADMIN_NAME=@adminname AND ADMIN_PASSWORD=@adminpassword";
                using (SqlCommand cmd = new SqlCommand(insertQuery, _conn)) 
                
                {
                    cmd.Parameters.AddWithValue("@adminname", adminname);
                    cmd.Parameters.AddWithValue("@adminpassword", adminpassword);
                    int checkadmin = Convert.ToInt32(cmd.ExecuteScalar());
                    if (checkadmin > 0) 
                    { 
                    success = true;
   
                    }
                
                }
            }
            catch (Exception ex) { 
            
            }
            finally
            {
                _conn.Close();
            }

            return success;
        }
        public int getadminid(string adminname, string adminpassword)
        {
            int adminid = 0;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string insertQuery = "SELECT ADMIN_ID FROM ADMINS WHERE ADMIN_NAME=@adminname AND ADMIN_PASSWORD=@adminpassword";
                using (SqlCommand cmd = new SqlCommand(insertQuery, _conn))

                {
                    cmd.Parameters.AddWithValue("@adminname", adminname);
                    cmd.Parameters.AddWithValue("@adminpassword", adminpassword);

                    object result = cmd.ExecuteScalar();
                    if (result != null) {
                        adminid = Convert.ToInt32(result.ToString());

                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }

           return adminid;
        }
    }
}
