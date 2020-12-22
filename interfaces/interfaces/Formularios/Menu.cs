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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DarAlta da = new DarAlta();
            da.ShowDialog();
            this.Visible = true;
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas c = new Consultas();
            c.ShowDialog();
            this.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
