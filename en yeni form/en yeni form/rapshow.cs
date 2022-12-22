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
    public partial class rapshow : Form
    {



        static SqlConnection con;
        static SqlDataAdapter da;
        static DataSet ds;
        public static string SqlCon = @"Data Source=OKAN\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";


        public void RaporFill(string sql)
        {
            con = new SqlConnection(SqlCon);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds);
            CrystalReport41.SetDataSource(ds.Tables[1]);
            crystalReportViewer1.ReportSource = CrystalReport41;
            con.Close();

        
        }
        public rapshow()
        {
            InitializeComponent();
        }

        private void rapshow_Load(object sender, EventArgs e)
        {
            RaporFill("select * from Vision");
        }
    }
}
