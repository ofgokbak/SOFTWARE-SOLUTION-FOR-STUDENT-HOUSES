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
    public partial class AdminRules : Form
    {
        DataAccess database = new DataAccess();
        StudentHousingSystem system = new StudentHousingSystem();
        List<Rules> rules;
        //yo





        public AdminRules(List<Student> studentlist)
        {
            InitializeComponent();
            system.Students = studentlist;
        }


        private void AdminRules_Load(object sender, EventArgs e)
        {
            btnRules.BackColor = Color.FromArgb(120, 0, 153);
            rules = database.GetAllRules();
            loadRules();
        }

        public void loadRules()
        {

            dataGridView1.Rows.Clear();
            int count = 0;
            while (rules.Count != count)
            {

                dataGridView1.Rows.Add(rules[count].Ruledate, rules[count].Ruletext);

                count++;
            }
          
            //NOW ENABLE THE DATAGRID VIEW
            this.dataGridView1.Enabled = true;

            //MAKE DATAGRID VIEW READ ONLY
            this.dataGridView1.ReadOnly = false;

            
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 39, 40);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridViewColumn columndate = dataGridView1.Columns[0];
            DataGridViewColumn columnruletext = dataGridView1.Columns[1];
            columndate.Width = 120;
            columnruletext.Width = 600;
            columndate.ReadOnly = true;
            columnruletext.ReadOnly = true;
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

        private void lbaddcomplain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminAddRule pg = new AdminAddRule();
            pg.Show();
        }

        private void btnreflesh_Click(object sender, EventArgs e)
        {
            rules = database.GetAllRules();
            loadRules();
        }

        private void btndeleterule_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a rule to delete!");
            }
            else
            {
                var index = dataGridView1.CurrentCell.RowIndex;
                var output = rules[index];
                rules.RemoveAt(index);
                database.DeleteRulebyID(output.Ruleid);
                loadRules();
                MessageBox.Show("Rule Deleted!");
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

        private void BtnAddOrDeleteStudent_Click(object sender, EventArgs e)
        {
            //AdminGUI pg = new AdminGUI();
            //pg.Show();
            //this.Hide();
        }

        private void BtnComplains_Click(object sender, EventArgs e)
        {
            AdminComplainsGUI pg = new AdminComplainsGUI(system.Students);
            pg.Show();
            this.Hide();
        }

        private void BtnRules_Click(object sender, EventArgs e)
        {
            AdminRules pg = new AdminRules(system.Students);
            pg.Show();
            this.Hide();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {

        }

        private void LbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginGUI newTab = new LoginGUI();
            newTab.Show();
            this.Hide();
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

        private void btnCheckTasks_Click(object sender, EventArgs e)
        {
            CheckingTasksGUI newTab = new CheckingTasksGUI(system.Students);
            newTab.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
