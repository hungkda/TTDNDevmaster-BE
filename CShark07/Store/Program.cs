using Store;

internal class Program
{
    private static void Main(string[] args)
    {
        //tạo mới nhà phân phối cung cấp đẩy đủ namespace
        Supply.Manufacturer dealer = new Supply.Manufacturer();

        dealer.Name = "Coca";
        dealer.Email = "coca123@coco.com";
        dealer.Phone = "1234567890";

        //In thông tin
        Console.WriteLine("Dealer information");
        Console.WriteLine("\t Name:" +dealer.Name);
        Console.WriteLine("\t Email:" + dealer.Email);
        Console.WriteLine("\t Phone:" + dealer.Phone);


        //tạo mới sản phẩm trong namespace store
        StoreItem si = new StoreItem();
        si.ItemNo = 0;
        si.ItemName = "Chicken";
        si.price = 80.000M;

        //in
        Console.WriteLine("Store Inventory: ");
        Console.WriteLine("\tItem #:" + si.ItemNo);
        Console.WriteLine("\tItem Name:" + si.ItemName);
        Console.WriteLine("\tItem Price:" + si.price);

    }
}