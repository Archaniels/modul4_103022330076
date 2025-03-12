internal class Program
{
    private static void Main(string[] args)
    {
        KodeProduk kode = new KodeProduk();
        Console.WriteLine("Produk Elektronik ----- Kode Produk");
        Console.WriteLine("Laptop " + kode.getKodeProduk("Laptop"));
        Console.WriteLine("Smartphone " + kode.getKodeProduk("Smartphone"));
        Console.WriteLine("Tablet " + kode.getKodeProduk("Tablet"));
        Console.WriteLine("Headset " + kode.getKodeProduk("Headset"));
        Console.WriteLine("Keyboard " + kode.getKodeProduk("Keyboard"));
        Console.WriteLine("Mouse " + kode.getKodeProduk("Mouse"));
        Console.WriteLine("Printer " + kode.getKodeProduk("Printer"));
        Console.WriteLine("Monitor " + kode.getKodeProduk("Monitor"));
        Console.WriteLine("Smartwatch " + kode.getKodeProduk("Smartwatch"));
        Console.WriteLine("Kamera " + kode.getKodeProduk("Kamera"));
    }
}