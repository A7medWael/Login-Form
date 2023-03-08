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
namespace EmloyeeLogin
{
    public partial class Frmalter : Form
    {
        SqlConnection cnn = new SqlConnection("server=(local); database=employee; integrated security=true");
        SqlCommand cm = new SqlCommand();
        SqlDataAdapter sd = new SqlDataAdapter();


        public Frmalter()
        {
            InitializeComponent();


        }

        private void dgv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frmalter_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {

            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select id, name ,address ,phone from Emp_info";
            cm.CommandType = CommandType.Text;
            cm.Connection = cnn;
            cnn.Open();
            SqlDataReader rdr = cm.ExecuteReader();
            List<ClsDisp> list = new List<ClsDisp>();
            while (rdr.Read())
            {
                ClsDisp cd = new ClsDisp();
                cd.id = (int)rdr["id"];
                cd.name = (string)rdr["name"];
                cd.address = (string)rdr["address"];
                cd.phone = (string)rdr["phone"];
                list.Add(cd);
            }
            dgv_employee.DataSource = list;
            cnn.Close();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {

        }
    }
}
