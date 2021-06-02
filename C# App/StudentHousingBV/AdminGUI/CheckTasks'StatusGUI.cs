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
using StudentHousingBV.GUI;


namespace StudentHousingBV.AdminGUI
{
    public partial class CheckTasks_StatusGUI : Form
    {

        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();
        List<TimeTable> allTasks;
        private int toggle=0;
        private int floorid;

        public CheckTasks_StatusGUI(List<Student> studentlist)
        {
            InitializeComponent();
            system.Students = studentlist;
            toggle = 0;
        }

        private void CheckTasks_StatusGUI_Load(object sender, EventArgs e)
        {

            allTasks = database.GetAllTimeTables();
            //timeTimer.Start();
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            loadtimetable();
            toggle = 1;
        }


        private void BtnAddOrDeleteStudent_Click(object sender, EventArgs e)
        {
            AdminMGUI newTab = new AdminMGUI(system.Students);
            newTab.Show();
            this.Hide();
        }

        private void BtnComplains_Click(object sender, EventArgs e)
        {
            AdminComplainsGUI newTab = new AdminComplainsGUI(system.Students);
            newTab.Show();
            this.Hide();
        }


        private void BtnManageRules_Click(object sender, EventArgs e)
        {
            AdminRules newTab = new AdminRules(system.Students);
            newTab.Show();
            this.Hide();
        }

        private void BtnCheckTasks_Click(object sender, EventArgs e)
        {
            CheckingTasksGUI newTab = new CheckingTasksGUI(system.Students);
            newTab.Show();
            this.Hide();
        }

        private void BtnInbox_Click(object sender, EventArgs e)
        {
            AdminInboxGUI newTab = new AdminInboxGUI(system.Students);
            newTab.Show();
            this.Hide();
        }


        private void LbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        
        public void loadtimetable()
        {
            timetablegridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            timetablegridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            //when program starts floor is not specified yet.
            if (!String.IsNullOrWhiteSpace(cmboxFloors.Text))
            {
                floorid = cmboxFloors.SelectedIndex + 1;
            }
            else
            {
                cmboxFloors.Text = "1st";
                floorid = 1;
            }

            timetablegridView.Rows.Add("Cleaning Kitchen", system.GetCurrentTaskStatus(allTasks, 1, floorid, 1), system.GetCurrentTaskStatus(allTasks, 2, floorid, 1), system.GetCurrentTaskStatus(allTasks, 3, floorid, 1), system.GetCurrentTaskStatus(allTasks, 4, floorid, 1), system.GetCurrentTaskStatus(allTasks, 5, floorid, 1), system.GetCurrentTaskStatus(allTasks, 6, floorid, 1), system.GetCurrentTaskStatus(allTasks, 7, floorid, 1));

            timetablegridView.Rows.Add("Cleaning Toilet/Bathroom", system.GetCurrentTaskStatus(allTasks, 1, floorid, 2), system.GetCurrentTaskStatus(allTasks, 2, floorid, 2), system.GetCurrentTaskStatus(allTasks, 3, floorid, 2), system.GetCurrentTaskStatus(allTasks, 4, floorid, 2), system.GetCurrentTaskStatus(allTasks, 5, floorid, 2), system.GetCurrentTaskStatus(allTasks, 6, floorid, 2), system.GetCurrentTaskStatus(allTasks, 7, floorid, 2));

            timetablegridView.Rows.Add("Throwing Garbage", system.GetCurrentTaskStatus(allTasks, 1, floorid, 3), system.GetCurrentTaskStatus(allTasks, 2, floorid, 3), system.GetCurrentTaskStatus(allTasks, 3, floorid, 3), system.GetCurrentTaskStatus(allTasks, 4, floorid, 3), system.GetCurrentTaskStatus(allTasks, 5, floorid, 3), system.GetCurrentTaskStatus(allTasks, 6, floorid, 3), system.GetCurrentTaskStatus(allTasks, 7, floorid, 3));

            timetablegridView.Rows.Add("Shopping Shared Items", system.GetCurrentTaskStatus(allTasks, 1, floorid, 4), system.GetCurrentTaskStatus(allTasks, 2, floorid, 4), system.GetCurrentTaskStatus(allTasks, 3, floorid, 4), system.GetCurrentTaskStatus(allTasks, 4, floorid, 4), system.GetCurrentTaskStatus(allTasks, 5, floorid, 4), system.GetCurrentTaskStatus(allTasks, 6, floorid, 4), system.GetCurrentTaskStatus(allTasks, 7, floorid, 4));



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
            updateCellsColor();
            timetablegridView.ClearSelection();
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            labeltime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }

        private void CmboxFloors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //User selected a new floor.
            if (toggle == 1)
            {
                timetablegridView.Rows.Clear();
                loadtimetable();
            }
        }

        public void updateCellsColor()
        {
            for (int i = 0; i < timetablegridView.Rows.Count; i++)
            {
                string value = "";
                int count = timetablegridView.Rows[i].Cells.Count;
                for (int j = 0; j < count; j++)
                {
                    value = timetablegridView.Rows[i].Cells[j].Value.ToString();
                    if (value.Contains("UNDONE"))
                    {
                        timetablegridView.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(245, 75, 80);
                    }else if (value.Contains("DONE"))
                    {
                        timetablegridView.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(161, 211, 162);
                    }
                }

            }

        }
    }
}
