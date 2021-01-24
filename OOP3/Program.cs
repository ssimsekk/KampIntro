using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceler tuttukları classların referans numaralarını tutabilirler.

            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();          
            ICreditManager transportCreditManager = new TransportCreditManager();           
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager artisanCreditManager = new ArtisanCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService(), new SmsLoggerService() };


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Application(artisanCreditManager, loggerServices);

            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, transportCreditManager };
            

            //applicationManager.CreditPreInformation(credits);

        }
    }
}
