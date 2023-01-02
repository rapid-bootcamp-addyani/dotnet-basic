using LogicDasar;

public class MainLogic
{
    public static void Main()
    {
        Console.WriteLine("Masukan Angka :");
        string? input = Console.ReadLine();
        int n = input == null ? 0 : int.Parse(input);

        Console.WriteLine("\nLogic 1 Soal Nomor 1:");
        Logic01Soal01.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 2:");
        Logic01Soal02.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 3:");
        Logic01Soal03.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 4:");
        Logic01Soal04.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 5:");
        Logic01Soal05.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 6:");
        Logic01Soal06.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 7:");
        Logic01Soal07.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 8:");
        Logic01Soal08.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 9:");
        Logic01Soal09.CetakData(n);
        Console.WriteLine("\nLogic 1 Soal Nomor 10:");
        Logic01Soal10.CetakData(n);

        Console.WriteLine("\nLogic 2 Soal Nomor 1:");
        Logic02Soal01.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 2:");
        Logic02Soal02.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 3:");
        Logic02Soal03.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 4:");
        Logic02Soal04.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 5:");
        Logic02Soal05.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 6:");
        Logic02Soal06.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 7:");
        Logic02Soal07.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 8:");
        Logic02Soal08.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 9:");
        Logic02Soal09.CetakData(n);
        Console.WriteLine("\nLogic 2 Soal Nomor 10:");
        Logic02Soal10.CetakData(n);
    }
}
