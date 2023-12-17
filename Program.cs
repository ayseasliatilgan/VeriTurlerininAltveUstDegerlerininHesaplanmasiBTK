internal class Program
{
    private static void Main(string[] args)
    {
        // 8-bit integer 
        Console.WriteLine(nameof(SByte));
        Console.WriteLine($"Alt limit       : {SByte.MinValue,20}");
        // sonuc -128
        Console.WriteLine($"Üst limit       : {SByte.MaxValue,20}");
        // sonuc 127
        Console.WriteLine($"Boyut           : {sizeof(SByte),20}");
        // sonuc 1
        Console.WriteLine();
        Console.ReadKey();

        // unsigned 8-bit integer
        // isaretsiz oldugu icin bize eksi kısmıda artı kısma atacagi icin max limit kısmı 255 olacaktır
        // 255 olmasinin nedeni ise arada bir 0 olmasidir
        Console.WriteLine(nameof(Byte));
        Console.WriteLine($"Alt limit       : {Byte.MinValue,20}");
        Console.WriteLine($"Üst limit       : {Byte.MaxValue,20}");
        Console.WriteLine($"Boyut           : {sizeof(Byte),20}");
        Console.WriteLine();

        // signed 16-bit
        Console.WriteLine(nameof(Int16));
        Console.WriteLine($"Alt limit       : {Int16.MinValue,20}");
        Console.WriteLine($"Üst limit       : {Int16.MaxValue,20}");
        Console.WriteLine($"Boyut           : {sizeof(Int16),20}");
        Console.WriteLine();


        // unsigned 16-bit
        Console.WriteLine(nameof(UInt16));
        Console.WriteLine($"Alt limit       : {UInt16.MinValue,20}");
        Console.WriteLine($"Üst limit       : {UInt16.MaxValue,20}");
        Console.WriteLine($"Boyut           : {sizeof(UInt16),20}");
        Console.WriteLine();

        // signed 32-bit
        Console.WriteLine(nameof(Int32));
        Console.WriteLine($"Alt limit       : {Int32.MinValue,20}");
        Console.WriteLine($"Üst limit       : {Int32.MaxValue,20}");
        Console.WriteLine($"Boyut           : {sizeof(Int32),20}");
        Console.WriteLine();

        // Double
        Console.WriteLine(nameof(Double));
        Console.WriteLine($"Alt limit       : {Double.MinValue,20}");
        Console.WriteLine($"Üst limit       : {Double.MaxValue,20}");
        Console.WriteLine($"Boyut           : {sizeof(Double),20}");
        Console.WriteLine();

        Console.ReadKey();
    }
}