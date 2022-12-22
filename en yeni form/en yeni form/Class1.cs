using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace en_yeni_form
{
    class Class1
    { 
        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static DataSet ds;
        static SqlDataReader dr;
        //DEVAM ET
        public static string SqlCon = @"Data Source=OKAN\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";

        public static bool BaglantıDrumu()
        {
            using (con = new SqlConnection(SqlCon))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException exp)
                {
                   MessageBox.Show(exp.Message);
                    return false;

                }


            }

            return true;
        }

       public  static  DataGridView GridFulle(DataGridView Grille, string sqlSelecti)
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

        public static void SendCMD(string sql)
        {
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }



        public static bool LoginCtrl(string Nick,string Password)   //dinamiik ;|
        {

            //Form2.Md5sifreleyi(textBox1.Text);
            string sorgu = "select * from Terra where Nick=@user and Password=@pass";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", Nick);
            cmd.Parameters.AddWithValue("@pass", Form2.Md5sifreleyi(Password));

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
           
        }
    } 
}
