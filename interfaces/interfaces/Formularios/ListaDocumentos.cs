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

        bool c1;
        bool c2;
        bool c3;
        bool cont;
        string clave1;
        string clave2;
        string clave3;
        string contenido;

        private Conexion.ConexionBDcs con = new Conexion.ConexionBDcs();
        private BindingSource bd;
        
        public ListaDocumentos(bool c1, bool c2, bool c3, bool cont, string clave1, string clave2, string clave3, string contenido)
        {
            InitializeComponent();

            bd = new BindingSource();
            bd.DataSource = typeof(Documento);
            dataGridView1.DataSource = bd;
            dataGridView1.AutoGenerateColumns = true;

            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
            this.cont = cont;

            this.clave1 = clave1;
            this.clave2 = clave2;
            this.clave3 = clave3;
            this.contenido = contenido;

            Documentos();
        }

        private void Documentos()
        {
            if (!c1 && !c2 && !c3 && !cont)
            {
                List<Documento> listaDocumentos = con.GetDocumentos(query);

                foreach (Documento documento in listaDocumentos)
                {
                    bd.Add(documento);
                }
            }
            else
            {
                query += "WHERE ";
                bool first = true;

                if (c1)
                {
                    query += "Clave1 = '" + clave1 + "'";
                    first = false;
                }

                if (c2)
                {
                    if (!first)
                    {
                        query += " AND ";
                    }
                    else
                    {
                        first = false;
                    }
                    query += "Clave2 = '" + clave2 + "'";
                }

                if (c3)
                {
                    if (!first)
                    {
                        query += " AND ";
                    }
                    else
                    {
                        first = false;
                    }
                    query += "Clave3 = '" + clave3 + "'";
                }

                if (cont)
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

                List<Documento> listaDocumentos = con.GetDocumentos(query);

                foreach (Documento per in listaDocumentos)
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

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int currentpage = 0;
            int pagesleft = 0;
            int rec = 0;
            int width = 3000;
            int height = 10000;

            Font font = new Font("Time New Romans", 10, FontStyle.Regular);
            List<Documento> listaDocumentos = con.GetDocumentos(query);

            int recCount = listaDocumentos.Count;
            int pageCount = (recCount + 37 - 1) / 37;
            int y = 80;
            //int z = 50;

            rec = rec += 1;
            currentpage = currentpage + 1;

            if (currentpage == 1)
            {
                pagesleft = pageCount - 1;
            }

            ////Cabecera
            //e.Graphics.DrawString("CAR".PadLeft(2, '0') + "\n", font, Brushes.Black, new System.Drawing.Rectangle(50, z, width, height));
            //e.Graphics.DrawString("ORD".PadLeft(3, '0') + "\n", font, Brushes.Black, new System.Drawing.Rectangle(80, z, width, height));
            //e.Graphics.DrawString("FECH".PadRight(30, ' ') + "\n", font, Brushes.Black, new System.Drawing.Rectangle(120, z, width, height));
            //e.Graphics.DrawString("CONT".PadRight(30, ' ') + "\n", font, Brushes.Black, new System.Drawing.Rectangle(220, z, width, height));
            //e.Graphics.DrawString("C1".PadRight(30, ' ') + " \n", font, Brushes.Black, new System.Drawing.Rectangle(350, z, width, height));
            //e.Graphics.DrawString("C2".PadRight(30, ' ') + " \n", font, Brushes.Black, new System.Drawing.Rectangle(500, z, width, height));
            //e.Graphics.DrawString("C3" + " \n", font, Brushes.Black, new System.Drawing.Rectangle(550, z, width, height));

            //Datos
            for (; rec -1 < recCount; rec++)
            {
                e.Graphics.DrawString(listaDocumentos[rec - 1].Carpeta.PadLeft(2,'0') + "\n", font, Brushes.Black, new System.Drawing.Rectangle(50, y, width, height));
                e.Graphics.DrawString(listaDocumentos[rec - 1].OrdenCarpeta.PadLeft(3, '0') + "\n", font, Brushes.Black, new System.Drawing.Rectangle(80, y, width, height));
                e.Graphics.DrawString(listaDocumentos[rec - 1].Fecha.ToString("dd/MM/yyy").PadRight(30, ' ') + "\n", font, Brushes.Black, new System.Drawing.Rectangle(120, y, width, height));
                e.Graphics.DrawString(listaDocumentos[rec - 1].Contenido.PadRight(30, ' ') + "\n", font, Brushes.Black, new System.Drawing.Rectangle(205, y, width, height));
                e.Graphics.DrawString(listaDocumentos[rec - 1].Clave1.PadRight(30, ' ') + " \n", font, Brushes.Black, new System.Drawing.Rectangle(320, y, width, height));
                e.Graphics.DrawString(listaDocumentos[rec - 1].Clave2.PadRight(30, ' ') + " \n", font, Brushes.Black, new System.Drawing.Rectangle(500, y, width, height));
                e.Graphics.DrawString(listaDocumentos[rec - 1].Clave3.PadRight(30, ' ') + " \n", font, Brushes.Black, new System.Drawing.Rectangle(700, y, width, height));

                y += 25;

                if (rec % 37 == 0)
                {
                    y = 80;
                    break;
                }
            }

            e.HasMorePages = currentpage < pageCount;
        }
    }
}
