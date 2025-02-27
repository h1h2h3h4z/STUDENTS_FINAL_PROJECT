using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_FINAL_PROJECT
{
    internal class TEACHERS
    {
        #region
        private int TEACHER_ID { get; set; }//0
        private string TEACHER_NAME { get; set; }//1
        private string TEACHER_EMAIL { get; set; }//2
        private string TEACHER_PASSWORD { get; set; }//3
        private string TEACHER_PHONE { get; set; }//4
        private string TEACHER_GENDER { get; set; }//5
        private DateTime TEACHER_BIRTHDATE { get; set; }//6
        private string TEACHER_IMAGE { get; set; }//7
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
                string selectquery = "SELECT * from TEACHERS inner join ADMINS ON TEACHERS.ADMIN_ID = ADMINS.ADMIN_ID;";
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
        public bool checkTEACHERid(int teacherid,string teacheremail)
        {
            bool success = true;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string insertQuery = "SELECT COUNT(TEACHER_ID) FROM TEACHERS WHERE TEACHER_ID=@teacherid OR TEACHER_EMAIL=@teacheremail";
                using (SqlCommand cmd = new SqlCommand(insertQuery, _conn))

                {
                    cmd.Parameters.AddWithValue("@teacherid", teacherid);
                    cmd.Parameters.AddWithValue("@teacheremail", teacheremail);
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
        public bool AddTEACHER(int id, string name, string password, string email, string phone, string gender, DateTime birthdate, string path, int adminid)
        {
            bool success = false;
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();

            }
            try
            {
                string selectquery = "INSERT INTO TEACHERS(TEACHER_ID,TEACHER_NAME,TEACHER_EMAIL,TEACHER_PASSWORD,TEACHER_PHONE,TEACHER_GENDER,TEACHER_BIRTHDATE,TEACHER_IMAGE,DATE_CREATED,ADMIN_ID) VALUES(@id,@name,@email,@password,@phone,@gender,@birthdate,@image,@datecreated,@adminid);";
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
        public bool DeleteTEACHER(int TEACHERid)
        {
            bool success = false;
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string query = "DELETE FROM TEACHERS WHERE TEACHER_ID=@TEACHERid";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {

                    cmd.Parameters.AddWithValue("@TEACHERid", TEACHERid);

                    int check = cmd.ExecuteNonQuery();
                    if (check > 0) { success = true; }
                }
            }
            catch (Exception ex)
            {
                return false;

            }
            finally { _conn.Close(); }
            return success;

        }
        public bool UpdateTEACHER(int id, string name, string password, string email, string phone, string gender, DateTime birthdate, string path)
        {
            bool success = false;
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string query = "UPDATE TEACHERS SET TEACHER_NAME=@TEACHERname , TEACHER_EMAIL = @TEACHERemail , TEACHER_PASSWORD =@TEACHERpassword ,TEACHER_PHONE=@TEACHERphone,TEACHER_GENDER=@TEACHERgender,TEACHER_BIRTHDATE=@TEACHERbirthdate,TEACHER_IMAGE=@TEACHERimage,DATE_UPDATED=@TEACHERupdate WHERE TEACHER_ID =@TEACHERid";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@TEACHERname", name);
                    cmd.Parameters.AddWithValue("@TEACHERemail", email);
                    cmd.Parameters.AddWithValue("@TEACHERpassword", password);
                    cmd.Parameters.AddWithValue("@TEACHERphone", phone);
                    cmd.Parameters.AddWithValue("@TEACHERgender", gender);
                    cmd.Parameters.AddWithValue("@TEACHERbirthdate", birthdate);
                    cmd.Parameters.AddWithValue("@TEACHERimage", path);
                    cmd.Parameters.AddWithValue("@TEACHERupdate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@TEACHERid", id);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0) { success = true; }
                }

            }
            catch (Exception ex)
            {

                success = false;
            }
            finally { _conn.Close(); }
            return success;
        }
        public bool CheckTeacherEmail(string teacheremail, string teacherpassword)
        {
            bool success = false;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string insertQuery = "SELECT COUNT(TEACHER_ID) FROM TEACHERS WHERE TEACHER_EMAIL=@teacheremail AND TEACHER_PASSWORD=@teacherpassword";
                using (SqlCommand cmd = new SqlCommand(insertQuery, _conn))

                {
                   
                    cmd.Parameters.AddWithValue("@teacheremail", teacheremail);
                    cmd.Parameters.AddWithValue("@teacherpassword", teacherpassword);
                    int checkteacher = Convert.ToInt32(cmd.ExecuteScalar());
                    if (checkteacher > 0)
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
        public int getTeacherid(string teacheremail, string teacherpassword)
        {
            int teacherid = 0;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string insertQuery = "SELECT TEACHER_ID FROM TEACHERS WHERE TEACHER_EMAIL=@teacheremail AND TEACHER_PASSWORD=@teacherpassword";
                using (SqlCommand cmd = new SqlCommand(insertQuery, _conn))

                {
                    cmd.Parameters.AddWithValue("@teacheremail", teacheremail);
                    cmd.Parameters.AddWithValue("@teacherpassword", teacherpassword);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        teacherid = Convert.ToInt32(result.ToString());

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

            return teacherid;
        }
    }
}
