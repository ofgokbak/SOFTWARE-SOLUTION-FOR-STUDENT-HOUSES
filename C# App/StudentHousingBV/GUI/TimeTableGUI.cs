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
    public partial class TimeTableGUI : Form
    {
        Student student = new Student();
        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();
        List<TimeTable> timetable;
        List<Student> students;
        List<Messages> studentmessages;
        public TimeTableGUI(Student currentStudent, List<TimeTable> floortimetable, List<Student> studentlist, List<Messages> messages)
        {
            InitializeComponent();
            student = currentStudent;
            timetable = floortimetable;
            students = studentlist;
            system.Students = students;
            studentmessages = messages;
        }

        private void TimeTableGUI_Load(object sender, EventArgs e)
        {
            timetimer.Start();
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            lbUsername.Text = student.Firstname;
            lbpenaltypoints.Text = $"Penalty Points = {student.Penalty}";
            btnMyTimetable.BackColor = Color.FromArgb(120, 0, 153);
            timetablegridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 51, 138);
            timetablegridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            lbfloor.Text = $"Floor: {student.Floorid.ToString()}";
            pictureex.Visible = false;
            CheckNotification();
            loadtimetable();
        }

        private void TimeTableGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnMyTimetable_Click(object sender, EventArgs e)
        {
            TimeTableGUI newTab = new TimeTableGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnComplains_Click(object sender, EventArgs e)
        {
            ComplainsGUI newTab = new ComplainsGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            AnnouncementsAndRulesGUI newTab = new AnnouncementsAndRulesGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }


        private void lbLogout_LinkClicked(object sender, EventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loadtimetable()
        {
            
            timetablegridView.Rows.Add(system.GetStudentbyID(timetable[0].Studentid).Firstname, timetable[0].Taskname, timetable[1].Taskname, timetable[2].Taskname, timetable[3].Taskname, timetable[4].Taskname, timetable[5].Taskname, timetable[6].Taskname);
            checkstudentIDrow(0, 0);
            if (timetable.Count >= 14)
            {
                timetablegridView.Rows.Add(system.GetStudentbyID(timetable[8].Studentid).Firstname, timetable[7].Taskname, timetable[8].Taskname, timetable[9].Taskname, timetable[10].Taskname, timetable[11].Taskname, timetable[12].Taskname, timetable[13].Taskname);
                checkstudentIDrow(8,1);
            }
            if (timetable.Count >= 21)
            {

               timetablegridView.Rows.Add(system.GetStudentbyID(timetable[14].Studentid).Firstname, timetable[14].Taskname, timetable[15].Taskname, timetable[16].Taskname, timetable[17].Taskname, timetable[18].Taskname, timetable[19].Taskname, timetable[20].Taskname);
                checkstudentIDrow(14, 2);
            }

            if (timetable.Count >= 28)
            {
                timetablegridView.Rows.Add(system.GetStudentbyID(timetable[21].Studentid).Firstname, timetable[21].Taskname, timetable[22].Taskname, timetable[23].Taskname, timetable[24].Taskname, timetable[25].Taskname, timetable[26].Taskname, timetable[27].Taskname);
                checkstudentIDrow(21, 3);
            }

           

            DataGridViewColumn columnwed = timetablegridView.Columns[3];
            DataGridViewColumn columnfri = timetablegridView.Columns[5];
            columnwed.Width = 120;
            columnfri.Width = 89;
            foreach (DataGridViewRow row in timetablegridView.Rows)
            {
                row.Height = 65;
            }
            foreach (DataGridViewColumn c in timetablegridView.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 15F, GraphicsUnit.Pixel);
            }

            timetablegridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 15F, FontStyle.Regular);
            int height = 0;
            foreach (DataGridViewRow row in timetablegridView.Rows)
            {
                height += row.Height;
            }
            height += timetablegridView.ColumnHeadersHeight;

            int width = 0;
            foreach (DataGridViewColumn col in timetablegridView.Columns)
            {
                width += col.Width;
            }
            width += timetablegridView.RowHeadersWidth;

            timetablegridView.ClientSize = new Size(width + 2, height + 2);

            timetablegridView.ClearSelection();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            InBox pg = new InBox(student, timetable, students, studentmessages);
            pg.Show();
            this.Hide();
        }

        public void CheckNotification()
        {
            if(studentmessages.Exists(x=>x.Ismessageread == false))
            {
                pictureex.Visible = true;
            }
        }

        private void picturemessage_Click(object sender, EventArgs e)
        {
            if (studentmessages.Exists(x => x.Ismessageread == false))
            {
                MessageBox.Show("You have new message! Please check your inbox");
            }
            
        }

        private void pictureex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have new message! Please check your inbox");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsGUI newTab = new SettingsGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void timetimer_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }

        public void checkstudentIDrow(int index, int rowindex)
        {
            if (system.GetStudentbyID(timetable[index].Studentid).Studentid == student.Studentid)
            {
                DataGridViewRow row = timetablegridView.Rows[rowindex];
                row.DefaultCellStyle.BackColor = Color.FromArgb(161, 211, 162);
            }

        }
    }
}
