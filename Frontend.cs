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
    public partial class Frontend : Form
    {
        //int Guest_ID;
        //int floor;
        //int roomNo;

        //string ConnectionString = "data source = DESKTOP-SPI0GI3;database =Hotel Management System;integrated security =True";
        public Frontend()
        {
            InitializeComponent();
            CenterToScreen();

            string[] roomtypes = new string[4];
            roomtypes[0] = "Select Here";
            roomtypes[1] = "Single";
            roomtypes[2] = "Double";
            roomtypes[3] = "Suite";




            roomTypecomboBox.DataSource = roomtypes;



        }

        ///*  internal object GetAll()
        //  {
        //      throw new NotImplementedException();
        //  }*/

        //  void UpdateGridView()
        //  {
        //      Frontend fr = new Frontend();
        //      //dataGridView3.DataSource = fr.GetFrontend();
        //  }

        //  private object GetFrontend()
        //  {
        //      throw new NotImplementedException();
        //  }
        void PopulateComboBox()
        {
          /*  using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM AvailableRoom", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Room_Type.ValueMember = "Room_No";
                Room_Type.DisplayMember = "Room_Type";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "Select";
                dtbl.Rows.InsertAt(topItem, 0);
                Room_Type.DataSource = dtbl;
            }*/
        }

            private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frontend_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void buttonFoodMenu_Click(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            fm.Show();
            this.Hide();
        }

        private void roomTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomOccupiedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomReservedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculateBill_Click(object sender, EventArgs e)
        {
            FinalizePayment fp = new FinalizePayment();
            fp.Show();
            this.Hide();
        }

        private void buttonNewReservation_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            string sql = "INSERT INTO GuestRegistration(First_Name,Last_Name,Gender,Phone_no,Email,Address,Room_Type,Floor,Room_No,Entry_Date,Departure_Date) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = firstNametextBox.Text;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = lastNametextBox.Text;
                cmd.Parameters.Add("@param3", SqlDbType.Int).Value = femaleradioButton.Checked ? 1 : 0;
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = phnNotextBox.Text;
                cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = emailtextBox.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = addresstextBox.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar).Value = roomTypecomboBox.Text;
                cmd.Parameters.Add("@param8", SqlDbType.Int).Value = int.Parse(floortextBox.Text);
                cmd.Parameters.Add("@param9", SqlDbType.Int).Value = int.Parse(roomNotextBox.Text);
                cmd.Parameters.Add("@param10", SqlDbType.Date).Value = entryDatePicker.MinDate;
                cmd.Parameters.Add("@param11", SqlDbType.Date).Value = depDatePicker.MinDate;





                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("added successfully!!!");


                con.Close();
            }

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            buttonSubmit.Visible = false;
            buttonUpdateDetails.Visible = false;
            buttonDelete.Visible = false;

            //reset_frontend();
        }
        public void ClearAllTextBoxes(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control.HasChildren)
                {
                    ClearAllTextBoxes(control);
                }
            }
        }
        public void ClearAllComboBox(Control controls)
        {
            foreach (Control control in controls.Controls)
            {
                if (control == roomTypecomboBox)
                {
                    continue;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                if (control.HasChildren)
                {
                    ClearAllComboBox(control);
                }
            }
        }
        private void reset_frontend()
        {
            try
            {

                /* resEditButton.Items.Clear();
                 checkinCheckBox.Checked = false;
                 foodSupplyCheckBox.Checked = false;*/

                ClearAllComboBox(this);
                ClearAllTextBoxes(this);


                //ComboBoxItemsFromDataBase();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frontend_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdateDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            string sql = "UPDATE GuestRegistration SET First_Name=@param1,Last_Name=@param2,Gender=@param3,Phone_no=@param4,Email=@param5,Address=@param6,Room_Type=@param7,Floor=@param8,Room_No=@param9,Entry_Date=@param10,Departure_Date=@param11 where Guest_ID=@param12";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {

               // MessageBox.Show(gstIDtextBox.Text);
                con.Open();
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = firstNametextBox.Text;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = lastNametextBox.Text;
                cmd.Parameters.Add("@param3", SqlDbType.Int).Value = femaleradioButton.Checked ? 1 : 0;
                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = phnNotextBox.Text;
                cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = emailtextBox.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = addresstextBox.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar).Value = roomTypecomboBox.Text;
                cmd.Parameters.Add("@param8", SqlDbType.Int).Value = int.Parse(floortextBox.Text);
                cmd.Parameters.Add("@param9", SqlDbType.Int).Value = int.Parse(roomNotextBox.Text);
                cmd.Parameters.Add("@param10", SqlDbType.Date).Value = entryDatePicker.MinDate;
                cmd.Parameters.Add("@param11", SqlDbType.Date).Value = depDatePicker.MinDate;
                cmd.Parameters.Add("@param12", SqlDbType.Int).Value = int.Parse(gstIDtextBox.Text.Trim().ToString());


                



                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!!!");


                con.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";


            string sql = "delete from GuestRegistration where Guest_Id=@param1";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {

                con.Open();


                cmd.Parameters.Add("@param1", SqlDbType.Int).Value = int.Parse(gstIDtextBox.Text);



                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("delete successfully!!!");


                con.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            SqlCommand command = new SqlCommand("SELECT * FROM GuestRegistration", con);
            con.Open();
            SqlDataReader DR = command.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;
            dataGridView1.DataSource = source;
            con.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = SSPI";
            SqlCommand command = new SqlCommand("SELECT * FROM AvailableRoom", con);
            con.Open();
            SqlDataReader DR = command.ExecuteReader();
            BindingSource source = new BindingSource();
            source.DataSource = DR;
            dataGridView3.DataSource = source;
            con.Close();
        }
    }
}
