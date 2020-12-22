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
                MessageBox.Show("Debe introducir un parámetro de búsqueda en el cuadro del tema 1.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (cbTema2.Checked && txtTema2.Text == "")
            {
                MessageBox.Show("Debe introducir un parámetro de búsqueda en el cuadro del tema 2.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (cbTema3.Checked && txtTema3.Text == "")
            {
                MessageBox.Show("Debe introducir un parámetro de búsqueda en el cuadro del tema 3.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (cbContenido.Checked && txtContenido.Text == "")
            {
                MessageBox.Show("Debe introducir un parámetro de búsqueda en el cuadro del contenido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                bool C1 = false;
                bool C2 = false;
                bool C3 = false;
                bool cont = false;
                string clave1 = null;
                string clave2 = null;
                string clave3 = null;
                string contenido = null;

                if (cbTema1.Checked)
                {
                    C1 = true;
                    clave1 = txtTema1.Text;
                }
                if (cbTema2.Checked)
                {
                    C2 = true;
                    clave2 = txtTema2.Text;
                }
                if (cbTema3.Checked)
                {
                    C3 = true;
                    clave3 = txtTema3.Text;
                }
                if (cbContenido.Checked)
                {
                    cont = true;
                    contenido = txtContenido.Text;
                }

                ListaDocumentos listaDocumentos = new ListaDocumentos(C1, C2, C3, cont, clave1, clave2, clave3, contenido);
                this.Visible = false;
                listaDocumentos.ShowDialog();
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
            }
            else
            {
                txtContenido.Enabled = false;
            }
        }
    }
}
