// See https://aka.ms/new-console-template for more information
using kahve;
using kahve.Abstract;
using kahve.Concrete;



BaseCustomerManager customerManager= new NeroCustomerManager();
customerManager.Save(new Customer { DateOfBirth = new DateTime(1985,1,6), FirstName="doğa",LastName="pehlivan",NationalityId= "111111111" });