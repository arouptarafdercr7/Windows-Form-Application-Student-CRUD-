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

namespace Lesson_12
{
    public partial class Form1 : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\Windows Form_Lesson\Lesson_14\Lesson_12\Database1.mdf;Integrated Security=True");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            //Validation

            if (txtName.Text == "")
            {
                MessageBox.Show("Please Input Name");
                return;
            }

            if (isNameExist(txtName.Text))
            {
                MessageBox.Show("Already Exist");
                return;

                //return means er pore r kono kaj korbe na
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO department values(@x)",con);
            cmd.Parameters.AddWithValue("@x",txtName.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Insert SuccessFully");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please Input Id First !!!");
                return;
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM DEPARTMENT WHERE Id=@i",con);
            cmd.Parameters.AddWithValue("@i",txtId.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                txtName.Text = dr.GetValue(1).ToString();
                MessageBox.Show("Data Found Successfully");

            }
            else
            {
                txtName.Text = "";
                MessageBox.Show("Data Not Found");
                

            }
            con.Close();
        }

        //Create isNameExist Method for Duplicate
        public bool isNameExist(string dn)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DEPARTMENT WHERE Name=@x",con);
            cmd.Parameters.AddWithValue("@x",dn);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("if you wanna Updated,Serach first...");
                return;
            }

            SqlCommand cmd = new SqlCommand("update department set name=@d where id=@i",con);
            cmd.Parameters.AddWithValue("@d",txtName.Text);
            cmd.Parameters.AddWithValue("@i", txtId.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Update Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("if you wanna deleted,Serach first...");
                return;
            }

            SqlCommand cmd = new SqlCommand("delete department where id=@i", con);
            cmd.Parameters.AddWithValue("@i", txtId.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtId.Text = "";
            txtName.Text = "";
            MessageBox.Show("Data Delete Successfully");
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            frmStudent frm = new frmStudent();
            frm.ShowDialog();
        }
    }
}
