using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.Model;

namespace WiredBrainCoffee.Data
{
    public interface ICustomerDataProvider 
    {
        Task<IEnumerable<Customer>?> GetAllSync();
    }

    class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllSync()
        {
            await Task.Delay(100); //Simulate a bit of Server Work

            return new List<Customer>
            {
                new Customer{Id=1,FirstName="Giuseppe",LastName="Di Lisa",IsDeveloper=true },
                new Customer{Id=2,FirstName="Claudio",LastName="Di Lisa",IsDeveloper=false },
                new Customer{Id=3,FirstName="James",LastName="Di Lisa",IsDeveloper=false },
                new Customer{Id=4,FirstName="Paul",LastName="Di Lisa",IsDeveloper=true },
                new Customer{Id=5,FirstName="Frank",LastName="Di Lisa",IsDeveloper=false },
                new Customer{Id=6,FirstName="Denis",LastName="Di Lisa",IsDeveloper=true },
            };
        }
    }
}
