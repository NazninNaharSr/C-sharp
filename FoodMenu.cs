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
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();
            string[] selections = new string[7];
            selections[0] = "Select Here";
            selections[1] = "Breakfast";
            selections[2] = "Lunch";
            selections[3] = "Dinner";
            selections[4] = "Cleaning";
            selections[5] = "Towels";
            selections[6] = "Others";
            

            comboBoxfood.DataSource = selections;
        }
       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            FinalizePayment fp = new FinalizePayment();
            fp.Show();
            this.Hide();
        }

        private void breakfastCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dinnerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxfood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            string sql = "INSERT INTO FoodMenu (Select_Options) VALUES(@param1)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {

                con.Open();




                
                cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = comboBoxfood.Text;


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successfully");


                con.Close();
            }
        }

    }
    }

