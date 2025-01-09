namespace PPDanielGeir;

public class MainMeny
{
    public void Meny()
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
                    ShowAllShops.ShowAll(shops);
                    break;
                case "2":
                    break;
                case "X": 
                    System.Environment.Exit(0);
                    break;
            }
        } 
    }
    
    
    
    
    
}