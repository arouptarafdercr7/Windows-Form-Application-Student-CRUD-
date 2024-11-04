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
    public partial class Form3 : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\Windows Form_Lesson\Lesson_14\Lesson_12\Database1.mdf;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from student", con);
            SqlDataAdapter dadpt = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dadpt.Fill(dt);

            dataGridView1.DataSource = dt;
           
        }
    }
}
