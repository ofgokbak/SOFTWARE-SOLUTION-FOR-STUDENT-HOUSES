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
    public partial class ComplainsGUI : Form
    {
        Student student = new Student();
        StudentHousingSystem system = new StudentHousingSystem();
        List<Complain> complains;
        DataAccess database = new DataAccess();
        List<TimeTable> timetable;
        List<Student> students;
        List<Messages> studentmessages;

        public ComplainsGUI(Student currentStudent, List<TimeTable> floortimetable, List<Student> studentlist,List<Messages> messages)
        {
            InitializeComponent();
            student = currentStudent;
            timetable = floortimetable;
            students = studentlist;
            system.Students = students;
            studentmessages = messages;
        }

        private void Complains_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            btnComplains.BackColor = Color.FromArgb(120, 0, 153);
            lbUsername.Text = student.Firstname;
            lbPenatly.Text = $"Penalty Points = {student.Penalty}";
            complains = database.GetAllComplains();
            pictureex.Visible = false;
            CheckNotification();
            updateComplains();
            
        }

        public void CheckNotification()
        {
            if (studentmessages.Exists(x => x.Ismessageread == false))
            {
                pictureex.Visible = true;
            }
        }

        private void Complains_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void updateComplains()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 51, 138);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            int count = 0;
            while (complains.Count != count)
            {
                dataGridView1.Rows.Add(complains[count].Complaindate, complains[count].ComplainTopic1, complains[count].ComplainText1);
               
                count++;
            }

            //NOW ENABLE THE DATAGRID VIEW
            this.dataGridView1.Enabled = true;

            //MAKE DATAGRID VIEW READ ONLY
            this.dataGridView1.ReadOnly = true;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 20;
            }

            DataGridViewColumn columndate = dataGridView1.Columns[0];
            DataGridViewColumn columntopic = dataGridView1.Columns[1];
            DataGridViewColumn columntext = dataGridView1.Columns[2];
            columndate.Width = 135;
            columntopic.Width = 200;
            columntext.Width = 458;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Arial", 16F, GraphicsUnit.Pixel);
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16F, FontStyle.Regular);

            int height = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                height += row.Height;
            }
            height += dataGridView1.ColumnHeadersHeight;

            int width = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                width += col.Width;
            }
            width += dataGridView1.RowHeadersWidth;

            dataGridView1.ClientSize = new Size(width + 2, height + 2);

            for (int i = 0; i < dataGridView1.ColumnCount; i++) { dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; }


            dataGridView1.ClearSelection();
            
        }

        private void lbaddcomplain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddComplainGUI pg = new AddComplainGUI(student, timetable, students,studentmessages);
            pg.Show();
            this.Hide();
        }
        private void btnMyTimetable_Click(object sender, EventArgs e)
        {
            TimeTableGUI pg = new TimeTableGUI(student, timetable, students, studentmessages);
            pg.Show();
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
            InBox pg = new InBox(student, timetable, students, studentmessages);
            pg.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsGUI newTab = new SettingsGUI(student, timetable, students, studentmessages);
            newTab.Show();
            this.Hide();
        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
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
