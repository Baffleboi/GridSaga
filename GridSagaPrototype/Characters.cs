using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GridSagaPrototype
{
    public partial class Characters //This class stores all information on Characters (Friendly, Enemies and Obstacles)
    {
        private int Health;
        private int Attack;
        private int Speed;
        private Image Sprite;
        private int xpos;
        private int ypos;
        public Characters(int newHealth, int newAttack, int newSpeed,int startingPosX, int startingPosY, Image newSprite) { Health = newHealth; Attack = newAttack; Speed = newSpeed; Sprite = newSprite; xpos = startingPosX; ypos = startingPosY; }
        
        public int getXPos()
        {
            return xpos;
        }
        public int getYPos()
        {
            return ypos;
        }

        public void setXPos(int newXPos)
        {
            xpos = newXPos;
        }
        public void setYPos(int newYPos)
        {
            ypos = newYPos;
        }
    }
}
