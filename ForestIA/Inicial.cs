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
        private int selector;
        

        public menu()
        {
            InitializeComponent();
            game = new Game(ref containerView);
            selector = 0;
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
            containerView.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void containerView_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouse = (MouseEventArgs)e;
            switch (selector)
            {
                case 1:
                    game.getMap().setStone((mouse.X / 32), (mouse.Y / 32));
                    game.Print();
                    break;
                case 2:
                    game.getMap().setPerson((mouse.X / 32),(mouse.Y / 32));
                    game.Print();
                    selector = 0;
                    break;
            }
        }

        private void aleatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obstaculos ventanaObstaculos = new Obstaculos(ref game);
            ventanaObstaculos.Show();
        }

        private void protagonistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selector = 2;
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selector = 1;
        }
    }
}
