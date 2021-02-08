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
    public partial class Manager_Registration : Form
    {
        //int Manager_ID;

        //string ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = True";
        public Manager_Registration()
        {
            InitializeComponent();
        }
       

        

        private void Manager_Registration_Load(object sender, EventArgs e)
        {
            //PopulateComboBox();
        }

        /*void PopulateComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM ManagerRegistration", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Room_Type.ValueMember = "Manager_ID";
                Room_Type.DisplayMember = "Room_Type";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "Select";
                dtbl.Rows.InsertAt(topItem, 0);
                Room_Type.DataSource = dtbl;
            }
        }*/

            void DataGridVIewRow()
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =DESKTOP-SPI0GI3 ;database =Hotel Management System;integrated security = SSPI";


            string sql = "delete from ManagerRegistration where Manager_ID=@param1";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {

                con.Open();


                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = int.Parse(textBoxManagerID.Text);



                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted successfully!!!");


                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxManagerID.Text = row.Cells["Manager_ID"].Value.ToString();
                textBoxFirstname.Text = row.Cells["First_Name"].Value.ToString();
                textBoxLastname.Text = row.Cells["Last_Name"].Value.ToString();
                textBoxPhnNo.Text = row.Cells["Phone_no"].Value.ToString();
                textBoxAddress.Text = row.Cells["Address"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
            }*/
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Admin_Home ah = new Admin_Home();
            ah.Show();
            this.Hide();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            string sql = "INSERT INTO ManagerRegistration(First_Name,Last_Name,Phone_no,Address,Email,Password,Confirm_Password) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = textBoxFirstname.Text;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = textBoxLastname.Text;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value =textBoxPhnNo.Text;
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = textBoxAddress.Text;
                cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = textBoxEmail.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar,50).Value = textBoxPassword.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = textBoxConfirmPassword.Text;
               




                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("added successfully!!!");


                con.Close();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            string sql = "UPDATE ManagerRegistration SET First_Name=@param1,Last_Name=@param2,Phone_no=@param3,Address=@param4,Email=@param5,Password=@param6,Confirm_Password=@param7 where Manager_ID=@param8";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = textBoxFirstname.Text;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = textBoxLastname.Text;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = textBoxPhnNo.Text;
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = textBoxAddress.Text;
                cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = textBoxEmail.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar).Value = textBoxPassword.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = textBoxConfirmPassword.Text;
                cmd.Parameters.Add("@param8", SqlDbType.Int).Value = int.Parse(textBoxManagerID.Text.Trim().ToString()); 






                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("updated successfully!!!");


                con.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstname.Text = textBoxLastname.Text = textBoxPhnNo.Text = textBoxAddress.Text = textBoxEmail.Text = textBoxPassword.Text = textBoxConfirmPassword.Text = null;
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            SqlCommand command = new SqlCommand("SELECT * FROM ManagerRegistration",con);
            con.Open();
            SqlDataReader DR = command.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;
            dataGridView1.DataSource = source;
            con.Close();
        }
    }
}
