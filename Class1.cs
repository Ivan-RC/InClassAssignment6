using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Ivan Rivas
/// This is my own work

namespace InClassAssignment6
{
    class Dice
    {
        private int numSides;
        static Random rnd = new Random();
        public Dice (int n)
        {
            numSides = n;
        }

        public int rollDie()
        {
            int val = 0;
            int randomNum = rnd.Next();
            val = randomNum % numSides + 1;
            return val;
        }
    }
}
