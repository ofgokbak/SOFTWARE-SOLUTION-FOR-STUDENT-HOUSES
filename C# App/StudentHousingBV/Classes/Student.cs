using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV.Classes
{
    public class Student
    {
        private int studentid;
        private string username;
        private string firstname;
        private string lastname;
        private string password;
        private string email;
        private string phonenumber;
        private int penalty;
        private int roomid;
        private int floorid;
        private int inboxid;

        public Student()
        {
        }

        public Student(int studentid, string username, string firstname, string lastname, string password, string email, string phonenumber, int penalty, int roomid)
        {
            this.Studentid = studentid;
            this.Username = username;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Password = password;
            this.Email = email;
            this.Phonenumber = phonenumber;
            this.Penalty = penalty;
            this.Roomid = roomid;
        }

        public int Studentid { get => studentid; set => studentid = value; }
        public string Username { get => username; set => username = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public int Penalty { get => penalty; set => penalty = value; }
        public int Roomid { get => roomid; set => roomid = value; }
        public int Floorid { get => floorid; set => floorid = value; }
        public int Inboxid { get => inboxid; set => inboxid = value; }

        public string GetInfo()
        {
            return $"Username: {Username} \nName\t: {Firstname.ToUpper()} \nSurname : {Lastname.ToUpper()} \nRoom\t: {Roomid} \nGSM\t: {Phonenumber} \nEmail\t:{Email} \n\nPENALTY POINTS:\t{Penalty} pts.";  
        }

    }
}
