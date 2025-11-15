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
        private int _orderid;
        private List<MenuItem> _orderItems;
        private int _tableNumber;
        private decimal Sum = 0;

        public Orders(List<MenuItem> orderItems, int tableNumber)
        {
            _orderid = orderidcounter;
            orderidcounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public void AddItems(MenuItem item)
        {
            _orderItems.Add(item);
        }

        public void DisplayOrder()
        {
            orderidcounter++;
            Console.WriteLine($"--- Order {_orderid} ---");
            foreach (var item in _orderItems)
            {
                Console.WriteLine($"- {item.Name} - {item.Price}");
                Sum = item.Price + Sum;
            }
            Console.WriteLine($"Final Sum: {Sum}");
            
        }



    }
}
