using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoProject
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Task
    {
        DataAccess database = new DataAccess();
        List<Student> students;

        private static int taskID = 3;


        /// <summary>
        /// Check Garbage tasks whether it is done or not for each floor.
        /// </summary>
        /// <param name="dayID"></param>
        /// <returns> List of the students who did not completed task.</returns> 
        public void CheckUndoneTasks(int dayID)
        {
            students = database.GetStudents();
            int overLimitOfPenaltPoint = 3;
            // Find all tasks.

            foreach (var item in database.GetTimeTablesOfChosenDay(dayID))
            {
                if (!TaskWasAlreadyChecked(dayID, item.Floorid))
                {
                    foreach (Student student in students)
                    {
                        // Find student who responsible with current task is.
                        if (item.Studentid == student.Studentid)
                        {
                            // Increase penalty point
                            student.Penalty++;

                            // // Student's penalty point has reached to LIMIT. 
                            if (student.Penalty > overLimitOfPenaltPoint)
                            {
                                student.Penalty = 1;
                            }
                            else if (student.Penalty == overLimitOfPenaltPoint)
                            {
                                // Send a warning message to specified student has already reached the limit penalty point.
                                SendMessageToAdmin(student.Roomid, student.Firstname);
                            }

                            database.UpdatePenaltyPoint(student.Studentid, student.Penalty);
                            database.TaskIsChecked(item.Floorid, dayID);
                            SendUndoneMessage(student.Studentid, student.Penalty, dayID);
                        }
                    }

                }
            }
        }


        /// <summary>
        /// if task status has already been checked by admin. 
        /// </summary>
        /// <param name="dayId"></param>
        /// <param name="floorID"></param>
        /// <returns></returns>
        public bool TaskWasAlreadyChecked(int dayId, int floorID)
        {
            List<TimeTable> all = database.GetTimeTablesOfChosenDay(dayId);
            foreach (var item in all)
            {
                if (item.Taskid == taskID && item.Floorid == floorID && item.Dayid == dayId)
                {
                    return item.IsChecked;
                }
            }
            return false;
        }


        /// <summary>
        /// Sends message to specified student that specified task was not done current day.
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="penalty"></param>
        /// <param name="dayID"></param>
        public void SendUndoneMessage(int studentid, int penalty, int dayID)
        {
            string taskname = "Throwing Garbage";
            string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            // Find admin object among students.
            Student admin = database.GetStudents().Find(x => x.Firstname == "Admin");

            string undonetext = $"WARNING: You did not completed your task [{taskname} on {(Days)(dayID - 1)}]. Your penalty point was increased to:'{penalty} pts.'. Be aware that if your penalty points reaches LIMIT(3 pts.), you will be fined!";

            // Student's penalty point has reached to LIMIT. 
            if (penalty == 3)
            {
                undonetext = $"WARNING: You did not completed your task [{taskname} on {(Days)(dayID - 1)}]. Your penalty point reached LIMIT!(3 pts.), you will be fined!";
            }
            database.SendMessage(studentid, admin.Studentid, undonetext, false, date);
        }


        /// <summary>
        /// Sends message admin to inform that specified student has reached to LIMIT penalty point.
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="studentName"></param>
        public void SendMessageToAdmin(int roomid,string studentName)
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            // Find admin object among students.
            Student admin = database.GetStudents().Find(x => x.Firstname == "Admin");

            string undonetext = $"WARNING: {studentName} => room:'{roomid}' has reached LIMIT(3 pts.) penalty point.";
            database.SendMessage(admin.Studentid,admin.Studentid, undonetext, false, date);
        }
    }
}
