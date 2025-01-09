namespace PPDanielGeir;

public class Shop 
{
    public string ShopName { get; set; }
    public string Speciality { get; set; }
    public int PriceLevel { get; set; }

    public Shop(string shopName, string speciality, int priceLevel)
    {
        ShopName = shopName;
        Speciality = speciality;
        PriceLevel = priceLevel;
    }



    public void PrintShop()
    {
        Console.WriteLine($"Shop Name: {ShopName} Speciality: {Speciality} Price: {PriceLevel}");
    }
    
}




