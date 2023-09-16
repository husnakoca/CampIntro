using System;

namespace GameProjectt

{   //microservice
    
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager()
        {
        }

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Congrats! The gamer acoount created.");

            }

            else
            {
                Console.WriteLine("Verification failed. Registration failed.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("The gamer account deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("The gamer account updated");
        }
    }
}
