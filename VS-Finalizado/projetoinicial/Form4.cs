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
    public partial class frmtabuada2 : Form
    {
        public frmtabuada2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntcalcular_Click(object sender, EventArgs e)
        {

               double   num, result;
                int      i;

            num = Convert.ToDouble(txtnum.Text);


            i = 0;
            do
            {
                result = num * i;
                txtresult.Text = String.Concat(txtresult.Text, "\r\n", result.ToString());
                i++;



            } while(i <= 10);
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
