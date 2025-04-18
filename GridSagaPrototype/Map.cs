﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridSagaPrototype
{
    public partial class Map //This classes purpose is to create a replica of the grid of buttons instead as a grid of class Tile so that all the code can be done without effecting the buttons directly
    {
        public Tile[,] TileArray;
        //these are the directions that the character can move in
        private static int[] directionX = { 0, 0, 1, -1 };
        private static int[] directionY = { 1, -1, 0, 0 };
        public List<int[]> currentPossibleMoves = new List<int[]>(); //Create a list to contain the current possible moves that can be made
        public Map(int width, int height, int cost)
        {

            TileArray = new Tile[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    TileArray[i, j] = new Tile(i, j, cost);

                }
            }
            //these are walls!!!
            TileArray[2,2] = new Tile(2, 2, 100);
            TileArray[2,2].tileColor = Color.Black;

            //TileArray[2, 3] = new Tile(2, 3, 100);
            //TileArray[2, 3].tileColor = Color.Black;

            //TileArray[2, 4] = new Tile(2, 4, 100);
            //TileArray[2, 4].tileColor = Color.Black;
            //-------------------------
        }

        public ref Tile getTile(int i, int j) { return ref TileArray[i, j]; }

        public void moveSearch(int X, int Y, Characters character) //dijkstra with a move limit
        {
            Queue<Tile> queue = new Queue<Tile>();
            queue.Enqueue(TileArray[X,Y]);
            bool[,] visitedTiles = new bool[10,10]; // this makes a boolean 2d array of size 10x10 since 10 is the size of the map that will keep track of all visited tiles
            visitedTiles[X, Y] = true;
            int moves = character.getSpeed();

            while (queue.Count > 0)
            {
                Tile currentTile = queue.Dequeue();
                int movecost = currentTile.getMovementCost();

                for (int i = 0; i < 4; i++)
                {
                    if (currentTile.xCoord + directionX[i] < 0 || currentTile.xCoord + directionX[i] >= 10 || currentTile.yCoord + directionY[i] < 0 || currentTile.yCoord + directionY[i] >= 10)
                    {
                        continue;
                    }
                    int newXCoord = currentTile.xCoord + directionX[i];
                    int newYCoord = currentTile.yCoord + directionY[i];
                    movecost = Math.Abs(character.getXPos() - newXCoord) + Math.Abs(character.getYPos() - newYCoord);
                    if (movecost >= moves)
                    {
                        break;
                    }
                    if (TileArray[newXCoord,newYCoord].getMovementCost() > moves)
                    {
                        break;
                    }
                    currentPossibleMoves.Add(new int[] { newXCoord, newYCoord });

                    if (!visitedTiles[newXCoord, newYCoord])
                    {
                        visitedTiles[newXCoord, newYCoord] = true;
                        queue.Enqueue(TileArray[newXCoord, newYCoord]);
                    }
                }

            }
        }

       
    }
}

