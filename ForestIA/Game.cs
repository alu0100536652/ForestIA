using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ForestIA
{
    public class Game
    {
        private Map map;
        private Person person;
        private Bitmap gameView;
        private Bitmap[] tileset;
        private int resolutionTile = 32;
        PictureBox containerView;
        private List<Point> list;
        private int buffer = Map.grassConst;

        public Game(ref PictureBox containerView)
        {
            tileset = new Bitmap[10];
            tileset[0] = Properties.Resources.bg2;
            tileset[1] = Properties.Resources.rsz_tree;
            tileset[2] = Properties.Resources.person2;
            tileset[3] = Properties.Resources.poke;
            this.containerView = containerView;
        }

        public void Setup(Point inicial)
        {
            map = new Map(inicial.X, inicial.Y);
            gameView = new Bitmap(map.getSize().X * resolutionTile, map.getSize().Y * resolutionTile);
            person = new Person();
        }

        public Map getMap()
        {
            return map;
        }

        public Person getPerson()
        {
            return person;
        }

        public void setList(List<Point> list)
        {
            this.list = list;
        }

        public void Run()
        {
            do
            {
                Update();
                Print();
                Thread.Sleep(300);
            } while (list.Count() > 1);
            
        }

        public void Print()
        {
            for (int coordenadaX = 0; coordenadaX < map.getSize().X; coordenadaX++)
            {
                for (int coordenadaY = 0; coordenadaY < map.getSize().Y; coordenadaY++)
                {
                    using (Graphics grafico = Graphics.FromImage(gameView))
                    {
                        Bitmap tile = tileset[map.getMapId(new Point(coordenadaX, coordenadaY))];
                        grafico.DrawImage(tile, new Point(coordenadaX * resolutionTile, coordenadaY * resolutionTile));
                    }
                }
            }

            containerView.Image = gameView;
        }

        public void Update()
        {
            map.setItem(list[0], Map.grassConst);
            if (list.Count > 1)
            {
                buffer = map.getMapId(list[1]);
                map.setItem(list[1], Map.personConst);
            }
            list.RemoveAt(0);
        }
    }
}
