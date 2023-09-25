using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[] arr = {5, 2, 4, 6, 7, 8, 9, 4, 5, 10};
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        //Tìm max
        int max = arr[0];
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine("Phần tử lớn nhất của mảng là: "+max);
        Console.WriteLine("Phần tử nhỏ nhất của mảng là: " + min);

        //
        bool kt = true;
        for(int i = 0;i < arr.Length;i++)
        {
            if (arr[i] != arr[arr.Length-1 - i] ) {
                kt = false; break;
            }
        }

        if (kt)
        {
            Console.WriteLine("Mảng đối xứng");
        }
        else Console.WriteLine("Mảng không đối xứng");

    }
}