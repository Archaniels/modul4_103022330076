using System;
using System.Runtime.CompilerServices;

public class KodeProduk
{
    private static Dictionary<string, string> kode2 = new Dictionary<string, string>
        {
            {"Laptop", "E100"},
            {"Smartphone", "E101"},
            {"Tablet", "E102"},
            {"Headset", "E103"},
            {"Keyboard", "E104"},
            {"Mouse", "E105"},
            {"Printer", "E106"},
            {"Monitor", "E107"},
            {"Smartwatch", "E108"},
            {"Kamera", "E109"},
        };

    public string getKodeProduk(string produk)
    {
        if (kode2.ContainsKey(produk))
        {
            return kode2[produk];
        }
        return null;
    }
}
