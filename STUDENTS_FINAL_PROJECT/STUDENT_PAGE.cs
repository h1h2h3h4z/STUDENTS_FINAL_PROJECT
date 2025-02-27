using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static STUDENTS_FINAL_PROJECT.UCenrollement;

namespace STUDENTS_FINAL_PROJECT
{
    internal class STUDENT_PAGE
    {
      
        SqlConnection _conn = new SqlConnection(@"Data Source=ATLAS-P0SAIV6D2\HUSSEIN;Initial Catalog=STUDENT_REGISTERY;Integrated Security=True;Encrypt=False");
        public class StudentInfo
       {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public string StudentEmail { get; set; }
            public string StudentImage { get; set; }  // Keep as string since it's a file path
            public DateTime StudentBirthdate { get; set; }
             public string StudentPhone { get; set; }
          
        }
       
      

        public StudentInfo GetStudentInfo(int id)
        {
            StudentInfo student = null;

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                string query = "SELECT STUDENT_ID, STUDENT_NAME, STUDENT_EMAIL, STUDENT_IMAGE, STUDENT_BIRTHDATE, STUDENT_PHONE FROM STUDENTS WHERE STUDENT_ID = @studentid";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@studentid", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            student = new StudentInfo
                            {
                                StudentId = reader.GetInt32(reader.GetOrdinal("STUDENT_ID")),
                                StudentName = reader.GetString(reader.GetOrdinal("STUDENT_NAME")),
                                StudentEmail = reader.GetString(reader.GetOrdinal("STUDENT_EMAIL")),
                                StudentImage = reader.IsDBNull(reader.GetOrdinal("STUDENT_IMAGE")) ? null : reader.GetString(reader.GetOrdinal("STUDENT_IMAGE")),  // Store as string
                                StudentBirthdate = reader.GetDateTime(reader.GetOrdinal("STUDENT_BIRTHDATE")),
                                StudentPhone = reader.GetString(reader.GetOrdinal("STUDENT_PHONE"))
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return student;
        }
        public List<(string coursename, string teachername, string teacherimage)> GetStudentCoursesandteacher(int studentId)
        {
            // Initialize the list to store the results
            List<(string coursename, string teachername, string teacherimage)> courseList = new List<(string coursename, string teachername, string teacherimage)>();

            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                // Your SQL query to fetch courses, teachers, and teacher images
                string query = @"
            SELECT 
               *
            FROM 
                ENROLLEMENTS AS E
            INNER JOIN 
                STUDENTS AS S ON E.STUDENT_ID = S.STUDENT_ID
            INNER JOIN 
                TEACHERS AS T ON E.TEACHER_ID = T.TEACHER_ID
            INNER JOIN 
                COURSES AS C ON E.COURSE_ID = C.COURSE_ID
            INNER JOIN 
                ADMINS AS A ON E.ADMIN_ID = A.ADMIN_ID
            WHERE 
                E.STUDENT_ID = @studentid;";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@studentid", studentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if there is data
                        if (reader.HasRows)
                        {
                            // Read the data from the SQL result
                            while (reader.Read())
                            {
                                string courseName = reader["COURSE_NAME"].ToString();
                                string teacherName = reader["TEACHER_NAME"].ToString();
                                string teacherImage = reader["TEACHER_IMAGE"].ToString(); // Assuming teacher image is a file path or URL

                                // Add the data to the list
                                courseList.Add((courseName, teacherName, teacherImage));
                            }
                        }
                        else
                        {
                            Console.WriteLine("No courses found for this student.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return courseList;
        }
        public List<(int studentid,string studentName,DateTime studentbirthdate,string studentimage,string studentphone,string studentemail)> GetOtherStudents(int studentId)
        {
            List<(int studentid, string studentName, DateTime studentbirthdate, string studentimage, string studentphone, string studentemail)> StudentList = new List<(int studentid, string studentName, DateTime studentbirthdate, string studentimage, string studentphone, string studentemail)>();
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                {
                    _conn.Open();
                }

                // Your SQL query to fetch courses, teachers, and teacher images
                string query = @"
            SELECT 
               *
            FROM 
             STUDENTS WHERE STUDENT_ID !=@studentid";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@studentid", studentId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if there is data
                        if (reader.HasRows)
                        {
                            // Read the data from the SQL result
                            while (reader.Read())
                            {
                                int studentid =Convert.ToInt32(reader["STUDENT_ID"]);
                                string studentname = reader["STUDENT_NAME"].ToString();
                                DateTime studentbirthdate =Convert.ToDateTime(reader["STUDENT_BIRTHDATE"]);
                                string studentimage = reader["STUDENT_IMAGE"].ToString();
                                string studentphone = reader["STUDENT_PHONE"].ToString();
                                string studentemail=reader["STUDENT_EMAIL"].ToString();


                                // Add the data to the list
                                StudentList.Add((studentid, studentname, studentbirthdate, studentimage, studentphone, studentemail));
                            }
                        }
                        else
                        {
                            Console.WriteLine("No courses found for this student.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return StudentList;
        }
    }

}
