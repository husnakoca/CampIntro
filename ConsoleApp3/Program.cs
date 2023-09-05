using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.MobileControls;
using System.Windows.Documents;

namespace OOP3
{
    //We use interfaces in situations where they are alternatives to each other but have different code contents.
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerServices();
            ILoggerService fileLoggerService = new FileLoggerServices();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(personalFinanceCreditManager, new DataBaseLoggerServices());

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, vehicleCreditManager};
            //applicationManager.MakeACreditPreInformation(credits);
        }
    }
}
