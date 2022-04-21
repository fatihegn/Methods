using System;
using System.Collections.Generic;

namespace ObjectOriented3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sürdürülebilirlik. 
            PersonalCreditManager personalCreditManager = new PersonalCreditManager();

            HousingCreditManager housingCreditManager = new HousingCreditManager();
            // implement ref. diff
            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            RecourseManager recourseManager = new RecourseManager();

            ILoggerService fileLoggerService = new FileLoggerService();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new MessageLoggerService(), new DataBaseLoggerService() };

            recourseManager.DoRecourse(vehicleCreditManager,loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {housingCreditManager,vehicleCreditManager };
            //recourseManager.CreditInfo(credits);



            Console.ReadKey();
        }
    }
}
