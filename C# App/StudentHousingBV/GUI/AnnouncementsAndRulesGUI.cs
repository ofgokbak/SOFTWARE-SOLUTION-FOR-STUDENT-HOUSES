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
    public partial class AnnouncementsAndRulesGUI : Form
    {
        Student student = new Student();
        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();
        List<TimeTable> timetable;
        List<Student> students;
        List<Messages> studentmessages;

        public AnnouncementsAndRulesGUI(Student currentStudent, List<TimeTable> floortimetable, List<Student> studentlist, List<Messages> messages)
        {
            InitializeComponent();
            student = currentStudent;
            timetable = floortimetable;
            students = studentlist;
            system.Students = students;
            studentmessages = messages;
        }
        public void CheckNotification()
        {
            if (studentmessages.Exists(x => x.Ismessageread == false))
            {
                pictureex.Visible = true;
            }
        }

        private void AnnouncementsAndRules_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            btnAnouncements.BackColor = Color.FromArgb(120, 0, 153);
            lbUsername.Text = student.Firstname;
            lbpenaltypoints.Text = $"Penalty Points = {student.Penalty}";
            pictureex.Visible = false;
            CheckNotification();

            foreach (var announcement in database.GetAllAnnouncements())
            {
                lbxEvents.Items.Add($"{announcement.Announcementdate} {announcement.Announcementhours}: {announcement.Announcementtext}");
            }

            foreach (var rule in database.GetAllRules())
            {
                lbxRules.Items.Add($"{rule.Ruledate}: {rule.Ruletext}");
            }
        }

        private void AnnouncementsAndRules_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditEvents_Click(object sender, EventArgs e)
        {
            EditEventsGUI newTab = new EditEventsGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
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

        private void btnAnouncements_Click(object sender, EventArgs e)
        {
            AnnouncementsAndRulesGUI newTab = new AnnouncementsAndRulesGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            InBox newTab = new InBox(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsGUI newTab = new SettingsGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }
    }
}
