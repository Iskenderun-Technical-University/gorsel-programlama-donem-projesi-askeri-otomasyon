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
using System.Security.Cryptography;
namespace en_yeni_form
{
    public partial class passpanel : Form
    {



        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static DataSet ds;
        static SqlDataReader dr;
        public static string SqlCon = @"Data Source=DESKTOP-P1MLTOO\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";
        public static string UserSession = "";

        public int sonuc = 0;
        public passpanel()
        {
            InitializeComponent();
        }

        private void passchange_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int ilk = r.Next(0, 31);
            int ikinci = r.Next(0, 99);
            sonuc = ilk + ikinci;
            Capctha.Text = ilk.ToString() + "+" + ikinci.ToString() + "=";



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool OldPassCtrl()
        {


            string sorgu = "select Password from Vision where Nick=@user and Password=@pass";

            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", putin.UserSession);   //mevcut kullanıcınını sadece kendi şifresi  değiştimesini sağlıyoruz
            cmd.Parameters.AddWithValue("@pass", Form2.Md5sifreleyi(eskipass.Text));

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {


                string sql = "update Vision set Password= '" + Form2.Md5sifreleyi(yenipass.Text) + "' ";
                Class1.SendCMD(sql);

                mesajreturn.Text = "İşlem Başarılı";
                eskipass.Clear();
                yenipass.Clear();
                yenipass2.Clear();
                guessWhat.Clear();

            }
            else
            {

                mesajreturn.Text = "Eski Şfrede Hatalı Girildi";


            }
            con.Close();



            return true;
        }

        private void eskipass_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttDegis_Click(object sender, EventArgs e)
        {
            if (guessWhat.Text == sonuc.ToString())//captcha dogru mu
            {
                if (yenipass.Text == yenipass2.Text)//yeni sifre doğru mu 
                {
                    OldPassCtrl();
                }
                else
                {
                    mesajreturn.Text = "Yeni Şifre Tekrarıya Eşleşmiyor";
                }
            }
            else
            {
                mesajreturn.Text = "Toplama İşlemi Yanlış Yaptınız";
            }
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Panel a = new Panel();
            a.ShowDialog();
        }

        private void passpanel_Load(object sender, EventArgs e)
        {

        }
    }
}
