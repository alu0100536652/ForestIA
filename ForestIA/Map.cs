using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestIA
{
    public class Map
    {
        private int width, height;
        private int[,] map;

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;
            map = new int[this.width, this.height];

            for(int i = 0; i < width; i++)
            {
                map[0, i] = 1;
                map[width-1, i] = 1;
                map[i, 0] = 1;
                map[i, height-1] = 1;
            }
        }

        public int getMapWidth()
        {
            return width;
        }

        public int getMapHeigth()
        {
            return height;
        }

        public int getMapId(int x, int y)
        {
            return map[x,y];
        }

        public void setPerson(int x, int y)
        {
            map[x, y] = 2;
        }

        public void setGrass(int x, int y)
        {
            map[x, y] = 0;
        }

        public void setStone(int x, int y)
        {
            map[x, y] = 1;
        }

        public void setRandomStones(int stonesNumber)
        {
            int stones = 0;
            do
            {
                Random rnd = new Random();
                int x = rnd.Next(0, width);
                Random rnd2 = new Random();
                int y = rnd2.Next(0, height);
                if (map[x, y] != 1)
                {
                    map[x, y] = 1;
                    stones++;
                }
            } while (stones < stonesNumber);
        }
    }
}
