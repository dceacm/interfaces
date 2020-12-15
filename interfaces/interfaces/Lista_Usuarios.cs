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
        private string query,conexion;

        public Lista_Usuarios(bool t1, bool t2, bool t3, bool c, string tema1, string tema2, string tema3, string contenido)
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM TABLA WHERE algo";
            using (SqlConnection con = new SqlConnection(conexion))
            using(SqlCommand cmd = new SqlCommand(query, con))
            {
                //cmd.Parameters.AddWithValue("@algo",algoMas);
                if(MessageBox.Show("Eliminar 'incidencia?'", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            aux = e.RowIndex;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            aux = e.RowIndex;
        }
    }
}
