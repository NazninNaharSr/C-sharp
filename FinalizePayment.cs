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
    public partial class FinalizePayment : Form
    {
        public FinalizePayment()
        {
            InitializeComponent();
            CenterToParent();
            string[] p = new string[3];
            //p[0] = "select Here";
            p[0] = "Cash";
            p[1] = "Card";


            paymentTypecomboBox.DataSource = p;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinalizePayment_Load(object sender, EventArgs e)
        {


        }

        private void buttonNext_Click(object sender, EventArgs e)
        {


        }

        private void comboBoxMM_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void mainpagebutton_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();


        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";


            string sql = "INSERT INTO Payment (Food_Bill,Tax,Reservation_Bill,Total,Payment_Type) VALUES(@param1,@param2,@param3,@param4,@param5)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {

                con.Open();




                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = int.Parse(textBoxfoodbill.Text);
                cmd.Parameters.Add("@param2", SqlDbType.Int).Value = int.Parse(textBoxtax.Text);
                cmd.Parameters.Add("@param3", SqlDbType.Int).Value = int.Parse(textBoxreservationBill.Text);
                cmd.Parameters.Add("@param4", SqlDbType.Int).Value = int.Parse(textBoxtotal.Text);

                cmd.Parameters.Add("@param5", SqlDbType.VarChar).Value = paymentTypecomboBox.Text;


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("insert successfully");


                con.Close();
            }
        }

        private void textBoxfoodbill_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
