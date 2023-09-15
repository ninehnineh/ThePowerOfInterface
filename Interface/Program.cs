using DemoLibrary;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PhysicalProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (PhysicalProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Truong",
                LastName = "Chinh",
                City = "HoChiMinh",
                EmailAddress = "chinh@gmeol.com",
                PhoneNumber = "0353555555"
            };
        }

        private static List<PhysicalProductModel> AddSampleData()
        {
            List<PhysicalProductModel> output = new List<PhysicalProductModel>();

            output.Add(new PhysicalProductModel { Title = "Sting" });
            output.Add(new PhysicalProductModel { Title = "RebBull" });
            output.Add(new PhysicalProductModel { Title = "NiveaMen" });

            return output;
        }
    }
}