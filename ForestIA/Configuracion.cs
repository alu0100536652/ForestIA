using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForestIA
{
    public partial class Configuracion : Form
    {
        private Game game;

        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSizeMap_Click(object sender, EventArgs e)
        {

        }
    }
}
