using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt
{
    class CampaignManager : IGameService
    { 
        public void Add()
        {
            Console.WriteLine("Congrats! The campaign added.");
        }

        public void Delete()
        {
            Console.WriteLine("The campaign deleted.");
        }

        public void Update()
        {
            Console.WriteLine("The campaign updated");
        }
    }
}
