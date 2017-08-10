using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Game
    {
        Store store;
        Player player;

        public Game()
        {
            store = new Store(player);
            player = new Player();
        }
    }
}
