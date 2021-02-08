using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
            
        
        private void buttonlogin_Click(object sender, EventArgs e)
        {
           // try
            //{
                if (verifierManager("Fontend".Trim(), textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim()))
                {
                    this.Hide();
                    Frontend f = new Frontend();
                    f.Show();
                }
                else if (verifierAdmin("Admin_Home".Trim(), textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim()))
                {
                    this.Hide();
                    Admin_Home ah = new Admin_Home();
                    ah.Show();
                }
                else
                {
                    MessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            //}
           /* catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }*/
        }

        /*private bool verifierManager(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        private bool verifierAdmin(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        */
        public bool verifierAdmin(string tableName, string UserName, string Password)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            string sql = "SELECT UserName, Password FROM Admin WHERE(UserName = '" + UserName + "') AND(Password = '" + Password.Trim() + "')";

            SqlCommand commmand = new SqlCommand(sql, con);
            con.Open();

            var check = commmand.ExecuteScalar();

            if (check != null)
            {
                return true;
            }
            else return false;
        }
        public bool verifierManager(string tableName, string UserName, string Password)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            string sql = "SELECT UserName, Password FROM Manager WHERE(UserName = '" + UserName + "') AND(Password = '" + Password.Trim() + "')";

            SqlCommand commmand = new SqlCommand(sql, con);
            con.Open();

            var check = commmand.ExecuteScalar();

            if (check != null)
            {
                return true;
            }
            else return false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }
    }
}
