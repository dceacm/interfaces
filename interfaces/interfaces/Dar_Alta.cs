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
    public partial class Dar_Alta : Form
    {
        public Dar_Alta()
        {
            InitializeComponent();
        }

        private void dtp_Fecha_ValueChanged(object sender, EventArgs e)
        {
            tb_Carpeta.Text = dtp_Fecha.Value.Year.ToString().Substring(2);
        }
    }
}
