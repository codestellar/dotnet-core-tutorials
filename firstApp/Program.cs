using System;
using Newtonsoft.Json;

namespace firstApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var product = new Product{
                Id = 1,
                Name ="Earphones",
                Price = 500
            };

            var jsonString = JsonConvert.SerializeObject(product);

            Console.WriteLine(jsonString);

            var productFromJson = JsonConvert.DeserializeObject<Product>(jsonString);

            Console.WriteLine(string.Format("The product Name is {0}", productFromJson.Name));

            Console.Read();

        }
    }

    public class Product{
        public int Id{get;set;}
        public string Name{get;set;}
        public int Price{get;set;}
    }
}
