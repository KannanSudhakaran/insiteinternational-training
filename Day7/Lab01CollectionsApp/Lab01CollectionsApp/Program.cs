
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

            CaseStudy3();
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
