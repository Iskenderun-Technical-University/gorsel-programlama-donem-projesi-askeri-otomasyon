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
    public partial class AdminGörevPaneli : Form
    {


        static SqlConnection con;
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static DataSet ds;
        static SqlDataReader dr;

        public static string SqlCon = @"Data Source=OKAN\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";


        public AdminGörevPaneli()
        {
            InitializeComponent();
            GridFulle22(dataGridView1, "select * from guppy12");
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

        public void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                yapici(1,"Amiral");
            }
            else if (radioButton2.Checked == true)
            {
                yapici(2,"Albay");
            }
            else if (radioButton3.Checked == true)
            {
                yapici(3,"Yarbay");
            }
            else if (radioButton4.Checked == true)
            {
                yapici(4,"Teğmen");
            }
            else if (radioButton5.Checked == true)
            {
                yapici(5,"Çavuş");
            }
            else
            {
                MessageBox.Show("En az bir personel seçilmeli");
            }

        }




        public void yapici(int aaa,string bb)
        {

            con = new SqlConnection(SqlCon);
            string sql = "insert into guppy12(Mission, mDAte, job, rank, rankyazi, jobexp) values (@misyon ,@date ,@job ,@rank ,@rankyazi ,@jobdurumu)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@misyon", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@job", 1);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@rankyazi", bb);
            cmd.Parameters.AddWithValue("@rank", aaa);
            //cmd.Parameters.AddWithValue("@mid", textBox1.Text);
            label2.Text = "Görev Alınabilir";
            cmd.Parameters.AddWithValue("@jobdurumu", label2.Text);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            GridFulle22(dataGridView1, "select * from guppy12");
            con.Close();
        }


        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            wellco doberman = new wellco();
            doberman.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          var  resyul = MessageBox.Show("Görev Silinecek?", "    Are You Sure ", MessageBoxButtons.OKCancel);
            if (resyul == DialogResult.OK)
            {
  con = new SqlConnection(SqlCon);
            string sql = "delete from guppy12 where Mid=@mid";//wheresiz bırakırsak tüm her şeyi siler
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@mid", textBox1.Text);

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

            //yeni eklediğimizin güncellenmesi

            Class1.GridFulle(dataGridView1, "select * from guppy12");
            }
            
          
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Görev Id";
            dataGridView1.Columns[1].HeaderText = "Görev";
            dataGridView1.Columns[2].HeaderText = "Verilme Tarihi";
            dataGridView1.Columns[5].HeaderText = "Görevli Rütbesi";
            dataGridView1.Columns[6].HeaderText = "Görev Durumu";
            dataGridView1.Columns[7].HeaderText = "Sorumlu";



        }

        private void AdminGörevPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
