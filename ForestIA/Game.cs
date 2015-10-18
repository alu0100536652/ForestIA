using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ForestIA
{
    public class Game
    {
        private Map map;
        private Bitmap gameView;
        private Bitmap[] tileset;
        private int resolutionTile = 32;
        PictureBox containerView;

        public Game(ref PictureBox containerView)
        {
            tileset = new Bitmap[10];
            tileset[0] = Properties.Resources.bg2;
            tileset[1] = Properties.Resources.rock2;
            tileset[2] = Properties.Resources.person;
            this.containerView = containerView;
        }

        public void Setup(Point inicial)
        {
            map = new Map(inicial.X, inicial.Y);
            gameView = new Bitmap(map.getMapWidth() * resolutionTile, map.getMapHeigth() * resolutionTile);
        }

        public Map getMap()
        {
            return map;
        }

        public void Print()
        {
            for (int coordenadaX = 0; coordenadaX < map.getMapWidth(); coordenadaX++)
            {
                for (int coordenadaY = 0; coordenadaY < map.getMapHeigth(); coordenadaY++)
                {
                    using (Graphics grafico = Graphics.FromImage(gameView))
                    {
                        Bitmap tile = tileset[map.getMapId(coordenadaX, coordenadaY)];
                        grafico.DrawImage(tile, new Point(coordenadaX * resolutionTile, coordenadaY * resolutionTile));
                    }
                }
            }

            containerView.Image = gameView;
        }

        public void Update()
        {

        }
    }
}
