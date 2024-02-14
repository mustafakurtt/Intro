﻿// See https://aka.ms/new-console-template for more information

using Intro.Business;
using Intro.Entities;

//Console.WriteLine("Hello, World!");

//string message1 = "Krediler";
//int term = 12;
//double amount = 100000;

////variables -->camelCase
//bool isAuthenticated = true;
//Console.WriteLine(message1);

////condition
//if (isAuthenticated)
//{
//    Console.WriteLine("Buton-->Hoşgeldin Engin");
//}
//else
//{
//    Console.WriteLine("Buton-->Sisteme giriş yap");
//}

//string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" };//dbden gelecek
////string[] loans2 = new string[6];
////loans2[0] = "Kredi 1";

////start    condition        //increment
//for (int i = 0; i < loans.Length; i++)
//{
//    Console.WriteLine(loans[i]);
//}



//CourseManager courseManager = new();
//Course[] courses2 = courseManager.GetAll();
//for (int i = 0; i < courses2.Length; i++)
//{
//    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
//}


//Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.NationalIdentity = "123456";

IndividualCustomer customer2 = new();
customer2.Id = 2;
customer2.CustomerNumber = "54321";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.NationalIdentity = "654321";

CorporateCustomer customer3 = new();
customer3.Id = 3;
customer3.CustomerNumber = "67890";
customer3.Name = "Kodlama.io";
customer3.TaxNumber = "1234567890";

BaseCustomer[] baseCustomers = {customer1, customer2, customer3};

foreach (var customer in baseCustomers)
{
    Console.WriteLine(customer.CustomerNumber);
}