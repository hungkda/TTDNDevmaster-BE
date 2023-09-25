using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[,] a =
        {
            {1,2,3 }, {4,5,6}, {7,8,9}, {10,11,12} 
        };

        Console.WriteLine("Mảng:");
        for (int i = 0; i <= a.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= a.GetUpperBound(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Các phần tử có chỉ số hàng bằng chỉ sô cột là: ");
        for (int i = 0; i <= a.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= a.GetUpperBound(1); j++)
            {
                if(i == j )
                {
                    Console.WriteLine(a[i, j] + " ");
                }
            }
        }

        Console.WriteLine("Các phần tử lớn nhất trên hàng là: ");
        for (int i = 0; i <= a.GetUpperBound(0); i++)
        {
            int max = a[i, 0];
            for (int j = 0; j <= a.GetUpperBound(1); j++)
            {
                if (max < a[i, j])
                {
                    max = a[i, j];
                }
                
            }
            Console.WriteLine("Số lớn nhất ở hàng {0} là: {1}", i + 1, max);
        }
    }
}