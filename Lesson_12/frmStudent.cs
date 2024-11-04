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

namespace Lesson_12
{
    public partial class frmStudent : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\Windows Form_Lesson\Lesson_14\Lesson_12\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public frmStudent()
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
            if (txtFees.Text == "")
            {
                MessageBox.Show("Please Input Fees");
                return;
            }
            if (txtDOB.Text == "")
            {
                MessageBox.Show("Please Input Date of Birth");
                return;
            }
            if (txtisActive.Text == "")
            {
                MessageBox.Show("Please Input isActive");
                return;
            }
            if (txtDId.Text == "")
            {
                MessageBox.Show("Please Input Department Id");
                return;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Student(Name,Fees,DOB,isActive,DId) values(@X,@a,@b,@c,@d)", con);
            cmd.Parameters.AddWithValue("@x", txtName.Text);
            cmd.Parameters.AddWithValue("@a", txtFees.Text);
            cmd.Parameters.AddWithValue("@b", txtDOB.Text);
            cmd.Parameters.AddWithValue("@c", txtisActive.Text);
            cmd.Parameters.AddWithValue("@d", txtDId.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Insert SuccessFully");

        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please Input Id First !!!");
                return;
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE Id=@id", con);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtName.Text = dr.GetValue(1).ToString();
                txtFees.Text = dr.GetValue(2).ToString();
                txtDOB.Text = dr.GetValue(3).ToString();
                txtisActive.Text = dr.GetValue(4).ToString();
                txtDId.Text = dr.GetValue(5).ToString();
            }
            else
            {
                txtName.Text = "";
                MessageBox.Show("Data Not Found");


            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("if you wanna Updated,Serach first...");
                return;
            }

            SqlCommand cmd = new SqlCommand("update Student set Name=@a,Fees=@b,DOB=@c,isActive=@d,DId=@e where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@a", txtName.Text);
            cmd.Parameters.AddWithValue("@b", txtFees.Text);
            cmd.Parameters.AddWithValue("@c", txtDOB.Text);
            cmd.Parameters.AddWithValue("@d", txtisActive.Text);
            cmd.Parameters.AddWithValue("@e", txtDId.Text);

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

            SqlCommand cmd = new SqlCommand("delete Student  where Id=@id", con);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtId.Text = "";
            txtName.Text = "";
            txtFees.Text = "";
            txtDOB.Text = "";
            txtisActive.Text = "";
            txtDId.Text = "";
            MessageBox.Show("Data Delete Successfully");
        }
    }
}
