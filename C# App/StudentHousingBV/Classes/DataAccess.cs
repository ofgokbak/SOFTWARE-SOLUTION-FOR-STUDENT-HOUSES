using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class DataAccess
    {
        // Connection for the database with its connectionstring.
        MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi398483;Database=dbi398483;Pwd=advanced123;");

        // Required for execution of SQL statements.
        MySqlCommand command = new MySqlCommand();
        // Stores the last studentid in the student table
        int lastid;
        int[] TaskID;
        List<Room> rooms = new List<Room>();
        int[] CurrentPersonTaskIds = new int[4];
        int[] CurrentStudentTaskIds = new int[4];
        bool MultipleCheck = false;

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
        /// Adds Student to the database
        /// </summary>
        /// <param name="username">username of the student</param>
        /// <param name="firstname">irst name of the student</param>
        /// <param name="lastname">last name of the student</param>
        /// <param name="password">password of the student</param>
        /// <param name="email">email of the student</param>
        /// <param name="phonenumber">phonenumber of the student</param>
        /// <param name="roomid">roomid of the student</param>
        public void AddStudent(string username, string firstname, string lastname, string password, string email, string phonenumber, int roomid, int floorid,int inboxid)
        {
            try
            {
                CheckConnection();
                using (conn)
                {

                    
                    command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO dbi398483.student (username,firstname,lastname,password,email,phonenumber,roomid,floorid,inboxid) VALUES (@username, @firstname, @lastname,@password, @email, @phonenumber,@roomid, @floorid,@inboxid)";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@firstname", firstname);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phonenumber", phonenumber);
                    command.Parameters.AddWithValue("@roomid", roomid);
                    command.Parameters.AddWithValue("@floorid", floorid);
                    command.Parameters.AddWithValue("@inboxid", inboxid);
                    command.ExecuteNonQuery();
                    lastid = Convert.ToInt32(command.LastInsertedId);
                    SetTimeTable(lastid,floorid,roomid);
                    setRoom(roomid, lastid, false);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Updates the rooms 
        /// </summary>
        /// <param name="roomid">roomid</param>
        /// <param name="studentid">studenid</param>
        /// <param name="isroomavailable">true/false check room available</param>
        public void setRoom(int roomid, int studentid, bool isroomavailable)
        {
            try
            {
                CheckConnection();
                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.room SET studentid = @studentid, isroomavailable =@isroomavailable WHERE roomid = @roomid";
                    command.Parameters.AddWithValue("@roomid", roomid);
                    command.Parameters.AddWithValue("@studentid", studentid);
                    command.Parameters.AddWithValue("@isroomavailable", isroomavailable);
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// return list of information of all students obtained from the database
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
                            var student = new Student();
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
        /// return a list of specific usertimetable.
        /// </summary>
        /// <param name="studentid">studentid of the student</param>
        /// <returns></returns>
        public List<TimeTable> GetUserTimetable(int studentid)
        {
            try
            {
                List<TimeTable> timetable = new List<TimeTable>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT t.timetableid, t.taskid, t.checked, t.completed, t.dayid, s.studentid, d.dayname, ta.taskname FROM dbi398483.timetable t " +
                      "JOIN student s on s.studentid = t.studentid " +
                      "JOIN days d on d.dayid = t.dayid " +
                      "JOIN tasks ta on ta.taskid = t.taskid " +
                      "WHERE t.studentid = '" + studentid + "' " +
                      "ORDER BY t.dayid";
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
                            tb.IsChecked = Convert.ToBoolean(reader["checked"]);
                            tb.Dayid = Convert.ToInt32(reader["dayid"]);

                            timetable.Add(tb);


                        }
                    }

                    return timetable;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Adds a complain to the database
        /// </summary>
        /// <param name="studentid"> studentid of the student</param>
        /// <param name="complaintopic"> a short topic about complain </param>
        /// <param name="complaintext"> a long text about complain content</param>
        public void AddComplain(int studentid, string complaintopic, string complaintext, string complaindate)
        {
            try
            {
                CheckConnection();
                command = conn.CreateCommand();
                command.CommandText = "INSERT INTO dbi398483.complain (studentid,complaintopic,complaintext,complaindate) VALUES (@studentid, @complaintopic, @complaintext,@complaindate)";
                command.Parameters.AddWithValue("@studentid", studentid);
                command.Parameters.AddWithValue("@complaintopic", complaintopic);
                command.Parameters.AddWithValue("@complaintext", complaintext);
                command.Parameters.AddWithValue("@complaindate", complaindate);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// returns a list of all complains
        /// </summary>
        /// <returns></returns>
        public List<Complain> GetAllComplains()
        {
            try
            {
                List<Complain> complain = new List<Complain>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT c.complainid, c.studentid, c.complaintopic, c.complaintext, c.complaindate FROM dbi398483.complain c " +
                      "JOIN student s on s.studentid = c.studentid " +
                      "ORDER BY c.complainid";
                CheckConnection();
                using (conn)
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cmp = new Complain();
                            cmp.ComplainID1 = Convert.ToInt32(reader["complainid"]);
                            cmp.StudentID1 = Convert.ToInt32(reader["studentid"]);
                            cmp.ComplainTopic1 = reader["complaintopic"].ToString();
                            cmp.ComplainText1 = reader["complaintext"].ToString();
                            cmp.Complaindate = reader["complaindate"].ToString();

                            complain.Add(cmp);

                        }
                    }
                    return complain;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Sets a specific timetable to the specific student.
        /// </summary>
        /// <param name="studentid">studentid of the student</param>
        public void SetTimeTable(int studentid, int floorid,int roomid)
        {

            checkisroomavailable();
            using (conn)
            {
                int dayid = 1;
                int index = 0;

                for (int i = 0; i < 7; i++)
                {
                    command = conn.CreateCommand();
                    
                    if(rooms.Exists(x=> x.RoomID1 == roomid))
                    {
                        giveRoomTimetable(roomid);
                        try
                        {
                            using (conn)
                            {
                                command = conn.CreateCommand();
                                command.CommandText = "UPDATE dbi398483.timetable SET studentid = @studentid WHERE roomid = @roomid";
                                command.Parameters.AddWithValue("@studentid", studentid);
                                command.Parameters.AddWithValue("@roomid", roomid);
                                CheckConnection();
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                    else
                    {
                        GetAnArray(studentid);
                        command.CommandText = "INSERT INTO dbi398483.timetable (studentid,dayid,taskid,floorid,roomid) VALUES (@studentid,@dayid,@taskid,@floorid,@roomid)";
                        command.Parameters.AddWithValue("@studentid", studentid);
                        command.Parameters.AddWithValue("@dayid", dayid);
                        command.Parameters.AddWithValue("@taskid", CurrentPersonTaskIds[index]);
                        command.Parameters.AddWithValue("@floorid", floorid);
                        command.Parameters.AddWithValue("@roomid", roomid);
                        CheckConnection();
                        command.ExecuteNonQuery();
                        dayid++;
                        index++;
                        if (index == 4)
                        {
                            index = 0;
                        }
                        MultipleCheck = true;
                    }
                    
                }
                MultipleCheck = false;
            }

        }

        /// <summary>
        /// Gets all time tables as a list.
        /// </summary>
        /// <returns></returns>

        public List<TimeTable> GetAllTimeTables()
        {
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

                            timeTable.Add(tb);

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
        /// checks whether current task exists.
        /// </summary>
        /// <param name="floorid"></param>
        /// <param name="dayid"></param>
        /// <param name="taskid"></param>
        /// <returns></returns>
        public bool TaskExists(int floorid,int dayid, int taskid)
        {
            foreach (var item in GetAllTimeTables())
            {
                if(item.Floorid == floorid && item.Dayid == dayid && item.Taskid == taskid)
                {
                    return true;

                }
            }
            return false;
        }


        /// <summary>
        /// Updates the timetable
        /// </summary>
        /// <param name="studentid"></param>
        public void UpdateCurrentTimeTable(int studentid)
        {
            // shift tasks in order to next week. 
            CurrentStudentTaskIds = ShiftArrayToLeft(GetCurrentStudentTasks(studentid));

            int dayid = 1;
            int index = 0;
            for (int i = 0; i < 7; i++)
            {
                bool completed = false;
                bool isChecked = false;
                command = conn.CreateCommand();
                command.CommandText = "UPDATE dbi398483.timetable SET taskid = @taskid, checked = @isChecked, completed = @completed WHERE dayid =@dayid and studentid = @studentid";
                command.Parameters.AddWithValue("@studentid", studentid);
                command.Parameters.AddWithValue("@dayid", dayid);
                command.Parameters.AddWithValue("@taskid", CurrentStudentTaskIds[index]);
                command.Parameters.AddWithValue("@isChecked", isChecked);
                command.Parameters.AddWithValue("@completed", completed);

                CheckConnection();

                command.ExecuteNonQuery();

                dayid++;
                index++;

                if (index == 4)
                {
                    index = 0;
                }
            }
        }

        /// <summary>
        /// Gets task ids for student who has chosen student id.
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public int[] GetCurrentStudentTasks(int studentid)
        {
            List<TimeTable> list = new List<TimeTable>();
            list = GetUserTimetable(studentid);
            int[] currentTaskArray = new int[7];
            int count = 0;
            foreach (var item in list)
            {
                currentTaskArray[count] = item.Taskid;
                count++;
            }
            return currentTaskArray;
        }

        /// <summary>
        /// Updates time table for each student.
        /// </summary>
        public void UpdateTimeTables()
        {
            foreach (var item in GetAllTimeTables())
            {
                UpdateCurrentTimeTable(item.Studentid);
            }
        }



        /// <summary>
        /// Gets an array for the student in param
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns> new shifted array </returns>

        public int[] GetAnArray(int studentid)
        {

            //if it is checking multiple times in a for loop 
            if (!MultipleCheck)
            {
                //First student of the Housing system has a null Taskid array
                if (lastid == 2)
                {
                    //set a random array for the first student 
                    CurrentPersonTaskIds = GetRandomArray();
                }

                else
                {
                    CurrentPersonTaskIds = GetLastStudentTasks();
                    // each students follow the previous student's tasks / shifting one item to left in the taskid's array 
                    CurrentPersonTaskIds = ShiftArrayToLeft(CurrentPersonTaskIds);
                }
            }

            return CurrentPersonTaskIds;
        }

        /// <summary>
        /// Create a new random array
        /// </summary>
        /// <returns>new random array </returns>

        public int[] GetRandomArray()
        {
            Random rnd = new Random();
            //Create an arraw for tasks. There ara four tasks
            TaskID = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int random = rnd.Next(1, 5);
                // random number doesnt exist in the array
                if (!TaskID.Contains(random))
                {
                    TaskID[i] = random;
                }
                else
                {
                    // do nothing ,execute the for loop again  
                    i--;
                }
            }
            //return created the new random array 
            return TaskID;
        }

        /// <summary>
        /// Create an array and shif indexex on to left of previous one  
        /// </summary>
        /// <param name="currentArray"></param>
        /// <returns>new shifted array</returns>

        public int[] ShiftArrayToLeft(int[] currentArray)
        {
            // Save first index in the current array
            int firstIndex = currentArray[0];
            // Create a new Array has same length with previous one 
            int[] newArray = new int[currentArray.Length];

            for (int i = 0; i < currentArray.Length - 1; i++)

            {
                //shift each left index  
                newArray[i] = currentArray[i + 1];
            }

            // add first index to last index of new array.
            newArray[newArray.Length - 1] = firstIndex;

            return newArray;

        }

        /// <summary>
        /// returns the last student timetable from the database.
        /// </summary>
        /// <returns></returns>
        public int[] GetLastStudentTasks()
        {
            List<TimeTable> list = new List<TimeTable>();
            int a = lastid - 1;
            list = GetUserTimetable(a);
            int[] lasttaskarray = new int[4];
            int count = 0;


            foreach (var item in list)
            {
                if (count != 4)
                {
                    lasttaskarray[count] = item.Taskid;
                    count++;
                }
            }

            for (int i = 0; i < lasttaskarray.Length; i++)
            {
                CurrentPersonTaskIds[i] = lasttaskarray[i];
            }
            return CurrentPersonTaskIds;
        }

        /// <summary>
        /// Assigns the student to specific room which has a specific time table
        /// </summary>
        /// <param name="roomid"></param>
        /// <returns></returns>
        public int[] giveRoomTimetable(int roomid)
        {
            List<TimeTable> list = new List<TimeTable>();
            list = GetUserTimetable(roomid);
            int[] lasttaskarray = new int[4];
            int count = 0;


            foreach (var item in list)
            {
                if (count != 4)
                {
                    lasttaskarray[count] = item.Taskid;
                    count++;
                }
            }


            for (int j = 0; j < lasttaskarray.Length; j++)
            {
                CurrentPersonTaskIds[j] = lasttaskarray[j];
            }
            return CurrentPersonTaskIds;
        }


        /// <summary>
        /// Gets the specific floor timetable
        /// </summary>
        /// <param name="floorid">floorid of the apartment</param>
        /// <returns></returns>
        public List<TimeTable> GetFloorTimeTable(int floorid)
        {
            try
            {
                List<TimeTable> timetable = new List<TimeTable>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT t.timetableid, t.taskid, s.studentid, d.dayname, t.completed, t.checked, ta.taskname, t.floorid FROM dbi398483.timetable t " +
                      "JOIN student s on s.studentid = t.studentid AND s.floorid = t.floorid " +
                      "JOIN days d on d.dayid = t.dayid " +
                      "JOIN tasks ta on ta.taskid = t.taskid " +
                      "WHERE t.floorid = '" + floorid + "' " +
                      "ORDER BY t.roomid,t.dayid";

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
                            tb.Floorid = Convert.ToInt32(reader["floorid"]);
                            tb.IsChecked = Convert.ToBoolean(reader["checked"]);
                            tb.Completed = Convert.ToBoolean(reader["completed"]);

                            timetable.Add(tb);
                        }
                    }

                    return timetable;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Changes the task as completed
        /// </summary>
        /// <param name="floorid">floor id of the apartment</param>
        /// <param name="dayid"></param>
        /// <param name="taskid"></param>
        /// <param name="completed"></param>
        public void SetCompletedRowInDatabase(int floorid, int dayid, int taskid, bool completed)
        {
            try
            {
                CheckConnection();
                using (conn)
                {
                    bool isChecked = true;
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
        /// Updates specified student's penalty point.
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="penalty"></param>
        public void UpdatePenaltyPoint(int studentid,int penalty)
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


        /// <summary>
        /// Deletes the student from the room
        /// </summary>
        /// <param name="studentid">stundet id</param>
        /// <param name="roomid">room id</param>
        public void DeleteStudent(int studentid,int roomid)
        {
            try
            {
               
                using (conn)
                {

                    emptyRoom(roomid, 0, true);
                    DeleteTimeTable(studentid, roomid);
                    DeleteStudentComplain(studentid);
                    DeleteMessagebyfromstudentID(studentid);
                    command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM dbi398483.student WHERE studentid = @studentid";
                    command.Parameters.AddWithValue("@studentid", studentid);
                    CheckConnection();
                    command.ExecuteNonQuery();
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
            

        }

        /// <summary>
        /// Remove the student from the room
        /// </summary>
        /// <param name="roomid"></param>
        /// <param name="studentid"></param>
        /// <param name="isroomavailable"></param>
        public void emptyRoom(int roomid, int studentid, bool isroomavailable)
        {
            try
            {
               
                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.room SET studentid = @studentid, isroomavailable =@isroomavailable WHERE roomid = @roomid";
                    command.Parameters.AddWithValue("@roomid", roomid);
                    command.Parameters.AddWithValue("@studentid", studentid);
                    command.Parameters.AddWithValue("@isroomavailable", isroomavailable);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete the student timetable from the database
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="roomid"></param>
        public void DeleteTimeTable(int studentid,int roomid)
        {
            try
            {
               
                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.timetable SET studentid = @studentid WHERE roomid = @roomid";
                    command.Parameters.AddWithValue("@studentid", roomid);
                    command.Parameters.AddWithValue("@roomid", roomid);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete the student complaints from the database
        /// </summary>
        /// <param name="studentid"></param>
        public void DeleteStudentComplain(int studentid)
        {
            try
            {
               
                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM dbi398483.complain WHERE studentid = @studentid";
                    command.Parameters.AddWithValue("@studentid", studentid);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete complaints by id
        /// </summary>
        /// <param name="complainid">complain id</param>
        public void DeleteComplainbyID(int complainid)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM dbi398483.complain WHERE complainid = @complainid";
                    command.Parameters.AddWithValue("@complainid", complainid);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Get complaints by id
        /// </summary>
        /// <param name="complaintopic"></param>
        public void GetComplainbyID(string complaintopic)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "SELECT complainid FROM dbi398483.complain WHERE complaintopic = @complaintopic";
                    command.Parameters.AddWithValue("@complaintopic", complaintopic);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Checks if the room is available
        /// </summary>
        /// <returns></returns>
        public List<Room> checkisroomavailable()
        {
            
            try
            {
                rooms = new List<Room>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT DISTINCT roomid FROM timetable";
                CheckConnection();
                using (conn)
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var room = new Room();
                            room.RoomID1 = Convert.ToInt32(reader["roomid"]);
                           

                            rooms.Add(room);

                        }
                    }
                    return rooms;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// Adds to rule to the database
        /// </summary>
        /// <param name="ruletext"></param>
        /// <param name="ruledate"></param>
        public void AddRule(string ruletext, string ruledate)
        {
            try
            {
                CheckConnection();
                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO dbi398483.rules (ruletext,ruledate) VALUES (@ruletext, @ruledate)";
                    command.Parameters.AddWithValue("@ruletext", ruletext);
                    command.Parameters.AddWithValue("@ruledate", ruledate);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete the rule from the database
        /// </summary>
        /// <param name="ruleid"></param>
        public void DeleteRulebyID(int ruleid)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM dbi398483.rules WHERE ruleid = @ruleid";
                    command.Parameters.AddWithValue("@ruleid", ruleid);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

  
        /// <summary>
        /// Get all the rules as Lists
        /// </summary>
        /// <returns></returns>
       public List<Rules> GetAllRules()
        {
            try
            {
                List<Rules> rules = new List<Rules>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT ruleid,ruletext,ruledate FROM dbi398483.rules";
                CheckConnection();
                using (conn)
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rule = new Rules();
                            rule.Ruleid = Convert.ToInt32(reader["ruleid"]);
                            rule.Ruletext = reader["ruletext"].ToString();
                            rule.Ruledate = reader["ruledate"].ToString();
                            rules.Add(rule);

                        }
                    }
                    return rules;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Add announcements to the database
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="announcementtext"></param>
        /// <param name="announcementdate"></param>
        /// <param name="announcementhours"></param>
        public void AddAnnouncement(int studentid, string announcementtext, string announcementdate, string announcementhours)
        {
            try
            {
                CheckConnection();
                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO dbi398483.announcements (studentid,announcementtext,announcementdate,announcementhours) VALUES (@studentid, @announcementtext,@announcementdate,@announcementhours)";
                    command.Parameters.AddWithValue("@studentid", studentid);
                    command.Parameters.AddWithValue("@announcementtext", announcementtext);
                    command.Parameters.AddWithValue("@announcementdate", announcementdate);
                    command.Parameters.AddWithValue("@announcementhours", announcementhours);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Delete announcements from the database
        /// </summary>
        /// <param name="announcementid"></param>
        public void DeleteAnnouncement(int announcementid)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM dbi398483.announcements WHERE announcementid = @announcementid";
                    command.Parameters.AddWithValue("@announcementid", announcementid);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Gets all announcements as Lists
        /// </summary>
        /// <returns></returns>
        public List<Announcements> GetAllAnnouncements()
        {
            try
            {
                List<Announcements> announcements = new List<Announcements>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM dbi398483.announcements";
                CheckConnection();
                using (conn)
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var Announcement = new Announcements();
                            Announcement.Announcementid = Convert.ToInt32(reader["announcementid"]);
                            Announcement.Studentid = Convert.ToInt32(reader["studentid"]);
                            Announcement.Announcementtext = reader["announcementtext"].ToString();
                            Announcement.Announcementdate = reader["announcementdate"].ToString();
                            Announcement.Announcementhours = reader["announcementhours"].ToString();

                            announcements.Add(Announcement);

                        }
                    }
                    return announcements;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Send message to selected person
        /// </summary>
        /// <param name="inboxid"></param>
        /// <param name="studentid"></param>
        /// <param name="fromstudentid"></param>
        /// <param name="messagetext"></param>
        /// <param name="ismessageread"></param>
        /// <param name="messagedate"></param>
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

        /// <summary>
        /// Delete specific message from the database
        /// </summary>
        /// <param name="messageid"></param>
        public void DeleteMessage(int messageid)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM dbi398483.inbox WHERE messageid = @messageid";
                    command.Parameters.AddWithValue("@messageid", messageid);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Delete the message that send from
        /// </summary>
        /// <param name="fromstudentid"></param>
        public void DeleteMessagebyfromstudentID(int fromstudentid)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM dbi398483.inbox WHERE fromstudentid = @fromstudentid";
                    command.Parameters.AddWithValue("@fromstudentid", fromstudentid);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Get all messages as Lists
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public List<Messages> GetMessages(int studentid)
        {
            try
            {
                List<Messages> messages = new List<Messages>();
                command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM dbi398483.inbox WHERE studentid = @studentid ORDER BY ismessageread";
                command.Parameters.AddWithValue("@studentid", studentid);
                CheckConnection();
                using (conn)
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var message = new Messages();
                            message.Messageid = Convert.ToInt32(reader["messageid"]);
                            message.Inboxid = Convert.ToInt32(reader["inboxid"]);
                            message.Studentid = Convert.ToInt32(reader["studentid"]);
                            message.Fromstudentid = Convert.ToInt32(reader["fromstudentid"]);
                            message.Messagetext = reader["messagetext"].ToString();
                            message.Ismessageread = Convert.ToBoolean(reader["ismessageread"]);
                            message.Messagedate = reader["messagedate"].ToString();
                            messages.Add(message);

                        }
                    }
                    return messages;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Mark read the message
        /// </summary>
        /// <param name="messageid"></param>
        public void MarkRead(int messageid)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.inbox SET ismessageread = @ismessageread WHERE messageid = @messageid";
                    command.Parameters.AddWithValue("@messageid", messageid);
                    command.Parameters.AddWithValue("@ismessageread", true);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// Change student password 
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="password"></param>
        public void ChangePassword(int studentid, string password)
        {
            try
            {

                using (conn)
                {
                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.student SET password = @password WHERE studentid = @studentid";
                    command.Parameters.AddWithValue("@studentid", studentid);
                    command.Parameters.AddWithValue("@password", password);
                    CheckConnection();
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Change student email
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="email"></param>
        public void ChangeEmail(int studentid, string email)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.student SET email = @email WHERE studentid = @studentid";
                    command.Parameters.AddWithValue("@studentid", studentid);
                    command.Parameters.AddWithValue("@email", email);
                    CheckConnection();
                    command.ExecuteNonQuery();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Change the student number
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="phonenumber"></param>
        public void ChangeNumber(int studentid, string phonenumber)
        {
            try
            {

                using (conn)
                {


                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE dbi398483.student SET phonenumber = @phonenumber WHERE studentid = @studentid";
                    command.Parameters.AddWithValue("@studentid", studentid);
                    command.Parameters.AddWithValue("@phonenumber", phonenumber);
                    CheckConnection();
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

