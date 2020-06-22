using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //PrintAllProducts();
            //PrintAllCustomers();
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            //Exercise8();
            //Exercise9();
            //Exercise10();
            //Exercise11();
            //Exercise12();
            //Exercise13();
            //Exercise14();
            //Exercise15();
            //Exercise16();
            //Exercise17();
            //Exercise18();
            //Exercise19();
            //Exercise20();
            //Exercise21();
            //Exercise22();
            //Exercise23();
            //Exercise24();
            //Exercise25();
            //Exercise26();
            //Exercise27();
            //Exercise28();
            //Exercise29();
            //Exercise30();
            //Exercise31();


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        #region "Sample Code"
        /// <summary>
        /// Sample, load and print all the product objects
        /// </summary>
        static void PrintAllProducts()
        {
            List<Product> products = DataLoader.LoadProducts();
            PrintProductInformation(products);
        }

        /// <summary>
        /// This will print a nicely formatted list of products
        /// </summary>
        /// <param name="products">The collection of products to print</param>
        static void PrintProductInformation(IEnumerable<Product> products)
        {
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }

        }

        /// <summary>
        /// Sample, load and print all the customer objects and their orders
        /// </summary>
        static void PrintAllCustomers()
        {
            var customers = DataLoader.LoadCustomers();
            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// This will print a nicely formated list of customers
        /// </summary>
        /// <param name="customers">The collection of customer objects to print</param>
        static void PrintCustomerInformation(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine(customer.Address);
                Console.WriteLine("{0}, {1} {2} {3}", customer.City, customer.Region, customer.PostalCode, customer.Country);
                Console.WriteLine("p:{0} f:{1}", customer.Phone, customer.Fax);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }
        #endregion

        /// <summary>
        /// Print all products that are out of stock.
        /// </summary>
        static void Exercise1()
        {
            List<Product> product = DataLoader.LoadProducts();
            var outOfStock = product.Where(p => p.UnitsInStock == 0);

            PrintProductInformation(outOfStock);
        }

        /// <summary>
        /// Print all products that are in stock and cost more than 3.00 per unit.
        /// </summary>
        static void Exercise2()
        {
            List<Product> product = DataLoader.LoadProducts();
            var inStock = product.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            PrintProductInformation(inStock);
        }

        /// <summary>
        /// Print all customer and their order information for the Washington (WA) region.
        /// </summary>
        static void Exercise3()
        {
            List<Customer> customers = DataLoader.LoadCustomers();
            var waCustomers = customers.Where(c => c.Region == "WA");

            PrintCustomerInformation(waCustomers);
        }

        /// <summary>
        /// Create and print an anonymous type with just the ProductName
        /// </summary>
        static void Exercise4()
        {
            List<Product> products = DataLoader.LoadProducts();
            var productName = from product in products
                              select new
                              {
                                  name = product.ProductName
                              };

            Console.WriteLine("Product Name");
            Console.WriteLine("================================");

            foreach (var product in productName)
            {
                Console.WriteLine($"{product.name}");
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all product information but increase the unit price by 25%
        /// </summary>
        static void Exercise5()
        {
            List<Product> products = DataLoader.LoadProducts();
            var productCostIncrease = from product in products
                                      select new
                                      {
                                          newId = product.ProductID,
                                          newName = product.ProductName,
                                          newCategory = product.Category,
                                          newUnitPrice = product.UnitPrice * 1.25M,
                                          newUnitsInStock = product.UnitsInStock,
                                      };

            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in productCostIncrease)
            {
                Console.WriteLine(line, product.newId, product.newName, product.newCategory,
                    product.newUnitPrice, product.newUnitsInStock);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
        /// </summary>
        static void Exercise6()
        {
            List<Product> products = DataLoader.LoadProducts();
            var allCaps = from product in products
                                      select new
                                      {
                                          newName = product.ProductName.ToUpper(),
                                          newCategory = product.Category.ToUpper(),
                                      };

            string line = "{0,-35} {1,-15}";
            Console.WriteLine(line, "Product Name", "Category");
            Console.WriteLine("=======================================================");

            foreach (var product in allCaps)
            {
                Console.WriteLine(line, product.newName, product.newCategory);
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra bool property ReOrder which should 
        /// be set to true if the Units in Stock is less than 3
        /// 
        /// Hint: use a ternary expression
        /// </summary>
        static void Exercise7()
        {
            List<Product> products = DataLoader.LoadProducts();
            var extraBool = from product in products
                                      select new
                                      {
                                          newId = product.ProductID,
                                          newName = product.ProductName,
                                          newCategory = product.Category,
                                          newUnitPrice = product.UnitPrice * 1.25M,
                                          newUnitsInStock = product.UnitsInStock,
                                          ReOrder = product.UnitsInStock < 3 ? true : false,
                                      };

            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6} {5, 8}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock", "ReOrder");
            Console.WriteLine("==============================================================================");

            foreach (var product in extraBool)
            {
                Console.WriteLine(line, product.newId, product.newName, product.newCategory,
                    product.newUnitPrice, product.newUnitsInStock, product.ReOrder);
            }

        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra decimal called 
        /// StockValue which should be the product of unit price and units in stock
        /// </summary>
        static void Exercise8()
        {
            List<Product> products = DataLoader.LoadProducts();
            var extraValue = from product in products
                            select new
                            {
                                newId = product.ProductID,
                                newName = product.ProductName,
                                newCategory = product.Category,
                                newUnitPrice = product.UnitPrice * 1.25M,
                                newUnitsInStock = product.UnitsInStock,
                                StockValue = product.UnitPrice * product.UnitsInStock
                            };

            string line = "{0,-5} {1,-35} {2,-15} {3,8:c} {4,7} {5,12}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock", "Stock Value");
            Console.WriteLine("========================================================================================");

            foreach (var product in extraValue)
            {
                Console.WriteLine(line, product.newId, product.newName, product.newCategory,
                    product.newUnitPrice, product.newUnitsInStock, product.StockValue.ToString("C"));
            }
        }

        /// <summary>
        /// Print only the even numbers in NumbersA
        /// </summary>
        static void Exercise9()
        {
            var test = DataLoader.NumbersA.Where(n => n % 2 == 0);

            foreach (var num in test)
            {
                Console.Write($"{num}, ");
            }

        }

        /// <summary>
        /// Print only customers that have an order whos total is less than $500
        /// </summary>
        static void Exercise10()
        {
            List<Customer> customers = DataLoader.LoadCustomers();
            var orders = from customer in customers
                         from minimumOrders in customer.Orders
                         where minimumOrders.Total < 500M
                         select customer;

            List<Customer> uniqueList = orders.Distinct().ToList(); 

            PrintCustomerInformation(uniqueList);
        }

        /// <summary>
        /// Print only the first 3 odd numbers from NumbersC
        /// </summary>
        static void Exercise11()
        {
            var test = DataLoader.NumbersC.Where(n => n % 2 == 1);
            int loopCounter = 0;

            foreach (var num in test)
            {
                loopCounter++;
                if (loopCounter <= 3)
                {
                    Console.Write($"{num}, ");
                }
            }
        }

        /// <summary>
        /// Print the numbers from NumbersB except the first 3
        /// </summary>
        static void Exercise12()
        {
            var test = DataLoader.NumbersB;
            for (int i = 3; i < test.Length; i++)
            {
                Console.Write($"{test[i]}, ");
            }
        }

        /// <summary>
        /// Print the Company Name and most recent order for each customer in Washington
        /// </summary>
        static void Exercise13()
        {
            List<Customer> customers = DataLoader.LoadCustomers();
            var waCustomers = customers.Where(c => c.Region == "WA");
            var lastOrder = from customer in waCustomers
                            select new
                            {
                                Customer = customer.CompanyName,
                                LastOrder = customer.Orders.Last()
                            };

            foreach (var customer in lastOrder)
            {
                Console.WriteLine(customer.Customer);
                Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", customer.LastOrder.OrderID, customer.LastOrder.OrderDate, customer.LastOrder.Total);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC until a number is >= 6
        /// </summary>
        static void Exercise14()
        {
            var test = DataLoader.NumbersC;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] < 6)
                {
                    Console.Write($"{test[i]}, ");
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC that come after the first number divisible by 3
        /// </summary>
        static void Exercise15()
        {
            var test = DataLoader.NumbersC;
            int i = 0;

            while (i < test.Length)
            {
                if (test[i] % 3 == 0)
                {
                    while (i < test.Length - 1)
                    {
                        i++;
                        Console.Write($"{test[i]}, ");
                    }
                }
                else
                {
                    i++;
                }

            }
        }

        /// <summary>
        /// Print the products alphabetically by name
        /// </summary>
        static void Exercise16()
        {
            List<Product> products = DataLoader.LoadProducts();
            var sortedList = products.OrderBy(p => p.ProductName).ToList();

            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in sortedList)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }
        }

        /// <summary>
        /// Print the products in descending order by units in stock
        /// </summary>
        static void Exercise17()
        {
            List<Product> products = DataLoader.LoadProducts();
            var sortedList = products.OrderByDescending(p => p.UnitsInStock).ToList();

            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in sortedList)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }
        }

        /// <summary>
        /// Print the list of products ordered first by category, then by unit price, from highest to lowest.
        /// </summary>
        static void Exercise18()
        {
            List<Product> products = DataLoader.LoadProducts();

            string line = "{0,-5} {1,-35} {2,6:c} {3,6}";

            var sortedList = from product in products
                             orderby product.UnitPrice descending
                             group product by product.Category;
                             
            foreach (var product in sortedList)
            {
                Console.WriteLine(product.Key);

                foreach (var item in product)
                {                 
                    {
                        Console.WriteLine(line, item.ProductID, item.ProductName,
                            item.UnitPrice, item.UnitsInStock);
                    }
                }
            }

        }

        /// <summary>
        /// Print NumbersB in reverse order
        /// </summary>
        static void Exercise19()
        {
            var test = DataLoader.NumbersB;

            Array.Reverse(test);
            foreach (int i in test)
            {
                Console.Write(i + " ");
            }
        }

        /// <summary>
        /// Group products by category, then print each category name and its products
        /// ex:
        /// 
        /// Beverages
        /// Tea
        /// Coffee
        /// 
        /// Sandwiches
        /// Turkey
        /// Ham
        /// </summary>
        static void Exercise20()
        {
            List<Product> products = DataLoader.LoadProducts();

            var sortedList = from product in products
                             group product by product.Category;

            foreach (var product in sortedList)
            {
                Console.WriteLine(product.Key);
                Console.WriteLine("==============================");

                foreach (var item in product)
                {
                    {
                        Console.WriteLine(item.ProductName);
                    }
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print all Customers with their orders by Year then Month
        /// ex:
        /// 
        /// Joe's Diner
        /// 2015
        ///     1 -  $500.00
        ///     3 -  $750.00
        /// 2016
        ///     2 - $1000.00
        /// </summary>
        static void Exercise21()
        {
            List<Customer> customers = DataLoader.LoadCustomers();
            
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine("==================================");

                var ordersByYear = from order in customer.Orders
                                   group order by order.OrderDate.Year;

                foreach (var order in ordersByYear)
                {
                    Console.WriteLine(order.Key);

                    var ordersByMonth = from order1 in order
                                        group order1 by order1.OrderDate.Month;

                    foreach (var o in ordersByMonth)
                    {
                        var monthSum = o.Sum(x => x.Total).ToString("C");

                        Console.WriteLine($"{o.Key}" + " - " + $"{monthSum}");
                        Console.WriteLine();
                    }
                }
            }
             

        }

        /// <summary>
        /// Print the unique list of product categories
        /// </summary>
        static void Exercise22()
        {
            List<Product> products = DataLoader.LoadProducts();

            var uniqueList = from product in products
                             select product.Category;


            var sortedList = uniqueList.Distinct().ToList();

            foreach (var element in sortedList)
            {
                Console.WriteLine(element);
            }
        }

        /// <summary>
        /// Write code to check to see if Product 789 exists
        /// </summary>
        static void Exercise23()
        {
            List<Product> products = DataLoader.LoadProducts();

            var productIdSearch = products.Any(p => p.ProductID == 789);

            if (productIdSearch == true)
            {
                Console.WriteLine("Product ID 789 exists.");
            }

            else
            {
                Console.WriteLine("Product ID 789 does not exist.");
            }
        }

        /// <summary>
        /// Print a list of categories that have at least one product out of stock
        /// </summary>
        static void Exercise24()
        {
            List<Product> products = DataLoader.LoadProducts();
            var outOfStock = products.Where(p => p.UnitsInStock == 0);

            var justCategory = from stock in outOfStock
                               select stock.Category;

            var uniqueCategory = justCategory.Distinct();

            foreach (var cat in uniqueCategory)
            {
                Console.WriteLine(cat);
            }
            
        }

        /// <summary>
        /// Print a list of categories that have no products out of stock
        /// </summary>
        static void Exercise25()
        {
            List<Product> products = DataLoader.LoadProducts();
            var outOfStock = products.Where(p => p.UnitsInStock == 0);

            var categoryNoStock = from stock in outOfStock
                               select stock.Category;

            var uniqueCategoryNoStock = categoryNoStock.Distinct();

            var allCategory = from product in products
                              select product.Category;

            var allCateogryUnique = allCategory.Distinct();

            var modified = allCateogryUnique.Except(uniqueCategoryNoStock);

            foreach (var mod in modified)
            {
                Console.WriteLine(mod);
            }


        }

        /// <summary>
        /// Count the number of odd numbers in NumbersA
        /// </summary>
        static void Exercise26()
        {
            var nums = DataLoader.NumbersA;

            var oddCount = nums.Where(n => n % 2 == 1);

            var numOfOdd = oddCount.Count();

            Console.WriteLine(numOfOdd);
        }

        /// <summary>
        /// Create and print an anonymous type containing CustomerId and the count of their orders
        /// </summary>
        static void Exercise27()
        {
            List<Customer> customers = DataLoader.LoadCustomers();

            var IdsAndCounts = from customer in customers
                              select new
                              {
                                  CustomerID = customer.CustomerID,
                                  OrderCount = customer.Orders.Count()
                              };

            foreach (var customer in IdsAndCounts)
            {
                Console.WriteLine(customer.CustomerID);
                Console.WriteLine(customer.OrderCount + " orders");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the count of the products they contain
        /// </summary>
        static void Exercise28()
        {
            List<Product> products = DataLoader.LoadProducts();
            var allCats = from product in products
                          group product by product.Category;

            foreach (var cat in allCats)
            {
                Console.WriteLine(cat.Key);
                Console.WriteLine(cat.Key.Count());
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the total units in stock
        /// </summary>
        static void Exercise29()
        {
            List<Product> products = DataLoader.LoadProducts();
            var allCats = from product in products
                          group product by product.Category;

            foreach (var cat in allCats)
            {
                Console.WriteLine(cat.Key);
                Console.WriteLine(cat.Select(c => c.UnitsInStock).Sum());
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the lowest priced product in that category
        /// </summary>
        static void Exercise30()
        {
            List<Product> products = DataLoader.LoadProducts();
            var allCats = from product in products
                          group product by product.Category;

            foreach (var cat in allCats)
            {
                Console.WriteLine(cat.Key);
                Console.WriteLine(cat.Select(c => c.UnitPrice).Min().ToString("C"));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print the top 3 categories by the average unit price of their products
        /// </summary>
        static void Exercise31()
        {
            List<Product> products = DataLoader.LoadProducts();
            var allCats = products.GroupBy(p => p.Category);

            var avgCats = allCats.OrderByDescending(a => a.Select(c => c.UnitsInStock).Average().ToString("C"));

            var topThree = avgCats.Take(3);            

            foreach (var top in topThree)
            {
                Console.WriteLine(top.Key);
                Console.WriteLine(top.Select(c => c.UnitsInStock).Average().ToString("C"));
                Console.WriteLine();
            }
        }
    }
}
