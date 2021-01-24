using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri - Süleyman ŞİMŞEK

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerId = "12345";
            customer1.CustomerName = "Süleyman";
            customer1.CustomerSurname = "ŞİMŞEK";
            customer1.CitizenshipNumber = "77777777777";


            //Tüzel Müşteri - Şimşek Engineering

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerId = "54321";
            customer2.CompanyName = "Şİmşek Engineering";
            customer2.TaxNumber = "986570";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(customer1);
            customerManager1.Add(customer2);
        }
    }
}
