using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSagaPrototype
{
    public class Tile //This class holds the properties of each Tile of the Map
    {
        public int xCoord;
        public int yCoord;
        private int MovementCost;
        public Tile(int i, int j, int movementcost) { xCoord = i; yCoord = j; MovementCost = movementcost; }

        public Color tileColor = Color.Green; 
        private Characters Entity;

        public ref Characters getEntity() { return ref Entity; }
        public void setEntity(Characters newEntity) { Entity = newEntity; }

        public void setTileColor(Color backgroundColor) { tileColor = backgroundColor; }
        public Color getTileColor() { return tileColor; }

        

        public void setMovementCost(int cost) { MovementCost = cost; }
        public int getMovementCost() { return MovementCost; }
    }
}
