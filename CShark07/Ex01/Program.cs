using System.Reflection.Metadata.Ecma335;
using DongVat;

internal class Program
{
    private static void Main(string[] args)
    {
        DongVat.AnCo.Bo bo = new DongVat.AnCo.Bo();
        bo.Id = "1";
        bo.Name = "Bo";
        bo.Weight = 100;

        DongVat.AnCo.De de = new DongVat.AnCo.De("2", "De", 90);
        DongVat.AnCo.Trau trau = new DongVat.AnCo.Trau("3", "Trau", 110);
        DongVat.AnThit.CaSau caSau = new DongVat.AnThit.CaSau("4", "CaSau", 120);
        DongVat.AnThit.Ho ho = new DongVat.AnThit.Ho("5", "Ho", 100);
        DongVat.AnThit.SuTu suTu = new DongVat.AnThit.SuTu("6", "SuTu", 900);

        Console.WriteLine("Thong tin dong vat: ");
        Console.WriteLine("\tId: {0}, Name: {1}, Weight: {2} KG", bo.Id, bo.Name, bo.Weight);
        Console.WriteLine("\tId: {0}, Name: {1}, Weight: {2} KG", de.Id, de.Name, de.Weight);
        Console.WriteLine("\tId: {0}, Name: {1}, Weight: {2} KG", trau.Id, trau.Name, trau.Weight);
        Console.WriteLine("\tId: {0}, Name: {1}, Weight: {2} KG", caSau.Id, caSau.Name, caSau.Weight);
        Console.WriteLine("\tId: {0}, Name: {1}, Weight: {2} KG", ho.Id, ho.Name, ho.Weight);
        Console.WriteLine("\tId: {0}, Name: {1}, Weight: {2} KG", suTu.Id, suTu.Name, suTu.Weight);

    }
}