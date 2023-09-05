using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGameService
    {
        public void Add()
        {
            Console.WriteLine(Gamer.Name + Gamer.Surname + " successfully added as a new player.");
        }

        public void Remove()
        {
            Console.WriteLine(Gamer.Name + " deleted.");
        }

        public void Update()
        {
            Console.WriteLine(Gamer.Name + Gamer.Surname + " gamer successfully updated");
        }

    }
}
