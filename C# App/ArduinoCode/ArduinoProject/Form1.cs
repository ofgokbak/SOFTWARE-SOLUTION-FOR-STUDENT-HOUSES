using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoProject
{
    public partial class Form1 : Form
    {
        DataAccess database = new DataAccess();
        Task task = new Task();

        int dayID = 0;
        int floorID = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM3";
            serialPort1.Open();
            timer1.Start();
        }


        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            string readPort = serialPort1.ReadLine();
            readPort = readPort.Trim();
            dayID = getDayIndex();


            switch (readPort)
            {
                case "1": floorID = 1; break;
                case "2": floorID = 2; break;
                case "3": floorID = 3; break;
                case "4": floorID = 4; break;
                case "5": floorID = 5; break;

            }
            
            if (!task.TaskWasAlreadyChecked(dayID,floorID))
            {
                database.SetTaskCompletedStatus(floorID, dayID);
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            dayID = getDayIndex();
            string checkCurrentTime = DateTime.Now.ToString("HH:mm");

            if (checkCurrentTime == "17:48")
            {
              task.CheckUndoneTasks(dayID);
            }
        }

        /// <summary>
        /// Gets index of current day.
        /// </summary>
        /// <returns></returns>
        public int getDayIndex()
        {
            dayID = (int)System.DateTime.Now.DayOfWeek;
            if (dayID == 0)
            {
                dayID = 7;
            }
            return dayID;
        }

    }
}
