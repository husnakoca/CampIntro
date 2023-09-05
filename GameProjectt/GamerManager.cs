using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt
{
    class GamerManager : IGameService
    {
        public void Add()
        {
            Console.WriteLine("Congrats! The gamer acoount created.");
        }

        public void Delete()
        {
            Console.WriteLine("The gamer account deleted.");
        }

        public void Update()
        {
            Console.WriteLine("The gamer account updated");
        }
    }
}
