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
    public partial class repooooo : Form
    {

        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static DataSet ds;
        static SqlDataReader dr;
        //   public static string RankSession = "";



        public static string SqlCon = @"Data Source=OKAN\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";


        public repooooo()
        {
            InitializeComponent();
        }
        public static DataGridView GridFulle22(DataGridView Grille, string sqlSelecti)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sqlSelecti, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, sqlSelecti);

            Grille.DataSource = ds.Tables[sqlSelecti];
            con.Close();
            return Grille;
        }
        private void repooooo_Load(object sender, EventArgs e)
        {

            GridFulle22(dataGridView1, "select * from Vision");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;


            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[0].HeaderText = "SSFPid";
            dataGridView1.Columns[2].HeaderText = "Şifre(MD5)";
            dataGridView1.Columns[3].HeaderText = "Katılma Tarihi";
            dataGridView1.Columns[6].HeaderText = "Rütbe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            /*     
            repor agugu = new repor();
            agugu.Show();if (con.State!=ConnectionState.Open)
              {
              con.Open();
              }
              SqlCommand cmd = new SqlCommand("select * from Vision",con);
              SqlDataAdapter da= new SqlDataAdapter(cmd);
              DataSet ds = new DataSet();
  CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(ds);

            agugu.crystalReportViewer1.ReportSource = cr1;
            agugu.crystalReportViewer1.Refresh();
            con.Close();
              da.Fill(ds.Tables[0]);*/


            GridFulle22(dataGridView1, "select * from Vision");

          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
