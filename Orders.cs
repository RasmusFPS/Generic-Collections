using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    internal class Orders
    {
        public static int orderidcounter = 1;
        public int _orderid;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Orders(List<MenuItem> orderItems, int tableNumber)
        {
            this._orderid = orderidcounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void AddItems(MenuItem item)
        {
            _orderItems.Add(item);
        }

        public void DisplayOrder()
        {
            decimal localSum = 0;

            Console.WriteLine($"--- Order {_orderid} ---");
            foreach (var item in _orderItems)
            {
                Console.WriteLine($"- {item.Name} - {item.Price}");
                localSum = item.Price + localSum;
            }
            Console.WriteLine($"Final Sum: {localSum:C}");
            
        }



    }
}
