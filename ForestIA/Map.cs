using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ForestIA
{
    public class Map
    {
        private int[,] map;
        private Point size;
        private Point target;
        private Point initial;
        public static int targetConst = 3;
        public static int personConst = 2;
        public static int stoneConst = 1;
        public static int grassConst = 0;

        public Map(int width, int height)
        {
            this.size = new Point(width, height);
            map = new int[width,height];

            for(int i = 0; i < width; i++)
            {
                map[0, i] = 1;
                map[width-1, i] = 1;
                map[i, 0] = 1;
                map[i, height-1] = 1;
            }
        }

        public Point getSize()
        {
            return size;
        }

        public int getMapId(Point point)
        {
            return map[point.X,point.Y];
        }

        public void setItem(Point coordenate, int type)
        {
            map[coordenate.X, coordenate.Y] = type;
            if (type == 2)
                initial = coordenate;
            else if (type == 3)
                target = coordenate;
        }

        public void setRandomStones(int stonesNumber)
        {
            int stones = 0;
            do
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                int x = rnd.Next(0, size.X);
                Random rnd2 = new Random(DateTime.Now.Millisecond * DateTime.Now.Millisecond);
                int y = rnd2.Next(0, size.Y);
                if (map[x, y] != 1)
                {
                    map[x, y] = 1;
                    stones++;
                }
            } while (stones < stonesNumber);
        }

        public void calculate()
        {
            int[,] copia = new int[size.X,size.Y];
            for (int i = 0; i < size.X; i++)
                for (int j = 0; j < size.Y; j++)
                    copia[i,j] = map[i, j] == 1 ? -1 : 0;
            copia[initial.X, initial.Y] = -2;
            copia[target.X, target.Y] = 0;
        }
    }
}
