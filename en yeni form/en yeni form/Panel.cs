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


    public partial class Panel : Form
    {

        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static DataSet ds;
        static SqlDataReader dr;
        //   public static string RankSession = "";
      


        public static string SqlCon = @"Data Source=OKAN\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";
      
        
        
        //BURASI RANK A GÖRE PANEL 
        
        public void odin()
        {
            string sorgu1 = "select * from Vision where Rank=@rank and Nick=@Nick";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu1, con);
            cmd.Parameters.AddWithValue("@rank", 1);
            cmd.Parameters.AddWithValue("@nick", putin.UserSession);
            con.Open();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                GridFulle22(dataGridView1, "select * from guppy12 where rank=1");
            }
            con.Close();


            string sorgu2 = "select * from Vision where Rank=@rank and Nick=@Nick";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu2, con);
            cmd.Parameters.AddWithValue("@rank", 2);
            cmd.Parameters.AddWithValue("@nick", putin.UserSession);
            con.Open();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                GridFulle22(dataGridView1, "select * from guppy12 where rank=2");
            }
            con.Close();

            string sorgu3 = "select * from Vision where Rank=@rank and Nick=@Nick";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu3, con);
            cmd.Parameters.AddWithValue("@rank", 3);
            cmd.Parameters.AddWithValue("@nick", putin.UserSession);
            con.Open();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                GridFulle22(dataGridView1, "select * from guppy12 where rank=3");
            }
            con.Close();
            ////////////////////////////////////77777777777777

            string sorgu4 = "select * from Vision where Rank=@rank and Nick=@Nick";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu4, con);
            cmd.Parameters.AddWithValue("@rank", 4);
            cmd.Parameters.AddWithValue("@nick", putin.UserSession);
            con.Open();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                GridFulle22(dataGridView1, "select * from guppy12 where rank=4");
            }
            con.Close();




            string sorgu5 = "select * from Vision where Rank=@rank and Nick=@Nick";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand(sorgu5, con);
            cmd.Parameters.AddWithValue("@rank", 5);
            cmd.Parameters.AddWithValue("@nick", putin.UserSession);
            con.Open();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                GridFulle22(dataGridView1, "select * from guppy12 where rank=5");
            }
            con.Close();

        }



      
        public Panel()
        {
            InitializeComponent();


            odin();
           
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
   
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


            dataGridView1.Columns[3].Visible = false;
       


            dataGridView1.Columns[0].HeaderText = "Kod";
            dataGridView1.Columns[1].HeaderText = "                Görev                  ";
            dataGridView1.Columns[2].HeaderText = "Görev Tarihi";

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Görev Durumu";

            label2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString().Trim();

       

         




            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (textBox1.Text == "2")
            {
                label1.Text = "Görev Alınmış";
            }
            else if (textBox1.Text == "3")
            {
                label1.Text = "Bu Görev Tamamlanmış";
            }
            else if (textBox1.Text == "1")
            {
                label1.Text = "Görev Alınabilir";

            }
        }

        private void Panel_Load(object sender, EventArgs e)
        {


            textBox2.Text = putin.UserSession.TrimEnd();

        
           
            
            
   ///  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {

                if (textBox3.Text == "")
                {

                adam(2,"Görev Alınmış", textBox2.Text);
                MessageBox.Show("Görev Alınıdı");
                }
               
            }
            else if(textBox1.Text == "2")
            { 
                MessageBox.Show("Görev Alınmış");

            }
            else if (textBox1.Text == "3")
            {
                MessageBox.Show("Görev Zaten Tamamlanmış");

            }

        }

    
        public void adam(int aaa,string bbb,string ccc)
        {
            
            
        
        string sqlaer = "update guppy12 set job='" + aaa + "'  , jobexp='" + bbb + "' , whodid='" + ccc + "'where Mission=@midd";
            con = new SqlConnection(SqlCon);
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@midd", richTextBox1.Text);
      //      cmd.Parameters.AddWithValue("@whodid", putin.UserSession);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqlaer;
            cmd.ExecuteNonQuery();
           
            con.Close();
            odin();    

        
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                MessageBox.Show("Görev Alınmadan Tamamlanamaz");
               
            }
            else if (textBox1.Text == "2")
            {


                textBox2.Text.Replace(" ", "");
                textBox3.Text.Replace(" ","");
                if (textBox3.Text == textBox2.Text)
                {
                   MessageBox.Show("Bravo,Görev Tamamladınız");
                   adam(3,"Görev Tamamlanmış","tamamlayan " +putin.UserSession);
                }
                else
                {
                    MessageBox.Show("Bu Görev Başkası Tarafından Yapılıyor");

                }

            }
            else
            {
                MessageBox.Show("Görev Zaten Tamamlanmış");

            }
        }


        
        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "1")
            {
                MessageBox.Show("Görev Alınmamış");

            }
            else if (textBox1.Text == "2")
            {
                
         //      textBox2.Text.Replace(" ", "");
           //     textBox3.Text.Replace(" ", "");
      

    
                if (textBox3.Text == textBox2.Text) {
                MessageBox.Show("Görev İade Edildi");
                adam(1,"Görev Açıkta","");
                }
                else
                {
                    MessageBox.Show("Bu Görev Başkası Tarafından Yapılıyor");

                }

            }
            else
            {
                MessageBox.Show("Görev Zaten Tamamlanmış");

            }


        }

      

        private void güvenlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcoPersonel pekine = new welcoPersonel();
            pekine.Show();
        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
