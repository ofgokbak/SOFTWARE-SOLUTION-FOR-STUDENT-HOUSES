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
    public partial class InBox : Form
    {
        Student student = new Student();
        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();
        List<TimeTable> timetable;
        List<Student> students;
        List<Messages> studentmessages;
        public InBox(Student currentStudent, List<TimeTable> floortimetable, List<Student> studentlist, List<Messages> messages)
        {
            InitializeComponent();
            student = currentStudent;
            timetable = floortimetable;
            students = studentlist;
            system.Students = students;
            studentmessages = messages;
        }

        private void btnnewmessage_Click(object sender, EventArgs e)
        {
            SendMessageGUI pg = new SendMessageGUI(student,students);
            pg.Show();
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
        public void loadmessages()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(74, 51, 138);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            int count = 0;
            while (studentmessages.Count != count)
            {

                dataGridView1.Rows.Add(studentmessages[count].Messagedate, system.GetStudentbyID(studentmessages[count].Fromstudentid).Firstname, studentmessages[count].Messagetext);
                DataGridViewRow row = dataGridView1.Rows[count];
                
                    if (studentmessages[count].Ismessageread == false)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(161, 211, 162);
                    }else
                    {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(238, 237, 239);
                    }
                
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

        private void InBox_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            btnInbox.BackColor = Color.FromArgb(120, 0, 153);
            lbUsername.Text = student.Firstname;
            lbPenatly.Text = $"Penalty Points = {student.Penalty}";
            CheckNotification();
            studentmessages = database.GetMessages(student.Studentid);
            loadmessages();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMyTimetable_Click(object sender, EventArgs e)
        {
            TimeTableGUI pg = new TimeTableGUI(student, timetable, students, studentmessages);
            pg.Show();
            this.Hide();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI pg = new LoginGUI();
            pg.Show();
            this.Hide();
        }

        private void btnreflesh_Click(object sender, EventArgs e)
        {
            studentmessages = database.GetMessages(student.Studentid);
            loadmessages();
            CheckNotification();
            MessageBox.Show("Messages Loaded!");
        }

        private void btnmarkread_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a message!");
            }
            else
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                var output = studentmessages[index];
                database.MarkRead(output.Messageid);
                output.Ismessageread = true;
                loadmessages();
                CheckNotification();
                MessageBox.Show("Marked Read!");
                
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    if (dataGridView1.SelectedRows.Count > 1)
                    {
                        MessageBox.Show("Can not select multiple rows");
                    }
                    else
                    {




                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Can not select column name!");
            }
        }

        private void btnComplains_Click(object sender, EventArgs e)
        {
            ComplainsGUI pg = new ComplainsGUI(student, timetable, students, studentmessages);
            pg.Show();
            this.Hide();
        }

        private void btnAnouncements_Click(object sender, EventArgs e)
        {
            AnnouncementsAndRulesGUI pg = new AnnouncementsAndRulesGUI(student, timetable, students, studentmessages);
            pg.Show();
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
            SettingsGUI pg = new SettingsGUI(student, timetable, students, studentmessages);
            pg.Show();
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

        private void btndeletemessage_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a message to delete!");
            }
            else
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                var output = studentmessages[index];
                studentmessages.RemoveAt(index);
                loadmessages();
                database.DeleteMessage(output.Messageid);
                MessageBox.Show("Message Deleted!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }
    }
}
