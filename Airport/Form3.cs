using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
     
        }

        private void ShowStaff_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'egypt_AirDataSet.PLANE' table. You can move, or remove it, as needed.
            this.pLANETableAdapter.Fill(this.egypt_AirDataSet.PLANE);
        }

        private void InsertPlane_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO PLANE VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Insertion a Plane is Successfully Completed !");
        }

        private void UpdatePlane_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "Update PLANE SET MODEL_NO = '" + textBox1.Text + "' , ADDRESS = '" + textBox2.Text + "' , AVAILABLE_SEATS = '" + textBox3.Text + "' ,COMPANY = '" + textBox4.Text + "' , TYPE_NAME = '" + textBox5.Text + "' , SPEED = '" + textBox6.Text + "' WHERE MODEL_NO = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Updating a Plane is Successfully Completed !");
        }

        private void DeletePlane_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ONEM8CH;Initial Catalog=Egypt_Air;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM PLANE WHERE MODEL_NO = '" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Deletion a Plane is Successfully Completed !");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }
    }
}
