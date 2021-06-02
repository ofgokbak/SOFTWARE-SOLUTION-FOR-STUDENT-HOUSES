using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class Complain
    {
        /// <summary>
        /// Instance Variables
        /// </summary>
        private int ComplainID;
        private int StudentID;
        private string ComplainText;
        private string ComplainTopic;
        private string complaindate;

        /// <summary>
        /// Constructors
        /// </summary>
        public Complain()
        {
        }

        public Complain(int complainID, int studentID, string complainText, string complainTopic)
        {
            ComplainID1 = complainID;
            StudentID1 = studentID;
            ComplainText1 = complainText;
            ComplainTopic1 = complainTopic;
        }

        /// <summary>
        /// Properties
        /// </summary>
        public int ComplainID1 { get => ComplainID; set => ComplainID = value; }
        public int StudentID1 { get => StudentID; set => StudentID = value; }
        public string ComplainText1 { get => ComplainText; set => ComplainText = value; }
        public string ComplainTopic1 { get => ComplainTopic; set => ComplainTopic = value; }
        public string Complaindate { get => complaindate; set => complaindate = value; }

    }
}
