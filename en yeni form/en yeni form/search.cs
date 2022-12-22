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
    public partial class search : Form
    {

        static SqlConnection con;

        static SqlCommand cmd;
        public static string SqlCon = @"Data Source=OKAN\SQLEXPRESS;Initial Catalog=SSForce;Integrated Security=True";
        public search()
        {
            InitializeComponent();
        }


        public void ADAMproces()
        {
            if (radioButton1.Checked)
            {
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand();
                string sqlsearcher = "select * from Vision where Nick like '%" + textBox1.Text + "%'";
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sqlsearcher;
                cmd.ExecuteNonQuery();
                con.Close();
                Class1.GridFulle(dataGridView1, sqlsearcher);

            }
            else if (radioButton2.Checked)
            {
                con = new SqlConnection(SqlCon);
                cmd = new SqlCommand();
                string sqlsearche = "select * from Vision where SSFPid like '%" + textBox1.Text + "%'";
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sqlsearche;
                cmd.ExecuteNonQuery();
                con.Close();
                Class1.GridFulle(dataGridView1, sqlsearche);

            }
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {

            ADAMproces();

        }

        private void search_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            Class1.GridFulle(dataGridView1, "select * from Vision");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[0].HeaderText = "SSFPid";
            dataGridView1.Columns[2].HeaderText = "Şifre(MD5)";
            dataGridView1.Columns[3].HeaderText = "Katılma Tarihi";
            dataGridView1.Columns[6].HeaderText = "Rütbe";
            dataGridView1.Columns[8].Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void la_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ADAMproces();
        }

        private void anasayfayaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            wellco doberman = new wellco();
            doberman.Show();
        }
    }
    }

