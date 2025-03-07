using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSagaPrototype
{
    internal class Map //This classes purpose is to create a replica of the grid of buttons instead as a grid of class Tile so that all the code can be done without effecting the buttons directly
    {
        private List<Tile> TileArray = new List<Tile>();
        public Map(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    TileArray.Add(new Tile(i,j));
                }
            }
        }
    }
}
