using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class StudentHousingSystem
    {
        DataAccess database = new DataAccess();
        /// <summary>
        /// Stores list of the Student objects.
        /// </summary>
        private List<Student> students;
        private List<TimeTable> timetable;
        private List<Complain> complains = new List<Complain>();


        public List<Student> Students { get => students; set => students = value; }
        public List<TimeTable> Timetable { get => timetable; set => timetable = value; }
      


        /// <summary>
        /// returns an array including all the students.
        /// </summary>
        /// <returns></returns>
        public void GetStudents()
        {
            Students = database.GetStudents();
        }

        /// <summary>
        /// Checks the user login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool GetLogin(string username, string password)
        {
            if(!Students.Exists(x=>x.Username == username))
            {
                return false;
            }
            else
            {
                var student = Students.Find(x => x.Username == username);
                if (student.Username == username && student.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
         
        }

        /// <summary>
        /// check the user is admin or not
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool isAdmin(string username)
        {
            if (username == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the user timetable
        /// </summary>
        /// <param name="studentid"></param>
        public void GetUserTimetable(int studentid)
        {
           
            Timetable = database.GetUserTimetable(studentid);
        }

      

        /// <summary>
        /// Checks all tasks which are undone.
        /// </summary>
        /// <returns></returns>

        public List<TimeTable> CheckTasks()
        {
            List<TimeTable> undone = new List<TimeTable>();
            List<TimeTable> all = database.GetAllTimeTables();
            bool undonee = false;
            foreach (var item in all)
            {
                if (item.Completed == undonee)
                {
                    undone.Add(item);
                }
            }
            return undone;
        }

        /// <summary>
        /// Update student's penalty point who is assigned to specified task on specified floor in current day.
        /// </summary>
        /// <param name="dayID"></param>
        /// <param name="floorID"></param>
        /// <param name="taskID"></param>
        public void UpdatePenaltyPoint(int dayID, int floorID, int taskID)
        {
            int overLimitOfPenaltPoint = 3;
          
            foreach (var item in database.GetAllTimeTables())
            {
                //Find current task among the all tasks
                if (item.Taskid == taskID && item.Dayid == dayID && item.Floorid == floorID)
                {

                    foreach (Student student in database.GetStudents())
                    {
                        // Find student who responsible with current task is.
                        if (item.Studentid == student.Studentid)
                        {
                            // Increase penalty point
                            student.Penalty++;

                            // Student's penalty point has reached to LIMIT. 
                            if (student.Penalty > overLimitOfPenaltPoint)
                            {
                                student.Penalty = 1;
                            }
                            else if(student.Penalty == overLimitOfPenaltPoint)
                            {
                                // Send a warning message to specified student has already reached the limit penalty point.
                                SendMessageToAdmin(student.Roomid, student.Firstname);
                            }

                            // marked task as "UNDONE" in database.
                            database.UpdatePenaltyPoint(student.Studentid, student.Penalty);
                            // Send a wanring message to current student that his task was checked and it is not completed.
                            SendUndoneMessage(student.Studentid, student.Penalty, item.Taskname, dayID);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Sends message to specified student that specified task was not done current day.
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="penalty"></param>
        /// <param name="taskname"></param>
        /// <param name="dayID"></param>
        public void SendUndoneMessage(int studentid, int penalty, string taskname, int dayID )
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            // Find admin object among students.
            Student admin = Students.Find(x => x.Firstname == "Admin");

            string undonetext = $"WARNING: You did not completed your task [{taskname} on {(Days)(dayID - 1)}]. Your penalty point was increased to:'{penalty} pts.'. Be aware that if your penalty points reaches LIMIT(3 pts.), you will be fined!";

            // Student's penalty point has reached to LIMIT. 
            if (penalty == 3)
            {
                undonetext = $"WARNING: You did not completed your task [{taskname} on {(Days)(dayID - 1)}]. Your penalty point reached LIMIT!(3 pts.), you will be fined!";
            }
            database.SendMessage(studentid, 1, undonetext, false, date);
        }

        /// <summary>
        /// Sends message admin to inform that specified student has reached to LIMIT penalty point.
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="studentName"></param>
        public void SendMessageToAdmin(int roomid, string studentName)
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            // Find admin object among students.
            Student admin = database.GetStudents().Find(x => x.Firstname == "Admin");

            string undonetext = $"WARNING: {studentName} => room:'{roomid}' has reached LIMIT(3 pts.) penalty point.";
            database.SendMessage(admin.Studentid, admin.Studentid, undonetext, false, date);
        }


        /// <summary>
        /// if task status has already been checked by admin. 
        /// </summary>
        /// <param name="dayId"></param>
        /// <param name="taskID"></param>
        /// <param name="floorID"></param>
        /// <returns></returns>
        public bool TaskWasChecked(int dayId, int taskID, int floorID)
        {
            List<TimeTable> all = database.GetAllTimeTables();
            foreach (var item in all)
            {
                if (item.Taskid == taskID && item.Floorid == floorID && item.Dayid == dayId )
                {
                    return item.IsChecked;
                }
                
                
            }
            return false;
        }

       
        /// <summary>
        /// Takes student id and returns to that specific student object.
        /// </summary>
        /// <param name="id"> ID of the student </param>
        /// <returns> the student object </returns>
        public Student GetStudent(string username)
        {
            foreach (Student s in this.Students)
            {
                if (username == s.Username)
                { return s; }
            }
            return null;
        }

        /// <summary>
        /// Finds student with specified id.
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public Student GetStudentbyID(int studentid)
        {
            students = database.GetStudents();
            foreach (Student s in this.Students)
            {
                if (studentid == s.Studentid)
                { return s; }
            }
            return null;
        }


        /// <summary>
        /// Check username existence
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckUsernameExistence(string username)
        {
            var checkusername = Students.Exists(x => x.Username == username);

            return checkusername;

        }

        /// <summary>
        /// check email existence
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckEmailExistence(string email)
        {

            var checkemail = Students.Exists(x => x.Email == email);
            return checkemail;
        }

        /// <summary>
        /// check phone number existence
        /// </summary>
        /// <param name="phoneumber"></param>
        /// <returns></returns>
        public bool CheckPhoneExistence(string phoneumber)
        {

            var checkphone = Students.Exists(x => x.Phonenumber == phoneumber);
            return checkphone;
        }

        /// <summary>
        /// check if room is available
        /// </summary>
        /// <param name="roomid"></param>
        /// <returns></returns>
        public bool CheckRoomExistence(int roomid)
        {

            var checkroom = Students.Exists(x => x.Roomid == roomid);
            return checkroom;
        }

        /// <summary>
        /// find the student by room id
        /// </summary>
        /// <param name="roomid"></param>
        /// <returns></returns>

        public Student FindStudentbyRoomID(int roomid)
        {
            foreach (Student s in this.Students)
            {
                if (roomid == s.Roomid)
                { return s; }
            }
            return null;
        }

        /// <summary>
        /// check currenttask status
        /// </summary>
        /// <param name="alltasks"></param>
        /// <param name="dayid"></param>
        /// <param name="floorid"></param>
        /// <param name="taskid"></param>
        /// <returns></returns>
        public string GetCurrentTaskStatus(List<TimeTable> alltasks, int dayid,int floorid, int taskid)
        {
            string status = "NULL";
          
            if (alltasks.Exists(x => x.Dayid == dayid && x.Floorid == floorid && x.Taskid == taskid))
            {
                foreach (var item in alltasks)
                {
                    if (item.IsChecked == true && item.Dayid == dayid && item.Floorid == floorid && item.Taskid == taskid)
                    {
                        if (item.Completed == true)
                        {
                            status = "DONE";
                            break;
                        }
                        else
                        {
                            Student taskedStudent = GetStudentbyID(item.Studentid);
                            status = $"UNDONE! by '{taskedStudent.Firstname.ToUpper()}', Room:{taskedStudent.Roomid}";
                            break;
                        }
                    }
                    else if (item.IsChecked == false && item.Dayid == dayid && item.Floorid == floorid && item.Taskid == taskid)
                    {
                        status = "N.C.*";
                        break;
                    }
                }
            }
            
            return status;
        }
    }
}
