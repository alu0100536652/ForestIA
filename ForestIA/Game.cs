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
        private Point sector;

        public Game(ref PictureBox containerView)
        {
            tileset = new Bitmap[10];
            tileset[0] = Properties.Resources.bg2;
            tileset[1] = Properties.Resources.rsz_tree;
            tileset[2] = Properties.Resources.person2;
            tileset[3] = Properties.Resources.poke;
            this.containerView = containerView;
            sector = new Point(0, 0);
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

        public Point getSector()
        {
            return sector;
        }

        public void setSector(Point value)
        {
            if (value.X > 10)
                sector.X++;
            else if (value.X < 5)
                if((sector.X - 1) >= 0)
                    sector.X -= 1;
            if (value.Y > 10)
                sector.Y++;
            else if (value.Y < 5)
                if ((sector.Y - 1) >= 0)
                    sector.Y -= 1;
        }

        public void Run()
        {
            do
            {
                Update();
                PrintMove();
                Thread.Sleep(300);
            } while (list.Count() > 1);
            

        }

        public void PrintMove()
        {

            int minX = sector.X * 15;
            int minY = sector.Y * 15;
            int maxX = (sector.X * 15) + 15;
            int maxY = (sector.Y * 15) + 15;

            Bitmap sectorView = new Bitmap(15* resolutionTile, 15* resolutionTile);
            int x = 0;
            int y = 0;
            for (int coordenadaX = minX; coordenadaX < maxX; coordenadaX++)
            {
                for (int coordenadaY = minY; coordenadaY < maxY; coordenadaY++)
                {
                    using (Graphics grafico = Graphics.FromImage(sectorView))
                    {
                        Bitmap tile = tileset[map.getMapId(new Point(coordenadaX, coordenadaY))];
                        grafico.DrawImage(tile, new Point(x * resolutionTile, y * resolutionTile));
                    }
                    y++;
                }
                y = 0;
                x++;
            }

            containerView.Image = sectorView;
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
                sector.X = list[1].X / 15;
                sector.Y = list[1].Y / 15;
                map.setItem(list[1], Map.personConst);
            }
            list.RemoveAt(0);
        }
    }
}
