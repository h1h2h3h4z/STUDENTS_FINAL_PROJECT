using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS_FINAL_PROJECT
{
    internal class TEACHER_PAGE
    {

        
        public int teacherid { get; set; }
        public string teachername {  get; set; }
        public string teacheremail {  get; set; }
        public string teacherphone {  get; set; }
        public string teacherimage {  get; set; }
        public DateTime teacherdateofbirth {  get; set; }
      
        SqlConnection _conn = new SqlConnection(@"Data Source=ATLAS-P0SAIV6D2\HUSSEIN;Initial Catalog=STUDENT_REGISTERY;Integrated Security=True;Encrypt=False");
        public TEACHER_PAGE GetteacherInfo(int teacherid)
        {
            TEACHER_PAGE teacher = null;
            if (_conn.State != System.Data.ConnectionState.Open) { 
            
                _conn.Open();
            }
            try
            {
                string query = "SELECT * FROM TEACHERS WHERE TEACHER_ID=@teacherid";
                using (SqlCommand cmd = new SqlCommand(query, _conn)) { 
                    cmd.Parameters.AddWithValue("@teacherid",teacherid);
                    using (SqlDataReader reader = cmd.ExecuteReader()) {

                        if (reader.Read()) {

                            teacher = new TEACHER_PAGE
                            {
                                teacherid = reader.GetInt32(reader.GetOrdinal("TEACHER_ID")),
                                teachername = reader.GetString(reader.GetOrdinal("TEACHER_NAME")),
                                teacheremail = reader.GetString(reader.GetOrdinal("TEACHER_EMAIL")),
                                teacherphone = reader.GetString(reader.GetOrdinal("TEACHER_PHONE")),
                                teacherimage = reader.GetString(reader.GetOrdinal("TEACHER_IMAGE")),
                                teacherdateofbirth = reader.GetDateTime(reader.GetOrdinal("TEACHER_BIRTHDATE")),
                            };
                        
                        }
                    
                    }
                
                }
            }
            catch (Exception ex) { 
            }
            finally { _conn.Close(); }
            return teacher;
        }
        public List<(string coursename, string studentname, string studentimage)> GetTeacherCoursestoteacher(int teacherid)
        {
            List<(string coursename, string studentname, string studentimage)> courseList = new List<(string coursename, string studentname, string studentimage)>();


            if (_conn.State != System.Data.ConnectionState.Open) { _conn.Open(); }

                
                try
                {
                    string query = @"
                        SELECT 
                            C.COURSE_NAME,
                            S.STUDENT_NAME,
                            S.STUDENT_IMAGE
                        FROM 
                            ENROLLEMENTS AS E
                        INNER JOIN 
                            STUDENTS AS S ON E.STUDENT_ID = S.STUDENT_ID
                        INNER JOIN 
                            COURSES AS C ON E.COURSE_ID = C.COURSE_ID
                        WHERE 
                            E.TEACHER_ID = @teacherid;";

                    using (SqlCommand cmd = new SqlCommand(query, _conn))
                    {
                        cmd.Parameters.AddWithValue("@teacherid", teacherid);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string courseName = reader["COURSE_NAME"].ToString();
                                string studentname = reader["STUDENT_NAME"].ToString();
                                string studentimage = reader.IsDBNull(reader.GetOrdinal("STUDENT_IMAGE")) ? null : reader.GetString(reader.GetOrdinal("STUDENT_IMAGE"));

                                courseList.Add((courseName, studentname, studentimage));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
            
            return courseList;
        }
    }
}
