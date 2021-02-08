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
   
    public partial class View_Guest : Form

    {
        

        //string ConnectionString = "data source =DESKTOP-SPI0GI3;database =Hotel Management System;integrated security = True";
     
        

        public View_Guest()
        {

            InitializeComponent();
        }

        private void View_Guest_Load(object sender, EventArgs e)
        {
           // PopulateComboBox();

        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            Admin_Home ah = new Admin_Home();
            ah.Show();
            this.Hide();
        }
       /* void PopulateComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM GuestRegistration", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Room_Type.ValueMember = "Guest_ID";
                Room_Type.DisplayMember = "Room_Type";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "Select";
                dtbl.Rows.InsertAt(topItem, 0);
                Room_Type.DataSource = dtbl;
            }
        }*/
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonshow_Click(object sender, EventArgs e)
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
    }
}
