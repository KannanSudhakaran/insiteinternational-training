
using Lab01CollectionsApp.InsiteInternational;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab01CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            // CaseStudy2();

            // CaseStudy3();

            //CaseStudy4();

            //CaseStudy5();

            CaseStudy6();
        }

        private static void CaseStudy6()
        {
            
            Dictionary<string,int> map=new Dictionary<string,int>();
            map["IT"] = 10;
            map["Sales"] = 20;
            map["Marketing"] = 30;

            Console.WriteLine(map["Marketing"]);

            foreach (string key in map.Keys)
            {
                Console.WriteLine($"deptname is {key} ,head count is {map[key]}");
            }

            if (map.ContainsKey("Devops"))
            {
                Console.WriteLine("Devops dept found");
            }
            else {
                Console.WriteLine("Devops dept not found");
            }

        }

        private static void CaseStudy5()
        {
            var basketSet = new HashSet<OrderItem>();
          
            basketSet.Add(new OrderItem
            {
                Id = 1,
                ItemName = "Milk",
                Quantity = 2,
                UnitPrice = 20
            });
            basketSet.Add(new OrderItem
            {
                Id = 2,
                ItemName = "Bisucits",
                Quantity = 3,
                UnitPrice = 5
            });
             basketSet.Add(new OrderItem
            {
                Id = 2,
                ItemName = "Bisucits",
                Quantity = 3,
                UnitPrice = 5
            });

            Console.WriteLine(basketSet.Count);

        }

        private static void CaseStudy4()
        {
           var  namesSet = new HashSet<string>();
            namesSet.Add("Insite");
            namesSet.Add("Kuzaimah");
            namesSet.Add("Kuzaimah");
            namesSet.Add("Kuzaimah");

            Console.WriteLine(namesSet.Count);
            foreach (string temp in namesSet)
            {
                Console.WriteLine(temp);
            }
        }

        private static void CaseStudy3()
        {
            var item1 = new OrderItem
            {
                Id = 1,
                ItemName = "Milk",
                Quantity = 2,
                UnitPrice = 20
            };

            var item2 = new OrderItem
            {
                Id = 2,
                ItemName = "Bisucits",
                Quantity = 3,
                UnitPrice = 5
            };
            var item3 = new OrderItem
            {
                Id = 3,
                ItemName = "Chocolate",
                Quantity = 10,
                UnitPrice = 2
            };

            List<OrderItem> basket = new List<OrderItem>();
            basket.Add(item1);
            basket.Add(item2);
            basket.Add(item3);
            // basket.Add("Insite International");


            double totalCost = 0;
            foreach (OrderItem item in basket)
            {
                totalCost += item.CalcualteCost();
                Console.WriteLine($"item name : {item.ItemName} cost is {item.CalcualteCost()}");

            }

            Console.WriteLine("checkout cost " + totalCost);
        }

        private static void CaseStudy2()
        {
          

           var item1 = new OrderItem
            {
                Id = 1,
                ItemName = "Milk",
                Quantity = 2,
                UnitPrice = 20
            };

            var item2 = new OrderItem
            {
                Id = 2,
                ItemName = "Bisucits",
                Quantity = 3,
                UnitPrice = 5
            };
           var item3 = new OrderItem
            {
                Id = 3,
                ItemName = "Chocolate",
                Quantity = 10,
                UnitPrice = 2
            };

            ArrayList basket = new ArrayList();
            basket.Add(item1);
            basket.Add(item2);
            basket.Add(item3);

            basket.Add(new OrderItem
            {
                Id=4,
                ItemName="book",
                Quantity = 3,
                UnitPrice = 10

            });
            // not type safe
            // basket.Add(100);
             basket.Add("INsite international");

            double totalCost = 0;
            foreach (object temp in basket) {

                 OrderItem item  =   (OrderItem) temp;
                totalCost += item.CalcualteCost();
                Console.WriteLine($"item name : {item.ItemName} cost is {item.CalcualteCost()}");
            
            }

            Console.WriteLine("checkout cost "+totalCost);


        }

        private static void CaseStudy1()
        {
            OrderItem[] basket = new OrderItem[3];
            basket[0] = new OrderItem
            {
                Id = 1,
                ItemName = "Milk",
                Quantity = 2,
                UnitPrice= 20
            };

            basket[1] = new OrderItem
            {
                Id = 2,
                ItemName = "Bisucits",
                Quantity = 3,
                UnitPrice = 5
            };
            basket[2] = new OrderItem
            {
                Id = 3,
                ItemName = "Chocolate",
                Quantity = 10,
                UnitPrice = 2
            };

            double totalCost = 0;
            foreach (OrderItem temp in basket) {

                Console.WriteLine("item name"+temp.ItemName);
                Console.WriteLine("item cost"+temp.CalcualteCost());
                totalCost += temp.CalcualteCost();
                Console.WriteLine();
            
            }

            Console.WriteLine("paid this amount at coutner"+totalCost);



        }
    }
}
