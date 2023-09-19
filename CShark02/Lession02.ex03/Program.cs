using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int second, minute=0, hour=0;
        string secondS, minuteS, hourS;
        Console.Write("Nhập số giây: ");
        second = Convert.ToInt32(Console.ReadLine());
        while (second < 0 )
        {
            Console.Write("Nhập lại số giây: ");
            second = Convert.ToInt32(Console.ReadLine());
        }

        if(second >= 60 ) {
            minute = second / 60;
            second %= 60;
            if (minute >= 60)
            {
                hour = minute / 60;
                minute %= 60;           
            }
        }

        if(second < 10)
        {
            secondS = "0" + second.ToString();
        }else
        {
            secondS = second.ToString();
        }

        if (minute < 10)
        {
            minuteS = "0" + minute.ToString();
        }
        else
        {
            minuteS = minute.ToString();
        }

        if (hour < 10)
        {
            hourS = "0" + hour.ToString();
        }
        else
        {
            hourS = hour.ToString();
        }
        Console.WriteLine(hourS+ ":" + minuteS + ":" +secondS);
    }
}