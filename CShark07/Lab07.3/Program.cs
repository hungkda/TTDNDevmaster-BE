internal class Program
{
    private static void Main(string[] args)
    {
        byte[] data = new byte[5];

        try
        {
            for (int i = 0;i< 6; i ++)
            {
                Console.Write("data[{0}]= ", i+1);
                data[i] = Convert.ToByte(Console.ReadLine());
            }
        }
        catch (FormatException ex) 
        { 
            Console.WriteLine(ex.Message);
            Console.WriteLine("Khong nhap ky tu cho mang so");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Khong nhap gia tri ngoai mien 0 den 255");
        }
        catch (IndexOutOfRangeException ex) 
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Vuot qua pham vi cua mang");
        }

        for(int i = 0; i< 5; i ++)
        {
            Console.WriteLine(data[i]);
        }
    }
}