using GameProjectt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                YearOfBirth = 1985,
                Name = "Engin",
                Surname = "Demirog",
                NationalId = 12345
            });
        }
    }
} 
