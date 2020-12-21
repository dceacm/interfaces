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
            cbTema1.Checked = false;
            cbTema2.Checked = false;
            cbTema3.Checked = false;
            cbContenido.Checked = false;

            txtTema1.Enabled = false;
            txtTema2.Enabled = false;
            txtTema3.Enabled = false;
            txtContenido.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbTema1.Checked && txtTema1.Text=="")
            {
                MessageBox.Show("Debe introducir un parámetro de búsqueda en el cuadro del tema 1.", "Error en la introducción de datos.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (cbTema2.Checked && txtTema2.Text == "")
            {
                MessageBox.Show("Debe introducir un parámetro de búsqueda en el cuadro del tema 2.", "Error en la introducción de datos.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (cbTema3.Checked && txtTema3.Text == "")
            {
                MessageBox.Show("Debe introducir un parámetro de búsqueda en el cuadro del tema 3.", "Error en la introducción de datos.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (cbContenido.Checked && txtContenido.Text == "")
            {
                MessageBox.Show("Debe introducir un parámetro de búsqueda en el cuadro del contenido.", "Error en la introducción de datos.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                bool t1 = false;
                bool t2 = false;
                bool t3 = false;
                bool c = false;
                string tema1 = null;
                string tema2 = null;
                string tema3 = null;
                string contenido = null;

                if (cbTema1.Checked)
                {
                    t1 = true;
                    tema1 = txtTema1.Text;
                }
                if (cbTema2.Checked)
                {
                    t2 = true;
                    tema2 = txtTema2.Text;
                }
                if (cbTema3.Checked)
                {
                    t3 = true;
                    tema3 = txtTema3.Text;
                }
                if (cbContenido.Checked)
                {
                    c = true;
                    contenido = txtContenido.Text;
                }

                ListaDocumentos l = new ListaDocumentos(t1, t2, t3, c, tema1, tema2, tema3, contenido);
                this.Visible = false;
                l.ShowDialog();
                this.Visible = true;
            }            
        }       

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTema1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTema1.Checked)
            {
                txtTema1.Enabled = true;
            }
            else
            {
                txtTema1.Enabled = false;
            }
        }

        private void cbTema2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTema2.Checked)
            {
                txtTema2.Enabled = true;
            }
            else
            {
                txtTema2.Enabled = false;
            }
        }

        private void cbTema3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTema3.Checked)
            {
                txtTema3.Enabled = true;
            }
            else
            {
                txtTema3.Enabled = false;
            }
        }

        private void cbContenido_CheckedChanged(object sender, EventArgs e)
        {
            if (cbContenido.Checked)
            {
                txtContenido.Enabled = true;
                //btnVolver.Location = new Point(171, 316);
                //gb_Consulta.Size = new Size(477, 300);
                //this.Size = new Size(521, 414);
            }
            else
            {
                txtContenido.Enabled = false;
                //btnVolver.Location = new Point(171, 242);
                //gb_Consulta.Size = new Size(477, 226);
                //this.Size = new Size(521, 340);
            }
        }
    }
}
