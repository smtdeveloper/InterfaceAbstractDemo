using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            { 
                DateOfBirth = new DateTime(1999,7,6), 
                FirstName="SAMET"  , 
                LastName="AKCA", 
                NationalityId="55555555"  
            });

            Console.ReadLine();
        }

       

    }
}
