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

namespace interfaces
{
    public partial class ListaDocumentos : Form
    {
        private int aux;
        private string query = "SELECT * FROM Documento ";

        bool t1;
        bool t2;
        bool t3;
        bool c;
        string tema1;
        string tema2;
        string tema3;
        string contenido;

        private Conexion.ConexionBDcs con = new Conexion.ConexionBDcs();
        private BindingSource bd;
        
        public ListaDocumentos(bool t1, bool t2, bool t3, bool c, string tema1, string tema2, string tema3, string contenido)
        {
            InitializeComponent();

            bd = new BindingSource();
            bd.DataSource = typeof(Documento);
            dataGridView1.DataSource = bd;
            dataGridView1.AutoGenerateColumns = true;

            this.t1 = t1;
            this.t2 = t2;
            this.t3 = t3;
            this.c = c;

            this.tema1 = tema1;
            this.tema2 = tema2;
            this.tema3 = tema3;
            this.contenido = contenido;

            Documentos();
        }

        private void Documentos()
        {
            if (!t1 && !t2 && !t3 && !c)
            {
                List<Documento> l = con.GetDocumentos(query);
                foreach (Documento per in l)
                {
                    bd.Add(per);
                }
            }
            else
            {
                query += "WHERE ";
                bool first = true;

                if (t1)
                {
                    query += "Clave1 = '" + tema1 + "'";
                    first = false;
                }

                if (t2)
                {
                    if (!first)
                    {
                        query += " AND ";
                    }
                    else
                    {
                        first = false;
                    }
                    query += "Clave2 = '" + tema2 + "'";
                }

                if (t3)
                {
                    if (!first)
                    {
                        query += " AND ";
                    }
                    else
                    {
                        first = false;
                    }
                    query += "Clave3 = '" + tema3 + "'";
                }

                if (c)
                {
                    if (!first)
                    {
                        query += " AND ";
                    }
                    else
                    {
                        first = false;
                    }
                    query += "Contenido = '" + contenido + "'";
                }

                List<Documento> l = con.GetDocumentos(query);
                foreach (Documento per in l)
                {
                    bd.Add(per);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Documento doc;
            doc = (Documento)dataGridView1.CurrentRow.DataBoundItem;

            if (con.EliminarDocumento(doc)) {
                MessageBoxButtons botons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                string cuerpo = "Se ha eliminado el documento correctamente.";
                string cabecera = "ERROR";
                MessageBox.Show(cuerpo, cabecera, botons, icon);
            }
            else
            {
                MessageBoxButtons botons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Exclamation;
                string cuerpo = "No se ha eliminado correctamente.";
                string cabecera = "ERROR";
                MessageBox.Show(cuerpo, cabecera, botons, icon);
            }

            con.EliminarDocumento(doc);
            bd.Clear();
            Documentos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Documento doc;
            doc = (Documento)dataGridView1.CurrentRow.DataBoundItem;
            Console.WriteLine(doc.Carpeta);
            new Dar_Alta(doc).Show();
            bd.Clear();
            Documentos();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            aux = e.RowIndex;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aux = e.RowIndex;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lista_Usuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
