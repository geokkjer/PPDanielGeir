namespace PPDanielGeir;

public class Addshop
{
    public Addshop(List<Shop> shops)
    {
       ShopAdder(shops);
    }
    public static void ShopAdder(List<Shop> shops)
    {
        Console.Clear();
        String shopName;
        String shopSpeciality;
        int shopPrice;
        Console.WriteLine("Velkommen til Shop Adder");
        Console.WriteLine("Skriv inn navnet: ");
        shopName = Console.ReadLine();
        Console.WriteLine("Skriv inn spesialiteten: ");
        shopSpeciality = Console.ReadLine();
        Console.WriteLine("Skriv inn prisnivå [1 - 5] : ");
        shopPrice = int.Parse(Console.ReadLine());
        if (shopName == "" || shopSpeciality == "" || shopPrice == 0)
        {
            ShopAdder(shops);
        }
        shops.Add(new Shop(shopName, shopSpeciality, shopPrice));
    }
}