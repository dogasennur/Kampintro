using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeproject.Abstract
{
    public abstract class BaseCustomerManager
    { 
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db :" + customer.FirstName);
        }
    }
}
