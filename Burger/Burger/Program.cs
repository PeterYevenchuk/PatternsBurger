using Burger;

class Program
{
    public static void Main()
    {
        RestoranProxy restoranProxy = new RestoranProxy(new Restoran());

        while (restoranProxy.restoran.isElementFound == false)
        {
            Console.Write("Please enter your order: ");
            string nameBurger = Console.ReadLine();
            restoranProxy.SetBurger(nameBurger);
            Console.WriteLine(restoranProxy.restoran.isElementFound);
        }
    }
}
