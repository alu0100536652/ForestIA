using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            List<Point> list = game.getMap().calculate();
            //if(Map.personConst == game.getMap().getMapId(list.First()))
            if (game.getMap().mensaje.Equals(0))
            {
                game.setList(list);

                var thread = new Thread(game.Run);
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                string message = "No se puede acceder porque esta aislado y no hay acceso posible";
                string caption = "El objectivo esta aislado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            
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
                        game.getMap().setItem(new Point(point.X + (game.getSector().X * 15), point.Y + (game.getSector().Y * 15)), Map.stoneConst);
                        game.PrintMove();
                    } else
                    {
                        game.getMap().setItem(new Point(point.X + (game.getSector().X * 15), point.Y + (game.getSector().Y * 15)), Map.grassConst);
                        game.PrintMove();
                    }
                    break;
                case 2:
                    if (mouse.Button == MouseButtons.Left)
                    {
                        game.getMap().setItem(new Point(point.X + (game.getSector().X * 15), point.Y + (game.getSector().Y * 15)), Map.personConst);
                        game.getPerson().ubicar(point);
                        game.PrintMove();
                        selector = Map.grassConst;
                    } else
                    {
                        game.getMap().setItem(new Point(point.X + (game.getSector().X * 15), point.Y + (game.getSector().Y * 15)), Map.grassConst);
                        game.PrintMove();
                    }
                    break;
                case 3:
                    if (mouse.Button == MouseButtons.Left)
                    {
                        game.getMap().setItem(new Point(point.X + (game.getSector().X * 15), point.Y + (game.getSector().Y * 15)), Map.targetConst);
                        game.PrintMove();
                        selector = Map.grassConst;
                    }
                    else
                    {
                        game.getMap().setItem(new Point(point.X + (game.getSector().X * 15), point.Y + (game.getSector().Y * 15)), Map.grassConst);
                        game.PrintMove();
                    }
                    break;
                default:
                    if (mouse.Button == MouseButtons.Right)
                        game.setSector(point);
                    game.PrintMove();
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

        private void desplazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selector = 5;
        }
    }
}
