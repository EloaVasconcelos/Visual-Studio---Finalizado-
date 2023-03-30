using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoinicial
{
    public partial class frmcombustivel : Form
    {
        public frmcombustivel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double v1, ql;
            Char cod;
            ql = Convert.ToDouble(txtql.Text);
            cod = Convert.ToChar(txtcom.Text);


            if (cod.Equals('A'))
            {
                if (ql < 20)
                {
                    v1 = ql * (4.30 - (4.30 * 3 / 100));
                    txtv.Text = (v1.ToString());
                }
                else
                {
                    v1 = ql * (4.30 - (4.30 * 5 / 100));
                    txtv.Text = (v1.ToString());
                }
            }
            else if (cod.Equals('G'))
            {
                if (ql < 20)
                {
                    v1 = ql * (5.50 - (5.50 * 4 / 100));
                    txtv.Text = (v1.ToString());
                }
                else
                {
                    v1 = ql * (5.50 - (5.50 * 6 / 100));
                    txtv.Text = (v1.ToString());

                }

            }
        }



        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu Menu = new frmmenu();
            Menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcom.Clear();
            txtql.Clear();
            txtv.Clear();

            txtcom.Focus();
        }
    }
}

