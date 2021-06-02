using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class Announcements
    {
        /// <summary>
        /// Private instances
        /// </summary>
        private int announcementid;
        private int studentid;
        private string announcementtext;
        private string announcementdate;
        private string announcementhours;

        /// <summary>
        /// Properties
        /// </summary>
        public int Announcementid { get => announcementid; set => announcementid = value; }
        public int Studentid { get => studentid; set => studentid = value; }
        public string Announcementtext { get => announcementtext; set => announcementtext = value; }
        public string Announcementdate { get => announcementdate; set => announcementdate = value; }
        public string Announcementhours { get => announcementhours; set => announcementhours = value; }
    }
}
