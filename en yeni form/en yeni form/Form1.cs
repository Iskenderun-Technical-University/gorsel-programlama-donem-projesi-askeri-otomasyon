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
    public partial class Form1 : Form
    {
     
        static SqlConnection con;
       
        static SqlCommand cmd;
        public static string SqlCon = @"Data Source=OKAN\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

       
            
            
            Class1.GridFulle(dataGridView1, "select * from Vision");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
            //bu gördüğünüz kodçuk geçerli satırdaki değerleri sol taraftaki arça aktarır.
            label5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.PasswordChar = '*';


            //  dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;


            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[0].HeaderText = "SSFPid";
            dataGridView1.Columns[2].HeaderText = "Şifre(MD5)";
            dataGridView1.Columns[3].HeaderText = "Katılma Tarihi";
            dataGridView1.Columns[6].HeaderText = "Rütbe";

            /*
            dataGridView1.Columns[3].Width = 23223; 
            */

            /*  string[] satir = new string []
              {

              }
            */
            //whops olmamım





        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cleaner

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            label5.Text = " ";
            label6.Text = " ";





        }

        private void button2_Click(object sender, EventArgs e)
        {




            if (radioButton1.Checked == true)
            {
                yapici("Amiral",1);
                
            }
            else if (radioButton2.Checked == true)
            {
                yapici("Albay", 2);
            
            }
            else if (radioButton3.Checked == true)
            {
                yapici("Yarbay",3);
             
            }
            else if (radioButton4.Checked == true)
            {
                yapici("Teğmen",4);
           
            }
            else if (radioButton5.Checked == true)
            {
                yapici("Çavuş",5);
             
            }
            else
            {
                MessageBox.Show("En az bir personel seçilmeli");
            }

            //BUNU DİNAMİK BULMADIK O YÜZDEN DİNAMİĞİNİ YAZIYORUZ
            /*
            //ekleyici
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = ("insert into Kasa(Nick, Password, Date) values ('" + textBox1.Text + "','" + Form2.Md5sifreleyi(textBox2.Text) + "', '"+dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")+"')");
            cmd.ExecuteNonQuery();
            con.Close();

            //yeni eklediğimizin güncellenmesi

            Class1.GridFulle(dataGridView1, "select * from Kasa");

            */

            //BU DİNAMİK OLAN Ekleyici


        }

        public void yapici(string osmanimnereyegidersin,int eeeeee)
        {
            con = new SqlConnection(SqlCon);
            string sql = "insert into Vision (Nick, Password, Date, Rank, exp) values (@nick ,@pass ,@date ,@rank ,@rankacıkla)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nick", textBox2.Text);
            cmd.Parameters.AddWithValue("@pass", Form2.Md5sifreleyi(textBox3.Text));
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@rankacıkla", osmanimnereyegidersin);
            cmd.Parameters.AddWithValue("@rank", eeeeee);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();


            Class1.GridFulle(dataGridView1, "select * from Vision");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            

            //BU DİNAMİK OLAN Silici

            con = new SqlConnection(SqlCon);
            string sql = "delete from Vision where Nick=@nick and Password=@pass";//wheresiz bırakırsak tüm her şeyi siler
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nick", textBox2.Text);
            cmd.Parameters.AddWithValue("@pass", textBox3.Text);    //burda md5 istemiyoruz normal şifreyi istiyoruz çünkü kullanıcıc md5 i bilmiyor kendi şifresinni biliyor
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

            //yeni eklediğimizin güncellenmesi

            Class1.GridFulle(dataGridView1, "select * from Vision");

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

      



        public void dinamikguncelle()
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            con = new SqlConnection(SqlCon);
            string sql = "update Vision set Password='" + Form2.Md5sifreleyi(textBox3.Text) + "' where Nick=@nick ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nick", textBox2.Text);
            cmd.Parameters.AddWithValue("@pass", Form2.Md5sifreleyi(textBox3.Text));

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();



            Class1.GridFulle(dataGridView1, "select * from Vision");
        }
       
             public void dinamikguncelle2(int yuuy)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            con = new SqlConnection(SqlCon);
            string sqle = "update Vision set Rank = '" + yuuy + "' where Nick=@nick ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nick", textBox2.Text);
         

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqle;
            cmd.ExecuteNonQuery();
            con.Close();



        }


        public void dinamikguncelle3(string yuuyu)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            con = new SqlConnection(SqlCon);
            string sql = "update Vision set exp = '"+yuuyu+"' where Nick=@nick ";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@nick", textBox2.Text);


            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();



        }



        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        
            passchange dobermana = new passchange();
            dobermana.Show();

        }



     

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
     

           
        }

   
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            wellco atadam = new wellco();
            atadam.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
      


           

            if (radioButton1.Checked == true)
            {
               
                dinamikguncelle2(1);
                dinamikguncelle3("Amiral");
            }
            else if (radioButton2.Checked == true)
            {
               
                dinamikguncelle2(2);
                dinamikguncelle3("Albay");
            }
            else if (radioButton3.Checked == true)
            {
               
                dinamikguncelle2(3);
                dinamikguncelle3("Yarbay");

            }
            else if (radioButton4.Checked == true)
            {
              
                dinamikguncelle2(4);
                dinamikguncelle3("Teğmen");

            }
            else if (radioButton5.Checked == true)
            {
               
                dinamikguncelle2(5);
                dinamikguncelle3("Çavuş");
            }
            else
            {
                MessageBox.Show("En az bir personel seçilmeli");
            }


            Class1.GridFulle(dataGridView1, "select * from Vision");
        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
