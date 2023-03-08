using System.Data.SqlClient;
using System.Data;
namespace EmloyeeLogin
{
    public partial class Frmlogin : Form
    {
        SqlConnection conn = new SqlConnection("server=(local); database=employee; integrated security=true");




        public Frmlogin()
        {
            InitializeComponent();

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblwelcom_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {


            SqlCommand cmd = new SqlCommand("select id from Emp_info where name=@name and password=@password", conn);
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            conn.Open();
            object ob = cmd.ExecuteScalar();
            if (ob != null)
            {
                Frmalter frmalter = new Frmalter();
                frmalter.Show();
                this.Dispose(false);

            }
            else
            {
                MessageBox.Show("incorrect");
            }
            conn.Close();


        }
    }
}