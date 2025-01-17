﻿using StudentHousingBV.Classes;
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
    public partial class AdminSendMessage : Form
    {
        Student student = new Student();
        DataAccess database = new DataAccess();
        List<Student> students;
        Student admin;

        public AdminSendMessage(Student p, List<Student> studentlist)
        {
            InitializeComponent();
            student = p;
            students = studentlist;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnsendmessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbto.Text) || string.IsNullOrEmpty(cbto.Text))
            {
                MessageBox.Show("Please fill the gaps");
            }
            else
            {
                
                string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                admin = students.Find(x => x.Firstname == "Admin");
                int adminStudentID = admin.Studentid;
                if (cbto.Text == "Send All")
                {
                    foreach (var item in students)
                    {
                        if(item.Studentid!= adminStudentID)
                        {
                            database.SendMessage(item.Studentid, admin.Studentid, tbmessage.Text, false, date);

                        }
                    }
                    
                    MessageBox.Show("Message sent!");
                }
                else
                {
                    int index = cbto.SelectedIndex;
                    var output = students[index];
                    database.SendMessage(output.Studentid, admin.Studentid, tbmessage.Text, false, date);
                    MessageBox.Show("Message sent!");
                }
                
            }
        }

        private void AdminSendMessage_Load(object sender, EventArgs e)
        {
            admin = students.Find(x => x.Firstname == "Admin");
            int output = students.FindIndex(x => x.Firstname == "Admin");
            if (students.Exists(x => x.Firstname == "Admin"))
            {
                students.RemoveAt(output);
            }

            foreach (var item in students)
            {
                cbto.Items.Add(item.Firstname);
            }
            cbto.Items.Add("Send All");
            students.Add(admin);

        }
    }
}
