using StudentHousingBV.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.GUI
{
    public partial class SendMessageGUI : Form
    {
        Student student = new Student();
        DataAccess database = new DataAccess();
        List<Student> students;
        Student selectedstudent;
        public SendMessageGUI(Student currentStudent, List<Student> studentlist)
        {
            InitializeComponent();
            student = currentStudent;
            students = studentlist;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsendmessage_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbto.Text) || string.IsNullOrEmpty(cbto.Text))
            {
                MessageBox.Show("Please fill the gaps");
            }
            else
            {
                string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                int index = cbto.SelectedIndex;
                var output = students[index];
                database.SendMessage(output.Studentid,student.Studentid,tbmessage.Text,false,date);
                MessageBox.Show("Message sent!");
            }
         
        }

        private void SendMessageGUI_Load(object sender, EventArgs e)
        {
            selectedstudent = students.Find(x => x.Studentid == student.Studentid);
            int output = students.FindIndex(x => x.Studentid == student.Studentid);
            if(students.Exists(x=> x.Studentid == student.Studentid))
            {
                students.RemoveAt(output);
            }
           
            foreach (var item in students)
            {
                cbto.Items.Add(item.Firstname);
            }
            students.Add(selectedstudent);
        }
    }
}
