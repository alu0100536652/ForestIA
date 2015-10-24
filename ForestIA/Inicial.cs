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
            selector = Map.grassConst;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.getMap().calculate();
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
            Point point = new Point((mouse.X / 32), (mouse.Y / 32));
            switch (selector)
            {
                case 1:
                    if (mouse.Button == MouseButtons.Left)
                    {
                        game.getMap().setItem(point,Map.stoneConst);
                        game.Print();
                    } else
                    {
                        game.getMap().setItem(point, Map.grassConst);
                        game.Print();
                    }
                    break;
                case 2:
                    if (mouse.Button == MouseButtons.Left)
                    {
                        game.getMap().setItem(point, Map.personConst);
                        game.getPerson().ubicar(point);
                        game.Print();
                        selector = Map.grassConst;
                    } else
                    {
                        game.getMap().setItem(point, Map.grassConst);
                        game.Print();
                    }
                    break;
                case 3:
                    if (mouse.Button == MouseButtons.Left)
                    {
                        game.getMap().setItem(point, Map.targetConst);
                        game.Print();
                        selector = Map.grassConst;
                    }
                    else
                    {
                        game.getMap().setItem(point, Map.grassConst);
                        game.Print();
                    }
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
            selector = Map.personConst;
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selector = Map.stoneConst;
        }

        private void objetivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selector = Map.targetConst;
        }
    }
}
