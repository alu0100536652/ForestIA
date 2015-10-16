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
    public partial class menu : Form
    {
        private Game game;
        public menu()
        {
            InitializeComponent();
            game = new Game();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            Configuracion ventanaConfiguracion = new Configuracion(game);
            ventanaConfiguracion.Show();
        }
    }
}
