using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace en_yeni_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  

            //MD5 İÇİN
            if (textBox1.Text != "")//girdi yoksa çevirmeyle uğraşmasın diye.Sorun çıkıyormuş
            {                        //denedim boşken d40 lı bir şey verdi
                richTextBox1.Text = Md5sifreleyi(textBox1.Text);
                label4.Text = richTextBox1.Text.Length.ToString();

            }
            else 
                
               richTextBox1.Clear();
            //SHA256 İÇİN
            if (textBox1.Text != "")//girdi yoksa çevirmeyle uğraşmasın diye.Sorun çıkıyormuş
            {                        //denedim boşken d40 lı bir şey verdi
                richTextBox2.Text = SHA256sifreleme(textBox1.Text);
                label5.Text = richTextBox2.Text.Length.ToString();

            }
            else 
                
                richTextBox2.Clear();

        }

        public static string Md5sifreleyi(string sifrelenecekmetin) {
            
            
         MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

         byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekmetin);

         dizi = md5.ComputeHash(dizi);

         StringBuilder sb = new StringBuilder();
         foreach(byte item in dizi)
         sb.Append(item.ToString("x2").ToLower());

            return sb.ToString();
        }
    
    


      public static string SHA256sifreleme(string sifrelenecekmetin)
        {
            SHA256 sha256Hash = SHA256.Create();
            //byte dizi = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifrelenecekmetin));
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekmetin);

            dizi = sha256Hash.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in dizi)
                sb.Append(item.ToString("x2").ToLower());

            return sb.ToString();

          
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
