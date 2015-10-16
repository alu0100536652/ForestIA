using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestIA
{
    class Map
    {
        int width, height;
        int[,] map;

        public Map()
        {
            map = new int[width, height];

            for(int i = 0; i < width; i++)
            {
                map[i, 0] = 1;
                map[i, height] = 1;
                map[0, i] = 1;
                map[width, i] = 1;
            }
        }

        public void setPerson(int x, int y)
        {

        }

        public void setStone(int x, int y)
        {

        }

        public void setRandomStones(int stonesNumber)
        {

        }
    }
}
