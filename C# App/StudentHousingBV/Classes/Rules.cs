using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class Rules
    {
        /// <summary>
        /// Instances
        /// </summary>
        private int ruleid;
        private string ruletext;
        private string ruledate;

        /// <summary>
        /// Properties
        /// </summary>
        public int Ruleid { get => ruleid; set => ruleid = value; }
        public string Ruletext { get => ruletext; set => ruletext = value; }
        public string Ruledate { get => ruledate; set => ruledate = value; }
    }
}
