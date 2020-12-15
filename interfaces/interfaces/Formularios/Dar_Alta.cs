using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using interfaces.Conexion;
using interfaces.Modelos;

namespace interfaces
{
    public partial class Dar_Alta : Form
    {
        ConexionBDcs conexionBDcs = new ConexionBDcs();
        public Dar_Alta()
        {
            InitializeComponent();
        }

      

        private void tb_Carpeta_TextChanged(object sender, EventArgs e)
        {
            //tb_Orden.Text = conexionBDcs.GetLastID();
        }

        private void btn_DarAlta_Click(object sender, EventArgs e)
        {
            if (dtp_Fecha.Text == " " || string.IsNullOrEmpty(tb_Contenido.Text)||string.IsNullOrEmpty(tb_Tema1.Text))
            {
                MessageBoxButtons botons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                string cuerpo = "Falta información de busqueda.";
                string cabecera = "Error en la busqueda";
                MessageBox.Show(cuerpo, cabecera, botons, icon);
            }
            else
            {
                if (string.IsNullOrEmpty(tb_Tema2.Text))
                {
                    tb_Tema2.Text = null;
                }
                if (string.IsNullOrEmpty(tb_Tema3.Text))
                {
                    tb_Tema3.Text = null;
                }
                Documento doc = new Documento(tb_Carpeta.Text,tb_Orden.Text,DateTime.Parse(dtp_Fecha.Text),tb_Contenido.Text,tb_Tema1.Text,tb_Tema2.Text,tb_Tema3.Text);
                conexionBDcs.AnadirDocumento(doc);
            }
        }

        private void tb_Tema1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Tema1.Text))
            {
                tb_Tema2.Enabled = true;
            }
            else
            {
                tb_Tema2.Enabled = false;
                tb_Tema2.Text = string.Empty;
            }
        }

        private void tb_Tema2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Tema2.Text))
            {
                tb_Tema3.Enabled = true;
            }
            else
            {
                tb_Tema3.Enabled = false;
                tb_Tema3.Text = string.Empty;
            }
        }

        private void dtp_Fecha_Leave(object sender, EventArgs e)
        {
            tb_Carpeta.Text = dtp_Fecha.Value.Year.ToString().Substring(2);
        }
    }
}
