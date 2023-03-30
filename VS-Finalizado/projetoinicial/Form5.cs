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
    public partial class frmtabuada3 : Form
    {
        public frmtabuada3()
        {
            InitializeComponent();
        }

        private void frmtabuada3_Load(object sender, EventArgs e)
        {

        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num, result;
            int i;

            num = Convert.ToDouble(txtnum.Text);

            i = 0;
            for(i=0; i <= 10; i++)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu Menu = new frmmenu();
            Menu.Show();
        }
    }
}
