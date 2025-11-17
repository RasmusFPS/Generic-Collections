// Fil: Program.cs
using System;
using System.Collections.Generic;

namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant campinos = new Restaurant();

            //Adding the menu items
            MenuItem pizza = new MenuItem(1, "Pizza", 125m);
            MenuItem kebabRulle = new MenuItem(2, "Kebab Rulle", 123m);
            MenuItem kebabTallrik = new MenuItem(3, "Kebab Tallrik", 130m);
            MenuItem sallad = new MenuItem(4, "Sallad", 95m);

            campinos.AddtoMenu(pizza);
            campinos.AddtoMenu(kebabRulle);
            campinos.AddtoMenu(kebabTallrik);
            campinos.AddtoMenu(sallad);

            // Steg 3: Skriv ut menyn.
            campinos.ShowMenu();

            //Creates new order
            Orders order1 = new Orders(new List<MenuItem> { pizza, kebabRulle, kebabTallrik}, 28);
            Orders order2 = new Orders(new List<MenuItem> { kebabTallrik, sallad }, 67);
            Orders order3 = new Orders(new List<MenuItem> { pizza, sallad, pizza }, 2);

            campinos.CreateOrder(order1);
            campinos.CreateOrder(order2);
            campinos.CreateOrder(order3);

            //Show all orders
            campinos.ShowOrders();

            //Show all orders in queue
            campinos.ShowOrderCount();

            //Show next order
            campinos.ShowNextOrder();

            //Handels on order
            campinos.HandleOrder();

            //Show how many orders in queue
            campinos.ShowOrderCount();

            //New order
            Orders order4 = new Orders(new List<MenuItem> { kebabRulle, kebabRulle, sallad }, 3);
            campinos.CreateOrder(order4);

            //Shows all the orders in queue
            campinos.ShowOrderCount();

            //Handels 2 orders
            campinos.HandleOrder();
            campinos.HandleOrder();

            
            campinos.ShowOrderCount();

            campinos.ShowNextOrder();

            campinos.HandleOrder();

            campinos.ShowOrderCount();
        }
    }
}