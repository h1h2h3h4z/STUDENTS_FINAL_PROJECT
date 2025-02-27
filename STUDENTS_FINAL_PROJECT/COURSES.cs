using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_FINAL_PROJECT
{
    internal class COURSES
    {
        #region
        private int COURSE_ID { get; set; }//0
        private string COURSE_NAME { get; set; }//1
        private DateTime DATE_CREATED { get; set; }//2
        private DateTime DATE_UPDATED { get; set; }//2
        private int ADMIN_ID { get; set; }//2
        #endregion
        SqlConnection _conn = new SqlConnection(@"Data Source=ATLAS-P0SAIV6D2\HUSSEIN;Initial Catalog=STUDENT_REGISTERY;Integrated Security=True;Encrypt=False");

        public bool AddCourse(string courseName, int adminId)
        {
            bool result = false;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();

            };
            try
            {
                string query = "INSERT INTO COURSES (COURSE_NAME,DATE_CREATED,ADMIN_ID) VALUES(@coursename,@datecreated,@adminid)";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@coursename", courseName);
                    cmd.Parameters.AddWithValue("@datecreated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@adminid", adminId);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        result = true;

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
            return result;
        }
        public DataTable Fillcourses()
        {
            DataTable dt = new DataTable();
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
              
            }
            try
            {
                string Selectquery = "SELECT * FROM COURSES INNER JOIN ADMINS ON COURSES.ADMIN_ID = ADMINS.ADMIN_ID";
                using (SqlCommand cmd = new SqlCommand(Selectquery, _conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                }
            }
            catch (Exception ex) { 
            }
            finally {  _conn.Close(); }
            return dt;
        }
        public bool UpdateCourse(int courseid,string courseName, int adminId)
        {
            bool result = false;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();

            };
            try
            {
                string query = "UPDATE COURSES set COURSE_NAME=@coursename, DATE_UPDATED=@dateupdated , ADMIN_ID=@adminid  where COURSE_ID=@courseid";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@coursename", courseName);
                    cmd.Parameters.AddWithValue("@dateupdated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@adminid", adminId);
                    cmd.Parameters.AddWithValue("@courseid", courseid);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        result = true;

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
            return result;
        }
        public bool DeleteCourse(int courseid)
        {
            bool result = false;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();

            };
            try
            {
                string query = "DELETE FROM COURSES WHERE COURSE_ID=@courseid";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    
                    cmd.Parameters.AddWithValue("@courseid", courseid);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        result = true;

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
            return result;
        }
    }
}

