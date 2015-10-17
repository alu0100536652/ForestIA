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
        private ContextMenu cm;

        public menu()
        {
            InitializeComponent();
            game = new Game(ref containerView);
            cm = new ContextMenu();
            cm.MenuItems.Add("Seleccionar Obstaculo");
            cm.MenuItems.Add("Seleccionar Protagonista");
            cm.MenuItems.Add("Seleccionar Objetivo");
            cm.MenuItems.Add("Play");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarDimensionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion ventanaConfiguracion = new Configuracion(ref game);
            ventanaConfiguracion.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            containerView.SizeMode = PictureBoxSizeMode.StretchImage;
            containerView.ContextMenu = cm;
        }
    }
}
