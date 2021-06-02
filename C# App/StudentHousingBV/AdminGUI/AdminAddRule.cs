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

namespace StudentHousingBV.AdminGUI
{
    public partial class AdminAddRule : Form
    {
        DataAccess database = new DataAccess();

        public AdminAddRule()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            database.AddRule(tbruletext.Text, date);
            MessageBox.Show("Rules Added");
            tbruletext.Clear();
        }
    }
}
