using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class CampaignManager : IGameService
    {
        public void Add()
        {
            Console.WriteLine(Campaign.Name + "campaign successfully added.");
        }

        public void Remove()
        {
            Console.WriteLine(Campaign.Name + "campaign successfully deleted.");
        }

        public void Update()
        {
            Console.WriteLine(Campaign.Name + "The gamer successfully updated");
        }
    }
}
