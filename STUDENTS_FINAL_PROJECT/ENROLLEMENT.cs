using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_FINAL_PROJECT
{
    internal class ENROLLEMENT
    {
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
                string selectquery = "SELECT * from ENROLLEMENTS inner join STUDENTS on ENROLLEMENTS.STUDENT_ID=STUDENTS.STUDENT_ID join TEACHERS on ENROLLEMENTS.TEACHER_ID = TEACHERS.TEACHER_ID join COURSES on ENROLLEMENTS.COURSE_ID = COURSES.COURSE_ID join ADMINS ON ENROLLEMENTS.ADMIN_ID = ADMINS.ADMIN_ID;";
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
        public List<(int Id, string Name)> FillStudents()
        {
            List<(int Id, string Name)> students = new List<(int, string)>();
            if(_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string query = "SELECT STUDENT_ID,STUDENT_NAME FROM STUDENTS";
            
                    using (SqlCommand command = new SqlCommand(query, _conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            int id = Convert.ToInt32(reader["STUDENT_ID"]);
                            string name = $"{id} - {reader["STUDENT_NAME"]}";
                            students.Add((id, name));
                        }
                        }
                    }
                
            }
            catch (Exception ex) { 
            }
            finally { _conn.Close(); }


            return students;

        }
        public List<(int Id, string Name)> FillTeachers()
        {
            List<(int Id, string Name)> students = new List<(int, string)>();
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string query = "SELECT TEACHER_ID,TEACHER_NAME FROM TEACHERS";

                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["TEACHER_ID"]);
                            string name = $"{id} - {reader["TEACHER_NAME"]}";
                            students.Add((id, name));
                        }
                    }
                }

            }
            catch (Exception ex)
            {
            }
            finally { _conn.Close(); }


            return students;

        }
        public List<(int Id, string Name)> FillCourses()
        {
            List<(int Id, string Name)> course = new List<(int, string)>();
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string query = "SELECT COURSE_ID,COURSE_NAME FROM COURSES";

                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["COURSE_ID"]);
                            string name = $"{id} - {reader["COURSE_NAME"]}";
                            course.Add((id, name));
                        }
                    }
                }

            }
            catch (Exception ex)
            {
            }
            finally { _conn.Close(); }


            return course;

        }
        public bool AddEnrolle(int studentid,int teacherid,int courseid,int adminid)
        {
            bool success = false;
            if(_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();
               
            }
            try
            {
                string query = "INSERT INTO ENROLLEMENTS(STUDENT_ID,TEACHER_ID,COURSE_ID,ADMIN_ID,ENROLLEMENT_CREATED) VALUES(@studentid,@teacherid,@courseid,@adminid,@datecreated)";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@studentid", studentid);
                    cmd.Parameters.AddWithValue("@teacherid", teacherid);
                    cmd.Parameters.AddWithValue("@courseid", courseid);
                    cmd.Parameters.AddWithValue("@adminid", adminid);
                    cmd.Parameters.AddWithValue("@datecreated", DateTime.Now);
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex) { 
            }
            finally{ _conn.Close(); }
            return success;
        }
        public bool DeleteEnrolle(int Enrolleid)
        {
            bool success = false;
            if (_conn.State != System.Data.ConnectionState.Open)
            {
                _conn.Open();

            }
            try
            {
                string query = "DELETE FROM ENROLLEMENTS WHERE ENROLLEMENT_ID = @Enrolleid";
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@Enrolleid", Enrolleid);
                    
                    int check = cmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        success = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            finally { _conn.Close(); }
            return success;
        }
   

    }
}
