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
    public partial class Lista_Usuarios : Form
    {
        private int aux;
        private string query = "SELECT * FROM Documento ";
        private string conexion;

        private Conexion.ConexionBDcs con = new Conexion.ConexionBDcs();
        private BindingSource bd;
        


        public Lista_Usuarios(bool t1, bool t2, bool t3, bool c, string tema1, string tema2, string tema3, string contenido)
        {
            InitializeComponent();
            bd = new BindingSource();
            bd.DataSource = typeof(Documento);
            dataGridView1.DataSource = bd;
            dataGridView1.AutoGenerateColumns = true;

            if(!t1 && !t2 && !t3 && !c)
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
            con.EliminarDocumento(doc);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Documento doc;
            doc = (Documento)dataGridView1.CurrentRow.DataBoundItem;
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

        
    }
}
