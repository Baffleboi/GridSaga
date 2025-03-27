using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSagaPrototype
{
    internal static class Globals
    {
        public static int[] LastPosition = new int[] { int.MaxValue, int.MaxValue }; //this will be used to assign the value of the previous move so that any data there about characters can be removed
        public static int lastCharacterID = 0; //this will be used to store the ID of the character that was last pressed and had dijksta performed on it
    }
}
