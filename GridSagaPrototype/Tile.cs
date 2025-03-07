using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSagaPrototype
{
    internal class Tile //This class holds the properties of each Tile of the Map
    {
        int x;
        int y;
        public Tile(int i, int j) { x = i; y = j; }

        private Color backColor = Color.Green; 
        private int MovementCost = 1;
        private Characters Entity;

        public ref Characters getEntity() { return ref Entity; }
        public void setEntity(Characters newEntity) { Entity = newEntity; }

        public void setColor(Color backgroundColor) { backColor = backgroundColor; }
        public Color getBackColor() { return backColor; }

        public void setMovementCost(int cost) { MovementCost = cost; }
        public int getMovementCost() { return MovementCost; }
    }
}
