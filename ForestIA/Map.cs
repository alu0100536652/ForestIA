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
        private int[,] map, copia;
        private Point size;
        private Point target;
        private Point initial;
        public static int targetConst = 3;
        public static int personConst = 2;
        public static int stoneConst = 1;
        public static int grassConst = 0;
        List<Point> traceList;

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

        public Point getInitial()
        {
            return initial;
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

        //A*

        public List<Point> calculate()
        {
            //create map copy
            copia = new int[size.X,size.Y];
            for (int i = 0; i < size.X; i++)
                for (int j = 0; j < size.Y; j++)
                    copia[i,j] = map[i, j] == 1 ? -1 : -3;
            copia[initial.X, initial.Y] = -2;
            copia[target.X, target.Y] = 0;

            //calculate cost
            Point current = new Point(target.X, target.Y);
            int cost = 1;
            List<Point> openList = new List<Point>();
            int statesForIncrement = 0;
            int statesForNewCost = 0;
            int statesCounter = 0;
            bool flag = false;

            do
            {
                statesForIncrement += fourDirection(current, cost, ref openList, ref flag);

                if ((statesCounter == statesForNewCost) || (cost.Equals(1)))
                {
                    cost++;
                    statesForNewCost = 0;
                    statesCounter = 0;
                    statesForNewCost = statesForIncrement;
                    statesForIncrement = 0;
                }

                current = openList[0];
                statesCounter++;
                openList.RemoveAt(0);

            } while ((!openList.Count.Equals(0))||(!flag));


            //calculate trace
            Point last = initial;
            int costToTarget = 100000;
            traceList = new List<Point>();
            traceList.Add(initial);
            do
            {
                last = forDirectionTrace(last, ref costToTarget);
                traceList.Add(last);
            } while (!costToTarget.Equals(0));

            return traceList;     

        }

        private Point forDirectionTrace(Point last, ref int cost)
        {
            Point next = new Point();
            if ((copia[last.X, last.Y - 1] < cost)&&(copia[last.X, last.Y - 1] >= 0))
            {
                next = new Point(last.X, last.Y - 1); cost = copia[last.X, last.Y - 1];
            }
            if ((copia[last.X, last.Y + 1] < cost)&& (copia[last.X, last.Y + 1] >= 0))
            {
                next = new Point(last.X, last.Y + 1); cost = copia[last.X, last.Y + 1];
            }
            if ((copia[last.X - 1, last.Y] < cost)&& (copia[last.X-1, last.Y] >= 0))
            {
                next = new Point(last.X - 1, last.Y); cost = copia[last.X-1, last.Y];
            }
            if ((copia[last.X + 1, last.Y] < cost) && (copia[last.X + 1, last.Y] >= 0))
            {
                next = new Point(last.X + 1, last.Y); cost = copia[last.X+1, last.Y];
            }

            return next;
        }

        private int fourDirection(Point point, int cost, ref List<Point> openList, ref bool flag)
        {
            int numberOfStatesForThisCost = 0;

            if (copia[point.X, point.Y - 1].Equals(-3))
            {
                copia[point.X, point.Y - 1] = cost;
                openList.Add(new Point(point.X, point.Y - 1));
                numberOfStatesForThisCost++;
            } else if (copia[point.X, point.Y - 1].Equals(-2))
                flag = true;

            if (copia[point.X, point.Y + 1].Equals(-3))
            {
                copia[point.X, point.Y + 1] = cost;
                openList.Add(new Point(point.X, point.Y + 1));
                numberOfStatesForThisCost++;
            } else if (copia[point.X, point.Y + 1].Equals(-2))
                flag = true;

            if (copia[point.X - 1, point.Y].Equals(-3))
            {
                copia[point.X - 1, point.Y] = cost;
                openList.Add(new Point(point.X - 1, point.Y));
                numberOfStatesForThisCost++;
            } else if (copia[point.X - 1, point.Y].Equals(-2))
                flag = true;

            if (copia[point.X + 1, point.Y].Equals(-3))
            {
                copia[point.X + 1, point.Y] = cost;
                openList.Add(new Point(point.X + 1, point.Y));
                numberOfStatesForThisCost++;
            } else if (copia[point.X + 1, point.Y].Equals(-2))
                flag = true;

            return numberOfStatesForThisCost;
        }

    }
}
