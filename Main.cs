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

        FanLaptop fan = new FanLaptop();
        Console.WriteLine("========== State Fan Laptop ==========");
        Console.WriteLine("========== STATUS AWAL : QUIET ==========");
        
        bool status = true;
        while (true)
        {
            string choice = Console.ReadLine();
            fanState state = fanState.Quiet;
            switch (state)
            {
                case fanState.Quiet:
                    if (choice == "Turbo")
                    {
                        state = fanState.Turbo;
                        Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                    }
                    else if (choice == "Balanced")
                    {
                        state = fanState.Balanced;
                        Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                    }
                    return;
                case fanState.Turbo:
                    if (choice == "Quiet")
                    {
                        state = fanState.Quiet;
                        Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                    }
                    else if (choice == "Performance")
                    {
                        state = fanState.Performance;
                        Console.WriteLine("Fan Turbo berubah menjadi Performance");
                    }
                    return;
                case fanState.Performance:
                    if (choice == "Turbo")
                    {
                        state = fanState.Turbo;
                        Console.WriteLine("Fan Performance berubah menjadi Turbo");
                    } else if (choice == "Balanced")
                    {
                        state = fanState.Balanced;
                        Console.WriteLine("Fan Performance berubah menjadi Balanced");
                    }
                    return;
                case fanState.Balanced:
                    if (choice == "Performance")
                    {
                        state = fanState.Performance;
                        Console.WriteLine("Fan Balanced berubah menjadi Performance");
                    }
                    return;
            }
        }
    }
}