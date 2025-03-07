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
        public Tile(int x, int y)
        {

        }

        private Color backColor = Color.Green; 
        private int MovementCost = 1;
        private Characters Character;

        public ref Characters getCharacters() { return ref Character; }
        public void setCharacters(Characters newCharacter) { Character = newCharacter; }

        public void setColor(Color backgroundColor) { backColor = backgroundColor; }
        public Color getBackColor() { return backColor; }

        public void setMovementCost(int cost) { MovementCost = cost; }
        public int getMovementCost() { return MovementCost; }
    }
}
