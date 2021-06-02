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
using StudentHousingBV.AdminGUI;

namespace StudentHousingBV.AdminGUI
{
    public partial class AdminComplainsGUI : Form
    {
        DataAccess database = new DataAccess();
        StudentHousingSystem system = new StudentHousingSystem();
        List<Complain> complains;
        public AdminComplainsGUI(List<Student> studentlist)
        {
            InitializeComponent();
            system.Students = studentlist;
        }

        private void AdminComplainsGUI_Load(object sender, EventArgs e)
        {
            btnComplains.BackColor = Color.FromArgb(120, 0, 153);
            complains = database.GetAllComplains();
            updateComplains();
        }

        public void updateComplains()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            int count = 0;
            while (complains.Count != count)
            {

                dataGridView1.Rows.Add(complains[count].Complaindate, system.GetStudentbyID(complains[count].StudentID1).Firstname, complains[count].ComplainTopic1, complains[count].ComplainText1);

                count++;



            }


            //NOW ENABLE THE DATAGRID VIEW
            this.dataGridView1.Enabled = true;

            //MAKE DATAGRID VIEW READ ONLY
            this.dataGridView1.ReadOnly = false;


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 20;
            }

            DataGridViewColumn columndate = dataGridView1.Columns[0];
            DataGridViewColumn columntopic = dataGridView1.Columns[1];
            DataGridViewColumn columnfrom = dataGridView1.Columns[2];
            DataGridViewColumn columntext = dataGridView1.Columns[3];
       
            
            columndate.Width = 135;
            columndate.ReadOnly = true;
            columntopic.Width = 150;
            columntopic.ReadOnly = true;
            columntext.Width = 400;
            columntext.ReadOnly = true;
            columnfrom.Width = 150;
            columnfrom.ReadOnly = true;


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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
        private void btnregister_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a complain to delete!");
            }
            else
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                var output = complains[index];
                complains.RemoveAt(index);
                updateComplains();
                database.DeleteComplainbyID(output.ComplainID1);
                MessageBox.Show("Complain Deleted!");
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
        }

        private void btninbox_Click(object sender, EventArgs e)
        {
            AdminInboxGUI newTab = new AdminInboxGUI(system.Students);
            newTab.Show();
            this.Hide();
        }

       
    }
}
