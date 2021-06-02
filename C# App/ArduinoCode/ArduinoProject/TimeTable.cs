using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoProject
{
    public class TimeTable
    {

        private int timetableid;
        private int studentid;
        private int dayid;
        private int taskid;
        private string dayname;
        private string taskname;
        private int floorid;
        private int roomid;
        private bool completed;
        private bool isChecked;

        public int Timetableid { get => timetableid; set => timetableid = value; }
        public int Studentid { get => studentid; set => studentid = value; }
        public int Dayid { get => dayid; set => dayid = value; }
        public int Taskid { get => taskid; set => taskid = value; }
        public string Dayname { get => dayname; set => dayname = value; }
        public string Taskname { get => taskname; set => taskname = value; }
        public int Floorid { get => floorid; set => floorid = value; }
        public int Roomid { get => roomid; set => roomid = value; }
        public bool Completed { get => completed; set => completed = value; }
        public bool IsChecked { get => isChecked; set => isChecked = value; }

        public string GetInfo()
        {
            return $"Day: {this.Dayname}, Floor: {this.Floorid}, Task: {this.Taskname}, Student: {this.Studentid}, status: {this.Completed}";
        }

        public string GetInfo2()
        {
            return $"{this.completed}";
        }
    }
}
