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
    public partial class putin : Form
    {

        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;


        public static string SqlCon = @"Data Source=OKAN\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";
        public static string UserSession = "";
      //public static string RankSession = "";
        public putin()
        {
            InitializeComponent();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void putin_Load(object sender, EventArgs e)
        {

        }
        
        public void Login()   //dinamiik
        {

            //Form2.Md5sifreleyi(textBox1.Text);
            string sorgu = "select * from Vision where Nick=@user and Password=@pass";
            int aavv;

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", Form2.Md5sifreleyi(textBox2.Text));
         


            con.Open();
            dr = cmd.ExecuteReader();


         //   RankSession = Rank; 
             UserSession = textBox1.Text;
            if (dr.Read())
            {
                if (UserSession == "tesla")
                {
                      this.Hide();
                  
                    wellco a = new wellco();
                    a.Show();

                }
                else
                {
                    this.Hide();
                    welcoPersonel batman = new welcoPersonel();
                    batman.Show();
                }





                // MessageBox.Show("Giriş Yapıldı");  



            }
            else
            {
                MessageBox.Show("Giriş Denemesi Başarısız Oldu");
                textBox1.Focus();
            }
            con.Close();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
