internal class Program
{
    private static void Main(string[] args)
    {
        int[] ints = { 1, 2, 3, 4, 5, -2, 2, 5, -5, 9, 2 };

        Console.WriteLine("Cac phan tu trong mang la: ");
        for (int i = 0; i < ints.Length; i ++)
        {
            Console.Write(ints[i] + " ");
        }
        Console.WriteLine();

        int min = ints[0];
        for (int i = 1; i < ints.Length; i++)
        {
            if (ints[i] > min) {
                min = ints[i];
            }
        }
        Console.WriteLine("Phan tu nho nhat trong mang la: " + min);

        int tg;
        for (int i =0; i <= (ints.Length-1) /2; i++)
        {
            tg = ints[i];
            ints[i] = ints[ints.Length - 1 - i];
            ints[ints.Length - 1 - i] = tg;
        }
        Console.WriteLine("Cac phan tu trong mang sau khi dao nguoc la: ");
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < ints.Length-1; i++)
        {
            for(int j = i + 1; j < ints.Length; j++)
            {
                if (ints[i] > ints[j])
                {
                    tg = ints[i] ;
                    ints[i] = ints[j];
                    ints[j] = tg;
                }
            }
        }
        Console.WriteLine("Cac phan tu trong mang sau khi mang sap xep theo thu tu tang dan la: ");
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Cac phan tu trong mang la so nguyen to la: ");
        for (int i = 0; i < ints.Length; i++)
        {
            bool check = true;
            for(int j =2; j<= ints[i]/2; j++)
            {
                if (ints[i] % j == 0 )
                {
                    check = false;
                }
            }
            if (ints[i] >0 && check)
            {
                Console.Write(ints[i] + " ");
            }
        }
        Console.WriteLine();

        int tbc = 0;
        int index = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] > 0 )
            {
                tbc += ints[i];
                index++;
            }
        }
        Console.WriteLine("trung binh cong cac phan tu duong trong mang la: " + (tbc/index));

        bool am = false;
        bool duong = false;

        for(int i =0; i < ints.Length;i++)
        {
            if (ints[i] > 0 )
            {
                duong = true;
            }
            if (ints[i] < 0 )
            {
                am = true;
            }
        }
        if(am  && duong)
        {
            Console.WriteLine("Mang chua cac phan tu am va duong");
           
        }else if (duong)
        {
            Console.WriteLine("Mang chi chua cac duong");
        } else { Console.WriteLine("Mang chi chua cac am"); }
    }
}