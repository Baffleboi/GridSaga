﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridSagaPrototype
{
    public partial class Map //This classes purpose is to create a replica of the grid of buttons instead as a grid of class Tile so that all the code can be done without effecting the buttons directly
    {
        //Button[,] gridButtons = new Button[10, 10];
        private Tile[,] TileArray;
        private static int[] MovementOptionsX = { 1, -1, 0, 0 };
        private static int[] MovementOptionsY = { 0, 0, 1, -1 };
        public Map(int width, int height, int cost)
        {

            TileArray = new Tile[width, height];
            List<int[]> possibleMoves = new List<int[]>(); //a list of possible moves
            //TileArray[width,height] = new Tile(width, height, cost);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    TileArray[i, j] = new Tile(i, j, cost);

                }
            }
        }
        public void Moves(int row, int column)
        {

        }

        public ref Tile getTile(int i, int j) { return ref TileArray[i, j]; }

        public void moveSearch(int startX, int startY) //dijkstra with a move limit
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
                    break;
                }
                else

                for (int i = 0; i < 4; i++)
                {
                    int newXCoord = x + MovementOptionsX[i];
                    int newYCoord = y + MovementOptionsY[i];

                    if (!visitedTiles[newXCoord, newYCoord])
                    {
                        visitedTiles[newXCoord, newYCoord] = true;
                        queue.Enqueue(new Tile(newXCoord, newYCoord, moves + 1));
                    }
                }
            }
        }

       
    }
}

