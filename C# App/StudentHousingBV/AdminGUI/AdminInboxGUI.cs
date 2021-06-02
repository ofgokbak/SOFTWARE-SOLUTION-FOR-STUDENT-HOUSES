using StudentHousingBV.Classes;
using StudentHousingBV.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.AdminGUI
{
    public partial class AdminInboxGUI : Form
    {
        StudentHousingSystem system = new StudentHousingSystem();
        Student p = new Student();
        DataAccess database = new DataAccess();
        List<Messages> studentmessages;
        Student admin;
        public AdminInboxGUI(List<Student> studentlist)
        {
            InitializeComponent();
            system.Students = studentlist;
        }

        private void AdminInboxGUI_Load(object sender, EventArgs e)
        {
            admin = system.Students.Find(x => x.Firstname == "Admin");
            studentmessages = database.GetMessages(admin.Studentid);
            loadmessages();
            btninbox.BackColor = Color.FromArgb(120, 0, 153);
        }

        public void loadmessages()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            int count = 0;
            while (studentmessages.Count != count)
            {

                dataGridView1.Rows.Add(studentmessages[count].Messagedate, system.GetStudentbyID(studentmessages[count].Fromstudentid).Firstname, studentmessages[count].Messagetext);
                DataGridViewRow row = dataGridView1.Rows[count];

                if (studentmessages[count].Ismessageread == false)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(161, 211, 162);
                }
                else
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

        private void btnMyTimetable_Click(object sender, EventArgs e)
        {
            AdminMGUI pg = new AdminMGUI(system.Students);
            pg.Show();
            this.Hide();
        }

        private void btnComplains_Click(object sender, EventArgs e)
        {
            AdminComplainsGUI pg = new AdminComplainsGUI(system.Students);
            pg.Show();
            this.Hide();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            AdminRules pg = new AdminRules(system.Students);
            pg.Show();
            this.Hide();
        }

        private void btnCheckTasks_Click(object sender, EventArgs e)
        {
             CheckingTasksGUI pg = new CheckingTasksGUI(system.Students);
            pg.Show();
            this.Hide();
        }

        private void btninbox_Click(object sender, EventArgs e)
        {
            AdminInboxGUI pg = new AdminInboxGUI(system.Students);
            pg.Show();
            this.Hide();
        }

       

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI pg = new LoginGUI();
            pg.Show();
            this.Hide();
        }

        private void btnnewmessage_Click(object sender, EventArgs e)
        {
            AdminSendMessage pg = new AdminSendMessage(p, system.Students);
            pg.BackColor = Color.LightGray;
            pg.Show();
           
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

        private void btnmarkread_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
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
                MessageBox.Show("Marked Read!");
            }
        }

        private void btnreflesh_Click(object sender, EventArgs e)
        {
            studentmessages = database.GetMessages(admin.Studentid);
            loadmessages();
            MessageBox.Show("Messages Loaded!");
        }
    }
}
