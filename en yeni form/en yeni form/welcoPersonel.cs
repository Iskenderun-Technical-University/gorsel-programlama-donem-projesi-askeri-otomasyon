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
    public partial class welcoPersonel : Form
    {
        public welcoPersonel()
        {
            InitializeComponent();
        }

        private void welcoPersonel_Load(object sender, EventArgs e)
        {
            label3.Text = putin.UserSession;

        }

        private void güvenlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passchange doberman = new passchange();
            doberman.Show();
        }

        private void görevİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel rott = new Panel();
            rott.Show();
        }

        private void şifreDeğiştirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
