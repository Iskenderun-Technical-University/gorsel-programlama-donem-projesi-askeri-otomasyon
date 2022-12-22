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

namespace en_yeni_form
{
    public partial class Personel_Panel : Form
    {


        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static DataSet ds;
        static SqlDataReader dr;

        public static string SqlCon = @"Data Source=DESKTOP-P1MLTOO\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";

        void FulleGridi()
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter("selected * from mordor",con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "mordor");

            dataGridView1.DataSource = ds.Tables["mordor"];
        
            con.Close();
        }
        public Personel_Panel()
        {
            InitializeComponent();
        }

        private void Personel_Panel_Load(object sender, EventArgs e)
        {
            FulleGridi();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
