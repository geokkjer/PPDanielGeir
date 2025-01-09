namespace PPDanielGeir;

public class MainMeny
{
    public void Meny(List<Shop> shops)
    {
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Daniel & Geir's list of shops !");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1.) Vis alle butikkene");
            Console.WriteLine("2.) Legg til ny butikk");
            Console.WriteLine("X.) Avslutt");
            Console.WriteLine("------------------------------------------");
            var input  = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Clear();
                    foreach (Shop shop in shops)
                    {
                        shop.PrintShop();
                        
                    }
                    Console.WriteLine("Trykk en tast for å komme tilbake til menyen.");
                    Console.ReadLine();
                    break;
                case "2":
                    Addshop.ShopAdder(shops);
                    break;
                case "X": 
                    System.Environment.Exit(0);
                    break;
                case "":
                    System.Environment.Exit(0);
                    break;
            }
        } 
    }

}