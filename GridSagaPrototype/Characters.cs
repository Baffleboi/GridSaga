﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GridSagaPrototype
{
    internal class Characters
    {
        private int Health;
        private int Attack;
        private int Speed;
        private Image Sprite;

        public Characters(int newHealth, int newAttack, int newSpeed, Image newSprite) { Health = newHealth; Attack = newAttack; Speed = newSpeed; Sprite = newSprite; }
    }
}
