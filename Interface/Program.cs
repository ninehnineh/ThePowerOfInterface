using DemoLibrary;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
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

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Sting" });
            output.Add(new PhysicalProductModel { Title = "RebBull" });
            output.Add(new PhysicalProductModel { Title = "NiveaMen" });
            output.Add(new DigitalProductModel { Title = "C#.pdf" });
            output.Add(new DigitalProductModel { Title = "Java.pdf" });

            return output;
        }
    }
}
