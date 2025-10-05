using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01CollectionsApp.InsiteInternational
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }

        public int Quantity { get; set; }
        public int UnitPrice { get; set; }

        public OrderItem() {
            Console.WriteLine("order item created");
        }

        public double CalcualteCost() { 
          return  Quantity* UnitPrice;
        }

        //override hashCode and Equals

        public override int GetHashCode()
        {
            return this.Id;
        }

        public override bool Equals(object obj)
        {
            OrderItem item = (OrderItem) obj;
            return (this.Id == item.Id && this.ItemName == item.ItemName);
        }
    }
}
