using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer
            { 
                Id=1, 
                DateOfBirth = new DateTime(1999,7,6), 
                FirstName="Samet"  , 
                LastName="Akca,", 
                NationalityId="123456789"  });
        }

       

    }
}
