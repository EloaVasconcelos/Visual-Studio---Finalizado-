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
    public partial class frmtabuada1 : Form
    {
        public frmtabuada1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num, result;
            int i;

            num = Convert.ToDouble(txtnum.Text);

            i = 0;
            while(i<=10)
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;
            }
        }

        private void txtlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();

            txtnum.Focus();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu Menu = new frmmenu();
            Menu.Show();
        }
    }
}
