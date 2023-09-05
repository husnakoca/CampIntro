using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt
{
    public class CampaignInfo
    {
        static void Main(string[] args)
        {

            Campaign campaign1 = new Campaign();
            campaign1.Id = 3543521;
            campaign1.Name = "Super Weekend!";
            campaign1.Sales = "Monthly gaming membership is only $500 instead of $600!";

            Campaign campaign2 = new Campaign();
            campaign2.Id = 8743687;
            campaign2.Name = "Huge Discount!";
            campaign2.Sales = "50% discount on game character costumes for today!";
        }
    }
}
