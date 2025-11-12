using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    internal class Orders
    {
        static int orderidcounter = 1;
        private int _orderid;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Orders(List<MenuItem> orderItems, int tableNumber)
        {
            _orderid = orderidcounter;
            orderidcounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }
            
    }
}
