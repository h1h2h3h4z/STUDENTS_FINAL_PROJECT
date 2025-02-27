using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENTS_FINAL_PROJECT
{
    internal class Dashboardinformation
    {
        SqlConnection _conn = new SqlConnection(@"Data Source=ATLAS-P0SAIV6D2\HUSSEIN;Initial Catalog=STUDENT_REGISTERY;Integrated Security=True;Encrypt=False");
        public int getStudentsnumber()
        {
            int totalstudents = 0;
            if(_conn.State != ConnectionState.Open) 
            {
                _conn.Open();
            }
            try
            {
                string selectquery = "SELECT COUNT(STUDENT_ID) FROM STUDENTS";
                using (SqlCommand cmd = new SqlCommand(selectquery, _conn))
                {

                    totalstudents = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {

            }
            finally 
            {
                _conn.Close();
            }
            return totalstudents;

        }
        public int getTeachersnumber()
        {
            int totalteachers = 0;
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string selectquery = "SELECT COUNT(TEACHER_ID) FROM TEACHERS";
                using (SqlCommand cmd = new SqlCommand(selectquery, _conn))
                {

                    totalteachers = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return totalteachers;

        }
        public int getCoursesnumber()
        {
            int coursesumber = 0;
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            try
            {
                string selectquery = "SELECT COUNT(COURSE_ID) FROM COURSES";
                using (SqlCommand cmd = new SqlCommand(selectquery, _conn))
                {

                    coursesumber = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return coursesumber;

        }
    }
}
