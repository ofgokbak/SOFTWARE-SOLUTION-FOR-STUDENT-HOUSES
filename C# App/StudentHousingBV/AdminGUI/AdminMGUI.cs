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
    public partial class AdminMGUI : Form
    {
        Student person = new Student();
        DataAccess database = new DataAccess();
        StudentHousingSystem system = new StudentHousingSystem();

        public AdminMGUI(List<Student> studentlist)
        {
            InitializeComponent();
            system.Students = studentlist;
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            int floorid;
            int value;
            if (string.IsNullOrEmpty(tbusername.Text) || string.IsNullOrEmpty(tbpassword.Text)
                || string.IsNullOrEmpty(tbfirstname.Text) || string.IsNullOrEmpty(tblastname.Text) || string.IsNullOrEmpty(tbemail.Text)
                || string.IsNullOrEmpty(tbnumber.Text))
            {
                MessageBox.Show("Please Fill the Gaps");
            }
            else if (!int.TryParse(cbroomid.Text, out value))
            {
                MessageBox.Show("Please Enter an integer for Room ID");
            }
            else if (!int.TryParse(tbnumber.Text, out value))
            {
                MessageBox.Show("Phone number should be numberic ");
            }
            else
            {
                if (system.CheckUsernameExistence(tbusername.Text))
                {
                    MessageBox.Show("Username already Exists");
                }
                else if (system.CheckEmailExistence(tbemail.Text))
                {
                    MessageBox.Show("Email already exist!");
                }
                else if (system.CheckPhoneExistence(tbemail.Text))
                {
                    MessageBox.Show("Phone already exist!");
                }
                else if (system.CheckRoomExistence(Convert.ToInt32(cbroomid.Text)))
                {
                    MessageBox.Show("This room already taken!");
                }
                else if (tbnumber.TextLength > 10)
                {
                    MessageBox.Show("Phone number can not be that long!");
                }
                else
                {
                    if (cbroomid.Text == "101" || cbroomid.Text == "102" || cbroomid.Text == "103" || cbroomid.Text == "104"
                   || cbroomid.Text == "201" || cbroomid.Text == "202" || cbroomid.Text == "203" || cbroomid.Text == "204")
                    {
                        if (cbroomid.Text == "101" || cbroomid.Text == "102" || cbroomid.Text == "103" || cbroomid.Text == "104")
                        {
                            floorid = 1;
                        }
                        else
                        {
                            floorid = 2;
                        }
                        database.AddStudent(tbusername.Text, tbfirstname.Text, tblastname.Text, tbpassword.Text, tbemail.Text, tbnumber.Text, Convert.ToInt32(cbroomid.Text), floorid, Convert.ToInt32(cbroomid.Text));
                        system.GetStudents();
                        MessageBox.Show("Student Added Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Selected Room is not exist!");
                    }

                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure?", "Student Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(cbroomiddeletion.Text))
                {
                    MessageBox.Show("Please select a room!");
                }
                else
                {

                    database.DeleteStudent(person.Studentid, person.Roomid);
                    system.GetStudents();
                    MessageBox.Show("Student Deleted!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void AdminMGUI_Load(object sender, EventArgs e)
        {
           
            btnMyTimetable.BackColor = Color.FromArgb(120, 0, 153);
            tbpassword.PasswordChar = '*';
        }

        private void cbroomiddeletion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!system.CheckRoomExistence(Convert.ToInt32(cbroomiddeletion.Text)))
            {
                tbfnamedel.Clear();
                tblnamedel.Clear();
                MessageBox.Show("This Room is Empty!");

            }
            else
            {
                person = system.FindStudentbyRoomID(Convert.ToInt32(cbroomiddeletion.Text));
                tbfnamedel.Text = person.Firstname;
                tblnamedel.Text = person.Lastname;
            }
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            tbpassword.PasswordChar = '\0';
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            tbpassword.PasswordChar = '*';
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

        private void button1_Click(object sender, EventArgs e)
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(cbroomiddeletion.Text))
            {
                int roomid = Convert.ToInt32(cbroomiddeletion.SelectedItem);
                Student currentStudent = system.Students.Find(x => x.Roomid == roomid);
                MessageBox.Show(currentStudent.GetInfo());
            }
             
        }
    }
}
