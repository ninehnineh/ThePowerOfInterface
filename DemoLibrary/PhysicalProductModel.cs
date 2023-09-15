using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PhysicalProductModel
    {
        public string Title { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            Console.WriteLine($"Simulating shipping { Title } to { customer.FirstName }{ customer.LastName } in { customer.City }");
        }
    }
}
