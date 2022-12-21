using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace en_yeni_form
{
    public partial class wellco : Form
    {
        public wellco()
        {
            InitializeComponent();
        }

        private void wellco_Load(object sender, EventArgs e)
        {
         label3.Text =  putin.UserSession;
        }

        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            passchange doberman = new passchange();
            doberman.Show();
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 golden = new Form1();
            golden.Show();
        }

        private void personelAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            search melinoa = new search();
            melinoa.Show();
        }

        private void görevİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGörevPaneli strair = new AdminGörevPaneli();
            strair.Show();
        }
    }
}
