using System;
using StudentHousingBV.AdminGUI;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousingBV.Classes;
using System.Diagnostics;

namespace StudentHousingBV.GUI
{
    public partial class CheckingTasksGUI : Form
    {
        StudentHousingSystem system = new StudentHousingSystem();
        DataAccess database = new DataAccess();

        private int dayID = 1;
        private int floorID = 1;
        private int taskID = 1;


        public CheckingTasksGUI(List<Student> studentlist)
        {
            InitializeComponent();
            system.Students = studentlist;
        }

        private void CheckingTasksGUI_Load(object sender, EventArgs e)
        {
            btnCheckTasks.BackColor = Color.FromArgb(120, 0, 153);
            dayID = GetDayIndex();
            cbSelectedFloor.Visible = false;
            cbSelectedTask.Visible = false;
        }

        /// <summary>
        /// Get index of current day.
        /// </summary>
        /// <returns></returns>
        private int GetDayIndex()
        {
            int dayId = (int)System.DateTime.Now.DayOfWeek;
            if (dayId == 0)
            {
                dayId = 7;
            }
            return dayId;
        }


        private void PbKitchen_Click(object sender, EventArgs e)
        {
            defaultPbTasksSize(pbShopping);
            defaultPbTasksSize(pbToiletAndBath);
            changePbTaskSize(pbKitchen);

            cbSelectedTask.Visible = true;
            cbSelectedTask.Checked = true;
            // relocated CheckBox under  selected PictureBox.
            cbSelectedTask.Location = new System.Drawing.Point(128, 215);

            dayID = GetDayIndex();
            //Set taskid for Kitchen  same with database.
            taskID = 1;

        }

        private void PbToiletAndBath_Click(object sender, EventArgs e)
        {
            defaultPbTasksSize(pbShopping);
            defaultPbTasksSize(pbKitchen);
            changePbTaskSize(pbToiletAndBath);

            cbSelectedTask.Visible = true;
            cbSelectedTask.Checked = true;
            // relocated CheckBox under  selected PictureBox.
            cbSelectedTask.Location = new System.Drawing.Point(388, 215);

            dayID = GetDayIndex();
            //Set taskid for Bathroom/Toilets same with database.
            taskID = 2;

        }

        private void PbShopping_Click(object sender, EventArgs e)
        {
            defaultPbTasksSize(pbKitchen);
            defaultPbTasksSize(pbToiletAndBath);
            changePbTaskSize(pbShopping);

            cbSelectedTask.Visible = true;
            cbSelectedTask.Checked = true;
            // relocated CheckBox under  selected PictureBox.
            cbSelectedTask.Location = new System.Drawing.Point(648, 215);

            dayID = GetDayIndex();
            //Set taskid for "shopping shared items" same with database.
            taskID = 4;
        }


        /// <summary>
        /// Resize smaller chosen PictureBox. 
        /// </summary>
        /// <param name="pb"></param> Chosen PictureBox.
        void changePbTaskSize(PictureBox pb)
        {
            // Default size of Tasks PictureBoxes
            Size size = new System.Drawing.Size(200, 200);
            if (pb.Size == size)
            {
                pb.Size = new System.Drawing.Size(185, 185);
            }

        }

        /// <summary>
        /// Default size for Tasks PictureBoxes.
        /// </summary>
        /// <param name="pb"></param> Chosen PictureBox.
        void defaultPbTasksSize(PictureBox pb)
        {

            Size size = new System.Drawing.Size(200, 200);
            if (pb.Size != size)
            {
                pb.Size = new System.Drawing.Size(200, 200);

            }
        }

        /// <summary>
        /// Resize smaller chosen Floor's PictureBox.
        /// </summary>
        /// <param name="pb"></param> Chosen PictureBox.
        void changePbFloorSize(PictureBox pb)
        {
            Size size = new System.Drawing.Size(100, 85);
            if (pb.Size == size)
            {
                pb.Size = new System.Drawing.Size(90, 75);
            }

        }

        /// <summary>
        /// Default size chosen Floor's PictureBox.
        /// </summary>
        /// <param name="pb"></param> chosen PictureBox.
        void defaultPbFloorsSize(PictureBox pb)
        {
            Size size = new System.Drawing.Size(100, 85);
            if (pb.Size != size)
            {
                pb.Size = new System.Drawing.Size(100, 85);

            }
        }

        private void Pb1stFloor_Click(object sender, EventArgs e)
        {

            defaultPbFloorsSize(pb2ndFloor);
            defaultPbFloorsSize(pb3rdFloor);
            defaultPbFloorsSize(pb4thFloor);
            defaultPbFloorsSize(pb5thFloor);
            changePbFloorSize(pb1stFloor);

            // relocated CheckBox under  selected PictureBox.
            cbSelectedFloor.Location = new System.Drawing.Point(147, 103);
            cbSelectedFloor.Visible = true;
            cbSelectedFloor.Checked = true;

            floorID = 1;

        }

        private void Pb2ndFloor_Click(object sender, EventArgs e)
        {

            defaultPbFloorsSize(pb1stFloor);
            defaultPbFloorsSize(pb3rdFloor);
            defaultPbFloorsSize(pb4thFloor);
            defaultPbFloorsSize(pb5thFloor);
            changePbFloorSize(pb2ndFloor);
            floorID = 2;

            // relocated CheckBox under  selected PictureBox.
            cbSelectedFloor.Location = new System.Drawing.Point(266, 103);
            cbSelectedFloor.Visible = true;
            cbSelectedFloor.Checked = true;

        }

        private void Pb3rdFloor_Click(object sender, EventArgs e)
        {

            defaultPbFloorsSize(pb2ndFloor);
            defaultPbFloorsSize(pb1stFloor);
            defaultPbFloorsSize(pb4thFloor);
            defaultPbFloorsSize(pb5thFloor);
            changePbFloorSize(pb3rdFloor);
            floorID = 3;

            // relocated CheckBox under  selected PictureBox.
            cbSelectedFloor.Location = new System.Drawing.Point(386, 103);
            cbSelectedFloor.Visible = true;
            cbSelectedFloor.Checked = true;

        }

        private void Pb4thFloor_Click(object sender, EventArgs e)
        {

            defaultPbFloorsSize(pb2ndFloor);
            defaultPbFloorsSize(pb3rdFloor);
            defaultPbFloorsSize(pb1stFloor);
            defaultPbFloorsSize(pb5thFloor);
            changePbFloorSize(pb4thFloor);
            floorID = 4;

            // relocated CheckBox under  selected PictureBox.
            cbSelectedFloor.Location = new System.Drawing.Point(507, 103);
            cbSelectedFloor.Visible = true;
            cbSelectedFloor.Checked = true;

        }

        private void Pb5thFloor_Click(object sender, EventArgs e)
        {

            defaultPbFloorsSize(pb2ndFloor);
            defaultPbFloorsSize(pb3rdFloor);
            defaultPbFloorsSize(pb4thFloor);
            defaultPbFloorsSize(pb1stFloor);
            changePbFloorSize(pb5thFloor);
            floorID = 5;

            // relocated CheckBox under  selected PictureBox.
            cbSelectedFloor.Location = new System.Drawing.Point(632, 103);
            cbSelectedFloor.Visible = true;
            cbSelectedFloor.Checked = true;

        }

        private void btnMyTimetable_Click(object sender, EventArgs e)
        {
            AdminMGUI newTab = new AdminMGUI(system.Students);
            newTab.Show();
            this.Hide();
        }

        private void btnComplains_Click_1(object sender, EventArgs e)
        {
            AdminComplainsGUI newTab = new AdminComplainsGUI(system.Students);
            newTab.Show();
            this.Hide();
        }

        private void btnRules_Click_1(object sender, EventArgs e)
        {
            AdminRules newTab = new AdminRules(system.Students);
            newTab.Show();
            this.Hide();
        }

        private void btnCheckTasks_Click_1(object sender, EventArgs e)
        {
            CheckingTasksGUI newTab = new CheckingTasksGUI(system.Students);
            newTab.Show();
            this.Hide();
        }

        private void btninbox_Click(object sender, EventArgs e)
        {
            AdminInboxGUI newTab = new AdminInboxGUI(system.Students);
            newTab.Show();
            this.Hide();
        }


        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLogout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            // if chosen task exists and someone responsible with it.
            if (database.TaskExists(floorID, dayID, taskID))
            {
                // if chosen task was not confirmed yet.
                if (!system.TaskWasChecked(dayID, taskID, floorID))
                {
                    // Find exact task from timetable database and mark it as "Done".
                    database.SetCompletedRowInDatabase(floorID, dayID, taskID, true);
                    MessageBox.Show("CONFIRMED: Task was marked as 'DONE'");
                }
                else
                {
                    MessageBox.Show("WARNING: Task was already checked!");
                }
            }
            else
            {
                MessageBox.Show("ERROR: No one is assigned to chosen task!");
            }
        }

        private void btnundone_Click(object sender, EventArgs e)
        {

            // if chosen task exists and someone responsible with it. 
            if (database.TaskExists(floorID, dayID, taskID))
            {
                // if chosen task was not confirmed yet.
                if (!system.TaskWasChecked(dayID, taskID, floorID))
                {
                    database.SetCompletedRowInDatabase(floorID, dayID, taskID, false);
                    system.UpdatePenaltyPoint(dayID, floorID, taskID);

                    // SendUndoneMessages();
                    MessageBox.Show("CONFIRMED: Task was marked as 'UNDONE'");
                }
                else
                {
                    MessageBox.Show("WARNING: Task was already checked!");
                }
            }
            else
            {
                MessageBox.Show("ERROR: No one is assigned to chosen task!");
            }


        }



        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckTasks_StatusGUI newtab = new CheckTasks_StatusGUI(system.Students);
            newtab.Show();
            this.Hide();
        }

        private void lbupdatetasks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure? This process can be take a few minutes!", "Update All TimeTables", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                MessageBox.Show($"Please wait while updating timetables");
                database.UpdateTimeTables();
                MessageBox.Show("DONE");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }


    }
}

