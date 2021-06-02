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
    public partial class EditEventsGUI : Form
    {
        Student student = new Student();
        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();
        List<TimeTable> timetable;
        List<Student> students;
        List<Messages> studentmessages;
        Dictionary<string, string> newEvents = new Dictionary<string, string>();
        List<Announcements> announcements = new List<Announcements>();

        public EditEventsGUI(Student currentStudent, List<TimeTable> floortimetable, List<Student> studentlist, List<Messages> messages)
        {
            InitializeComponent();
            student = currentStudent;
            timetable = floortimetable;
            students = studentlist;
            system.Students = students;
            studentmessages = messages;
        }

        private void EditEventsGUI_Load(object sender, EventArgs e)
        {
            calendar.Visible = false;
            timer1.Start();
            btnAnouncements.BackColor = Color.FromArgb(120, 0, 153);
            CheckNotification();
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            lbUsername.Text = student.Firstname;
            lbpenaltypoints.Text = $"Penalty Points = {student.Penalty}";
            Restart();
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            AnnouncementsAndRulesGUI newTab = new AnnouncementsAndRulesGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void lbback_Click(object sender, EventArgs e)
        {
            AnnouncementsAndRulesGUI newTab = new AnnouncementsAndRulesGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditEventsGUI_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            SaveChanges();
            AnnouncementsAndRulesGUI newTab = new AnnouncementsAndRulesGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }

        private void btnEventsReset_Click(object sender, EventArgs e)
        {
            Restart();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string date = calendar.SelectionRange.Start.ToString("dd.MM.yyyy");
            string time = cbxTime.Text;

            if (cbxTime.Text == string.Empty)
            {
                MessageBox.Show("Please select your reservation time.");
            }
            else
            {
                date = string.Join(" ", date, time);
                string description = rbxDescription.Text;

                string reservation = CheckReservation(date);
                if (reservation == "The date & time are free")
                {
                    lbxEvents.Items.Add($"{date}: {description}");
                    newEvents.Add(date, description);
                }
                else
                    MessageBox.Show("Your date & time of choice are already reserved for another event.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Take caution: If you delete this announcement now, it will be lost forever.", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (lbxEvents.SelectedItems.Count > 0)
                {
                    int announcementId = lbxEvents.SelectedIndex;
                    List<string> row = lbxEvents.SelectedItem.ToString().Split().ToList();
                    string date = string.Join(" ", row[0], row[1].TrimEnd(':'));

                    try
                    {
                        var announcement = announcements[announcementId];
                        database.DeleteAnnouncement(announcement.Announcementid);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        /* if the announcement is not saved in the database,
                         * but only stored as a new announcement in this form's
                         * collection, it will result in running this catch statement */
                        newEvents.Remove(date);
                    }
                    lbxEvents.Items.RemoveAt(announcementId);
                }
                else
                {
                    MessageBox.Show("Please select an announcement to delete.");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void SaveChanges()
        {
            foreach (var item in newEvents)
            {
                string[] dateAndTime = item.Key.Split().ToArray();
                database.AddAnnouncement(student.Studentid, item.Value, dateAndTime[0], dateAndTime[1]);
            }
            Restart();
        }

        private void Restart()
        {
            newEvents.Clear();
            lbxEvents.Items.Clear();
            announcements.Clear();
            announcements = database.GetAllAnnouncements();
            foreach (var announcement in announcements)
            {
                string postedDate = $"{announcement.Announcementdate} {announcement.Announcementhours}";
                lbxEvents.Items.Add($"{postedDate}: {announcement.Announcementtext}");
            }
        }

        private string CheckReservation(string date)
        {
            foreach (var announcement in announcements)
            {
                string reservation = string.Join(" ", announcement.Announcementdate, announcement.Announcementhours);

                if (reservation == date)
                {
                    // Comparing the date(i.e. the key) with the same amount of symbols from the start of the KVPs,
                    // allows us to prevent a variety of bugs occuring, such as, for example, the one that pops out
                    // when the date is actually contained within the value (i.e. the description), instead of the key
                    foreach (var row in lbxEvents.Items)
                    {
                        string displayedAnnouncement = row.ToString();
                        if (string.IsNullOrWhiteSpace(displayedAnnouncement))
                            continue;
                        StringBuilder sb = new StringBuilder(date.Length); // date.length limits the chars added

                        // Recreates the key from the first chars in the listbox
                        for (int i = 0; i < date.Length; i++)
                        {
                            char symbol = displayedAnnouncement[i];
                            sb.Append(symbol); // sticks them together
                        }
                        // if the keys match
                        if (date == sb.ToString())
                        {
                            return "The date & time are already taken";
                        }
                    }
                }
            }

            foreach (var announcement in newEvents.Keys)
            {
                if (date == announcement)
                {
                    return "The date & time are already taken";
                }
            }
            return "The date & time are free";
        }

        public void CheckNotification()
        {
            if (studentmessages.Exists(x => x.Ismessageread == false))
            {
                pictureex.Visible = true;
            }
            else
            {
                pictureex.Visible = false;
            }
        }

        private void lbselectdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (calendar.Visible == false)
            {
                calendar.Visible = true;
            }
            else
            {
                calendar.Visible = false;
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

        private void btnClearText_Click(object sender, EventArgs e)
        {
            rbxDescription.Text = "Type your announcement here...";
        }

        private void rbxDescription_Click(object sender, EventArgs e)
        {
            calendar.Visible = false;
            if (rbxDescription.Text == "Type your announcement here...")
            {
                rbxDescription.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }
    }
}
