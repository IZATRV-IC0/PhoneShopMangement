using MobileSaleLibrary;
using MobileSaleLibrary.Models;
// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(String[] args)
    {
        string s = "1,23-1-2020,1";
        Import? c = DataString.IConvert(s);
        Console.WriteLine("" + c.ImportId + c.ImportDate + c.SupplierId);
        Console.ReadLine();
    }
}
