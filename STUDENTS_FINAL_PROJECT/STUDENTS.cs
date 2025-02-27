using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_FINAL_PROJECT
{
    internal class STUDENTS
    {
        #region
        private int STUDENT_ID { get; set; }//0
        private string STUDENT_NAME { get;  set; }//1
        private string STUDENT_EMAIL { get;    set; }//2
        private string STUDENT_PASSWORD { get; set; }//3
        private string STUDENT_PHONE { get; set; }//4
        private string STUDENT_GENDER { get; set; }//5
        private DateTime STUDENT_BIRTHDATE { get; set; }//6
        private string STUDENT_IMAGE { get; set; }//7
        private DateTime CREATED_DATE { get; set; }//8
        private DateTime UPDATED_DATE { get; set; }//9
        private int ADMIN_ID { get; set; }//10
        #endregion
        SqlConnection _conn = new SqlConnection(@"Data Source=ATLAS-P0SAIV6D2\HUSSEIN;Initial Catalog=STUDENT_REGISTERY;Integrated Security=True;Encrypt=False");

        public DataTable Filldata()
        {
            DataTable dt = new DataTable();
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();

            }
            try
            {
                string selectquery = "SELECT * from STUDENTS inner join ADMINS ON STUDENTS.ADMIN_ID = ADMINS.ADMIN_ID;";
                using (SqlCommand cmd = new SqlCommand(selectquery, _conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :" + ex);
            }
            finally
            {
                _conn.Close();

            }
            return dt;
        }
        public bool checkstudentid(string studentid,string studentemail)
        {
            bool success = true;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string insertQuery = "SELECT COUNT(STUDENT_ID) FROM STUDENTS WHERE STUDENT_ID=@studentid OR STUDENT_EMAIL=@studentemail";
                using (SqlCommand cmd = new SqlCommand(insertQuery, _conn))

                {
                    cmd.Parameters.AddWithValue("@studentid", studentid);
                    cmd.Parameters.AddWithValue("@studentemail", studentemail);

                    int checkadmin = Convert.ToInt32(cmd.ExecuteScalar());
                    if (checkadmin > 0)
                    {
                        success = false;

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
        public bool AddStudent(int id, string name, string password, string email, string phone, string gender, DateTime birthdate, string path,int adminid)
        {
            bool success = false;
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();

            }
            try
            {
                string selectquery = "INSERT INTO STUDENTS(STUDENT_ID,STUDENT_NAME,STUDENT_EMAIL,STUDENT_PASSWORD,STUDENT_PHONE,STUDENT_GENDER,STUDENT_BIRTHDATE,STUDENT_IMAGE,STUDENT_CREATED,ADMIN_ID) VALUES(@id,@name,@email,@password,@phone,@gender,@birthdate,@image,@datecreated,@adminid);";
                using (SqlCommand cmd = new SqlCommand(selectquery, _conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate);
                    cmd.Parameters.AddWithValue("@image", path);
                    cmd.Parameters.AddWithValue("@datecreated", DateTime.Now);
                    cmd.Parameters.AddWithValue("@adminid", adminid);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0) { success = true; }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error :" + ex);
            }
            finally
            {
                _conn.Close();

            }
            return success;
        }
        public bool DeleteStudent(int studentid)
        {
            bool success = false;
            if(_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string query = "DELETE FROM STUDENTS WHERE STUDENT_ID=@studentid";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {

                    cmd.Parameters.AddWithValue("@studentid", studentid);
                   
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0) { success = true; }
                }
            }
            catch (Exception ex) { 
                return false;
            
            }
            finally { _conn.Close(); }
            return success;

        }
        public bool UpdateStudent(int id, string name, string password, string email, string phone, string gender, DateTime birthdate, string path)
        {
            bool success = false;
            if(_conn.State!= ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string query = "UPDATE STUDENTS SET STUDENT_NAME=@studentname , STUDENT_EMAIL = @studentemail , STUDENT_PASSWORD =@studentpassword ,STUDENT_PHONE=@studentphone,STUDENT_GENDER=@studentgender,STUDENT_BIRTHDATE=@studentbirthdate,STUDENT_IMAGE=@studentimage,STUDENT_UPDATED=@studentupdate WHERE STUDENT_ID =@studentid";
                using(SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@studentname",name);
                    cmd.Parameters.AddWithValue("@studentemail", email);
                    cmd.Parameters.AddWithValue("@studentpassword", password);
                    cmd.Parameters.AddWithValue("@studentphone", phone);
                    cmd.Parameters.AddWithValue("@studentgender", gender);
                    cmd.Parameters.AddWithValue("@studentbirthdate", birthdate);
                    cmd.Parameters.AddWithValue("@studentimage", path);
                    cmd.Parameters.AddWithValue("@studentupdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@studentid", id);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0) { success = true; }
                }

            }
            catch (Exception ex) { 
            
            success = false;
            }
            finally { _conn.Close(); }
            return success;
        }
    }
}
