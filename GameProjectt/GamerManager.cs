using System;

namespace GameProjectt

{   //microservice
    
    class GamerManager : IGamerService
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
