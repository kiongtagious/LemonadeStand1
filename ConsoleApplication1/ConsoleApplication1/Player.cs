using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Player
    {
        double bank = 10;

        Inventory inventory;
        public Player()
        {
            
            inventory = new Inventory();
        }
    }
}
