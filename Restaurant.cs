using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    internal class Restaurant
    {
        private Queue<Orders> _queue = new Queue<Orders>();
        private List<MenuItem> _menu = new List<MenuItem>();

        private int _count = 0;
        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} has been added to the menu!");
        }

        public void ShowMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("---- Resturant Menu ----");
            Console.WriteLine("------------------------");
            foreach (MenuItem menuItem in _menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
        }

        public void CreateOrder(Orders orders) 
        {
            _count++;
            _queue.Enqueue(orders);
            Console.WriteLine($"Order {orders._orderid} coming up");
        }

        public void HandleOrder()
        {
            if (_queue.Count > 0)
            {
                Orders FinnishedOrders = _queue.Dequeue();
                Console.WriteLine("\n------------------------");
                Console.WriteLine($"order {FinnishedOrders._orderid} is finished");
                Console.WriteLine("------------------------\n");
            }
            else
            {
                Console.WriteLine("\nNo Orders");
            }
        }
        
        public void ShowOrderCount()
        {
            Console.WriteLine($"There are orders {_queue.Count} in queue");
            Console.WriteLine("------------------------");
        }

        public void ShowNextOrder(Orders orders)
        {
            Orders Nextorders = _queue.Peek();
            Nextorders.DisplayOrder();
        }
    }
}
