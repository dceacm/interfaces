using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaces
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
            cbTema1.Checked = true;
            cbTema2.Checked = true;
            cbTema3.Checked = true;
            cbContenido.Checked = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {           
        }       

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTema1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTema1.Checked)
            {
                txtTema1.Visible = true;
            }
            else
            {
                txtTema1.Visible = false;
            }
        }

        private void cbTema2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTema2.Checked)
            {
                txtTema2.Visible = true;
            }
            else
            {
                txtTema2.Visible = false;
            }
        }

        private void cbTema3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTema3.Checked)
            {
                txtTema3.Visible = true;
            }
            else
            {
                txtTema3.Visible = false;
            }
        }

        private void cbContenido_CheckedChanged(object sender, EventArgs e)
        {
            if (cbContenido.Checked)
            {
                txtContenido.Visible = true;
                btnVolver.Location = new Point(171, 305);
                groupBox1.Size = new Size(477, 287);
                this.Size = new Size(521, 414);
            }
            else
            {
                txtContenido.Visible = false;
                btnVolver.Location = new Point(171, 242);
                groupBox1.Size = new Size(477, 226);
                this.Size = new Size(521, 340);
            }
        }
    }
}
