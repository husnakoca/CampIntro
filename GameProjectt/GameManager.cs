using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt
{
    class GameManager
    {
        public void MakeGame(IGameService gamerManager, IGameService campaignManager)
        {
            gamerManager.Add();
            gamerManager.Delete();
            gamerManager.Update();
            campaignManager.Add();
            campaignManager.Delete();
            campaignManager.Update();
        }

        public void MakeGame(List<IGameService> gameServices)
        {
            foreach (var gamer in gameServices)
            {
                gamer.Add();
            }
        }
    }
}
