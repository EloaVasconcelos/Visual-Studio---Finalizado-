using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoinicial
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcombustivel Combustível = new frmcombustivel();
            this.Hide();
            Combustível.Show();
        }

        private void exercícioLooping1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtabuada1 tabuada1 = new frmtabuada1();
            this.Hide();
            tabuada1.Show();

        }

        private void exercícioLoopingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtabuada2 tabuada2 = new frmtabuada2();
            this.Hide();
            tabuada2.Show();
        }

        private void exercícioLooping3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtabuada3 tabuada3 = new frmtabuada3();
            this.Hide();
            tabuada3.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
