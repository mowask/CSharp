using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_18_LINQ
{

    internal class Program
    {
        static readonly string[] countries = {"Albania", "UK",
        "Lithuania", "Andorra", "Austria",
        "Latvia", "Liechtenstein", "Switzerland",
        "Ireland", "Sweden","Italy", "France",
        "Liechtenstein", "Spain", "Turkey", "Germany",
        "Switzerland", "Monaco", "Montenegro",
        "Norway", "Finland", "Turkey", "UK", "Poland",
        "Portugal", "Lithuania", "Luxembourg"
    };

        static void Main(string[] args)
        {

        // LINQ query
        //var result = countries.Where(c => c.StartsWith("L")).Select(c => c);

        //Console.WriteLine("Countries begining with L:");

        //foreach (var item in countries) 
        //        Console.WriteLine(item);
                
        //Console.WriteLine();


        //var countryMoreFive = countries.Where(c => c.Length > 5);
        //    foreach (var item in countries)
        //        Console.WriteLine(item);

        
            var result2 = from c in countries 
                      where c.StartsWith("L") 
                      select c;

            ///
            var a = new[] { 0, 1, 2 };
            /// anon is complited as an anonymus type
            var anon = new { Name = "Terry", Age = 34 };
            ///
            var list = new List<int>();



        var products = GenerateProductList();

            //Console.WriteLine(products.Count());   

            //foreach (var p in products)
            //    Console.WriteLine(p);

            //Console.WriteLine();


            //var productNameLess500 = products.Where(p => p.Price < 500).Select(p => p.Name.ToUpper());
            //foreach (var p in productNameLess500)
            //    Console.WriteLine(p);

            //Console.WriteLine();


            //var productNameLess500 =from p in products
            //                        where p.Price < 500
            //                        orderby p.Price
            //                        select p.Name.ToUpper();
            //foreach (var p in productNameLess500)
            //    Console.WriteLine(p);


            //var productNameMore8 = from p in products
            //                         where p.Count > 8                                     
            //                         select p.Name.ToLower();
            //foreach (var p in productNameMore8)
            //    Console.WriteLine(p);


            //var productNameAndPriceLess500 = products.Where(p =>  p.Price <500).
            //                                    Select(p => new { Product = p.Name, 
            //                                                      Price = p.Price });
            //foreach (var item in productNameAndPriceLess500)
            //        Console.WriteLine(item);

            //var productNameAndPriceLess500 = from p in products
            //                                 where p.Price < 500
            //                                 select new
            //                                 {
            //                                     Product = p.Name,
            //                                     Price = p.Price
            //                                 };
            //foreach (var item in productNameAndPriceLess500)
            //        Console.WriteLine(item);



            //var productCountyL = from p in products
            //                    where p.Manufacturer.StartsWith("L")
            //                    orderby p.Price  descending   // revers sorting
            //                    select p;
            //foreach (var c in productCountyL)
            //    Console.WriteLine(c);


            //var productsOrderByCount = from p in products
            //                           orderby p.Count descending
            //                           select p;

            //foreach (var p in productsOrderByCount.Take(2))
            //    Console.WriteLine(p);
            //Console.WriteLine();
            //foreach (var p in productsOrderByCount.Skip(45))
            //    Console.WriteLine(p);


            
            var productManufacturerMore6 = from p in products
                                           where p.Manufacturer.Length > 6
                                           orderby p.Count
                                           select p;
            foreach (var p in productManufacturerMore6.Take(5))
                Console.WriteLine(p);

            Console.WriteLine();


            var last3Product = from p in products
                               orderby p.Price
                               select new { p.Manufacturer, p.Price };
            foreach (var product in last3Product.Take(5))
               Console.WriteLine(product);





            var prodFromItaly = (from p in products
                                 where p.Manufacturer == "Italy"
                                 select p.Price).Average();
            //      =
            var prodFromItaly2 = products.Where(p => p.Manufacturer == "Italy").
                                            Select(p => p.Price).
                                            Average();



            var sumProdContWhereManufacturerT = products.Where(p => p.Manufacturer.StartsWith ("T")).
                                                         Select(p => p.Count).
                                                         Sum();
            //      =
            var sumProdContWhereManufacturerT2 = (from p in products
                                              where p.Manufacturer.StartsWith("T")
                                              select p.Count).Sum();


        }

        static IEnumerable <Product> GenerateProductList()
        {
            var rand = new Random();
            List<Product> products = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                products.Add(new Product
                {
                    Name = "Product" + (++i),
                    Price = rand.Next(0, 1000),
                    Manufacturer = countries[rand.Next(0, countries.Length - 1)],
                    Count = rand.Next(0, 10)
                });
            }
        return products;
        }
    }


    class Product 
    { 
        public string Name { get; set; }
        public int  Price { get; set; }
        public string Manufacturer { get; set; }
        public int Count { get; set; }
        public override string ToString()
        {
            return $"{Name} {Price} {Manufacturer} {Count}";
        }


    }

}
