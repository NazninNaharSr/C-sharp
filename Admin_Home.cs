using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Guest vg = new View_Guest();
            vg.Show();
            this.Hide();
        }

        private void buttonManageManager_Click(object sender, EventArgs e)
        {
            Manager_Registration mr = new Manager_Registration();
            mr.Show();
            this.Hide();

        }

        

        private void buttonAvailableRoom_Click(object sender, EventArgs e)
        {
            Available_Room ar = new Available_Room();
            ar.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
           this.Hide();
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
