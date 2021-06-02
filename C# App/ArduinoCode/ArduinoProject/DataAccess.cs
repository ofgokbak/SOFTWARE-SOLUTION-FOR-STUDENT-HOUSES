using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArduinoProject
{
    public class DataAccess
    {

        // Connection for the database with its connectionstring.
        MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi398483;Database=dbi398483;Pwd=advanced123;");

        // Required for execution of SQL statements.
        MySqlCommand command = new MySqlCommand();
        // Stores the last studentid in the student table


        /// <summary>
        /// If the connection state closed, connection will open. If the connection is open, remains open.
        /// </summary>
        public void CheckConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        /// <summary>
        /// Mark task as "DONE".
        /// </summary>
        /// <param name="floorid"></param>
        /// <param name="dayid"></param>
        public void SetTaskCompletedStatus(int floorid, int dayid)
        {
            int taskid = 3;
            bool completed = true;
            bool isChecked = true;
            try
            {
                CheckConnection();
                using (conn)
                {
                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.timetable SET completed = @completed, checked = @isChecked WHERE dayid = @dayid and floorid = @floorid and taskid = @taskid";
                    command.Parameters.AddWithValue("@floorid", floorid);
                    command.Parameters.AddWithValue("@dayid", dayid);
                    command.Parameters.AddWithValue("@taskid", taskid);
                    command.Parameters.AddWithValue("@completed", completed);
                    command.Parameters.AddWithValue("@isChecked", isChecked);
                    command.ExecuteNonQuery();
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Mark task as "Checked".
        /// </summary>
        /// <param name="floorid"></param>
        /// <param name="dayid"></param>
        public void TaskIsChecked(int floorid, int dayid)
        {
            int taskid = 3;
            bool isChecked = true;
            try
            {
                CheckConnection();
                using (conn)
                {
                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.timetable SET checked = @checked WHERE dayid = @dayid and floorid = @floorid and taskid = @taskid";
                    command.Parameters.AddWithValue("@floorid", floorid);
                    command.Parameters.AddWithValue("@dayid", dayid);
                    command.Parameters.AddWithValue("@taskid", taskid);
                    command.Parameters.AddWithValue("@checked", isChecked);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }



        /// <summary>
        /// Get list of all students' informations obtained from the database
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudents()
        {
            try
            {
                List<Student> students = new List<Student>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM student";
                CheckConnection();
                using (conn)
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student();
                            student.Studentid = Convert.ToInt32(reader["studentid"]);
                            student.Username = reader["username"].ToString();
                            student.Firstname = reader["firstname"].ToString();
                            student.Lastname = reader["lastname"].ToString();
                            student.Password = reader["password"].ToString();
                            student.Email = reader["email"].ToString();
                            student.Phonenumber = reader["phonenumber"].ToString();
                            student.Penalty = Convert.ToInt32(reader["penalty"]);
                            student.Roomid = Convert.ToInt32(reader["roomid"]);
                            student.Floorid = Convert.ToInt32(reader["floorid"]);
                            student.Inboxid = Convert.ToInt32(reader["inboxid"]);

                            students.Add(student);

                        }
                    }
                    return students;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Get all time tables as a list.
        /// </summary>
        /// <returns></returns>

        public List<TimeTable> GetTimeTablesOfChosenDay(int dayID)
        {
            int taskid = 3;
            try
            {
                List<TimeTable> timeTable = new List<TimeTable>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT  t.timetableid, t.taskid, s.studentid, d.dayname, ta.taskname,t.completed,t.checked, t.roomid, t.dayid, t.floorid FROM dbi398483.timetable t " +
                      "JOIN student s on s.studentid = t.studentid " +
                      "JOIN days d on d.dayid = t.dayid " +
                      "JOIN tasks ta on ta.taskid = t.taskid " +
                      "ORDER BY t.dayid, t.floorid";
                CheckConnection();
                using (conn)
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tb = new TimeTable();
                            tb.Timetableid = Convert.ToInt32(reader["timetableid"]);
                            tb.Studentid = Convert.ToInt32(reader["studentid"]);
                            tb.Taskid = Convert.ToInt32(reader["taskid"]);
                            tb.Dayname = reader["dayname"].ToString();
                            tb.Taskname = reader["taskname"].ToString();
                            tb.Completed = Convert.ToBoolean(reader["completed"]);
                            tb.Roomid = Convert.ToInt32(reader["roomid"]);
                            tb.Floorid = Convert.ToInt32(reader["floorid"]);
                            tb.Dayid = Convert.ToInt32(reader["dayid"]);
                            tb.IsChecked = Convert.ToBoolean(reader["checked"]);

                            if (tb.Dayid == dayID && tb.Taskid == taskid)
                            {
                                timeTable.Add(tb);
                            }

                        }
                    }
                    return timeTable;
                }
            }

            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// Update current student's penalty point in database.
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public void UpdatePenaltyPoint(int studentid, int penalty)
        {
            try
            {
                using (conn)
                {
                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.student SET penalty = @penalty WHERE studentid = @studentid";
                    command.Parameters.AddWithValue("@studentid", studentid);
                    command.Parameters.AddWithValue("@penalty", penalty);

                    CheckConnection();
                    command.ExecuteNonQuery();
                }
            }

            catch (Exception)
            {
                throw;
            }

        }


        public void SendMessage(int studentid, int fromstudentid, string messagetext, bool ismessageread, string messagedate)
        {
            try
            {
                CheckConnection();
                using (conn)
                {

                    command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO dbi398483.inbox (inboxid,studentid,fromstudentid,messagetext,ismessageread,messagedate) VALUES (@inboxid,@studentid, @fromstudentid,@messagetext,@ismessageread,@messagedate)";
                    command.Parameters.AddWithValue("@inboxid", studentid);
                    command.Parameters.AddWithValue("@studentid", studentid);
                    command.Parameters.AddWithValue("@fromstudentid", fromstudentid);
                    command.Parameters.AddWithValue("@messagetext", messagetext);
                    command.Parameters.AddWithValue("@ismessageread", ismessageread);
                    command.Parameters.AddWithValue("@messagedate", messagedate);
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
