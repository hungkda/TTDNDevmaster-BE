internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<string, string> listE = new SortedList<string, string>();

        listE.Add("E01", "a");
        listE.Add("E02", "b");
        listE.Add("E03", "c");
        listE.Add("E04", "d");

        Console.WriteLine("List: ");

        foreach(var key in listE.Keys)
        {
            Console.WriteLine(key + " " + listE[key]);
        }

        Console.WriteLine("Danh sách nhân viên bắt đầu bằng a");
        foreach (var key in listE.Keys)
        {
            if (listE[key].StartsWith("a")) {
                Console.WriteLine(key + " " + listE[key]);
            }
            
        }

        //xóa nhân viên
        listE.Remove("E02");

        //kiểm tra nếu ko có thì add
        if (!listE.ContainsKey("E09")) {
            listE.Add("E09", "f");
        }

        Console.WriteLine("List update: ");

        foreach (var key in listE.Keys)
        {
            Console.WriteLine(key + " " + listE[key]);
        }

    }
}