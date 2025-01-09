namespace PPDanielGeir;

public class ShowAllShops
{
    public void ShowAll(List<Shop> shops)
    {
        foreach (Shop shop in shops)
        {
            shop.PrintShop();
        }
    
    }
    
}