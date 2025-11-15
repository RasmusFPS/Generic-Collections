namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant Campinos = new Restaurant();

            MenuItem pizza = new MenuItem(1,"Pizza",125);
            MenuItem KebabRulle = new MenuItem(2, "Kebab Rulle", 123);
            MenuItem KababTalrik = new MenuItem(3,"Kebab Talrik",130);
            MenuItem Sallad = new MenuItem(4, "Sallad", 250);
            Console.WriteLine("");

            Campinos.AddtoMenu(pizza);
            Campinos.AddtoMenu(KebabRulle);
            Campinos.AddtoMenu (KababTalrik);
            Campinos.AddtoMenu(Sallad);

            Campinos.ShowMenu();


            List<MenuItem> Order1_items = new List<MenuItem>();
            Order1_items.Add(pizza);
            Order1_items.Add (KebabRulle);

            List<MenuItem> Order2_items = new List<MenuItem>();
            Order2_items.Add(KababTalrik);
            Order2_items.Add(Sallad);
            Order2_items.Add(KababTalrik);

            List<MenuItem> Order3_items = new List<MenuItem>();
            Order3_items.Add(pizza);


            Orders order1 = new Orders(Order1_items, 28);
            Orders order2 = new Orders(Order2_items, 67);
            Orders order3 = new Orders(Order3_items, 2);

            Campinos.CreateOrder(order1);
            Campinos.CreateOrder(order2);
            Campinos.CreateOrder(order3);
            Console.WriteLine("");

            Console.WriteLine("Orders");
            order1.DisplayOrder();
            Console.WriteLine("");
            order2.DisplayOrder();
            Console.WriteLine("");
            order3.DisplayOrder();
            Console.WriteLine("");

            Campinos.HandleOrder();
            Campinos.ShowNextOrder(order1);
            Campinos.ShowOrderCount();
        }
    }
}
