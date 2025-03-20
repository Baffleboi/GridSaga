using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSagaPrototype
{
    public partial class Map //This classes purpose is to create a replica of the grid of buttons instead as a grid of class Tile so that all the code can be done without effecting the buttons directly
    {
        private Tile[,,] TileArray;
        int speed = 3;
        public Map(int width, int height, int setDistance = 0)
        {
            List<int[]> possibleMoves = new List<int[]>(); //a list of possible moves
            TileArray = new Tile[width, height, setDistance + 1];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    TileArray[i, j, setDistance] = new Tile(i, j, setDistance);
                }
            }
        }
        public void Moves(int row, int column) 
        {

        }  
        public void moveSearch(int startX, int startY)
        {
            Queue<Tile> queue = new Queue<Tile>();
            queue.Enqueue(new Tile(startX, startY, 1));
            bool[,] visitedTiles = new bool[10,10]; // this makes a boolean 2d array of size 10x10 since 10 is the size of the map that will keep track of all visited tiles
            visitedTiles[startX, startY] = true;

            while (queue.Count > 0)
            {
                Tile currentTile = queue.Dequeue();
                int x = currentTile.xCoord;
                int y = currentTile.yCoord;
                int moves = currentTile.distance;

                if (moves >= 3)
                {
                    continue;
                }
            }
        }
    }
}

