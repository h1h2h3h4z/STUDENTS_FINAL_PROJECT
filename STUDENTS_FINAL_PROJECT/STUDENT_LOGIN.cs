using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_FINAL_PROJECT
{
    internal class STUDENT_LOGIN
    {
        SqlConnection _conn = new SqlConnection(@"Data Source=ATLAS-P0SAIV6D2\HUSSEIN;Initial Catalog=STUDENT_REGISTERY;Integrated Security=True;Encrypt=False");
        public bool CheckStudent(string studentemail, string studentpassword)
        {
            bool success = false;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string insertQuery = "SELECT COUNT(STUDENT_ID) FROM STUDENTS WHERE STUDENT_EMAIL=@studentemail AND STUDENT_PASSWORD=@studentpassword";
                using (SqlCommand cmd = new SqlCommand(insertQuery, _conn))

                {
                    cmd.Parameters.AddWithValue("@studentemail", studentemail);
                    cmd.Parameters.AddWithValue("@studentpassword", studentpassword);
                    int checkadmin = Convert.ToInt32(cmd.ExecuteScalar());
                    if (checkadmin > 0)
                    {
                        success = true;

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

            return success;
        }
        public int getStudentid(string studentemail, string studentpassword)
        {
            int studentid = 0;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string insertQuery = "SELECT STUDENT_ID FROM STUDENTS WHERE STUDENT_EMAIL=@studentemail AND STUDENT_PASSWORD=@studentpassword";
                using (SqlCommand cmd = new SqlCommand(insertQuery, _conn))

                {
                    cmd.Parameters.AddWithValue("@studentemail", studentemail);
                    cmd.Parameters.AddWithValue("@studentpassword", studentpassword);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        studentid = Convert.ToInt32(result.ToString());

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

            return studentid;
        }
    }
}
