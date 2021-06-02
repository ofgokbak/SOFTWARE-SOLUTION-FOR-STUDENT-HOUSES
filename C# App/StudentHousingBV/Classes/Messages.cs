using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class Messages
    {
        /// <summary>
        /// Instances
        /// </summary>
        private int messageid;
        private int inboxid;
        private int studentid;
        private int fromstudentid;
        private string messagetext;
        private bool ismessageread;
        private string messagedate;

        /// <summary>
        /// Properties
        /// </summary>
        public int Messageid { get => messageid; set => messageid = value; }
        public int Inboxid { get => inboxid; set => inboxid = value; }
        public int Studentid { get => studentid; set => studentid = value; }
        public int Fromstudentid { get => fromstudentid; set => fromstudentid = value; }
        public string Messagetext { get => messagetext; set => messagetext = value; }
        public bool Ismessageread { get => ismessageread; set => ismessageread = value; }
        public string Messagedate { get => messagedate; set => messagedate = value; }
    }
}
