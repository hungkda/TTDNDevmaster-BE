using Lab05._4;

internal class Program
{
    private static void Main(string[] args)
    {
        Book k = new Book("Teach play game", 5);

        k[0] = new Chapter("Chapter 1", "Introduction to game");
        k[1] = new Chapter("Chapter 2", "Gameplay");
        k[2] = new Chapter("Chapter 3", "Tricks and Guide");
        k[3] = new Chapter("Chapter 4", "Practive");
        k[4] = new Chapter("Chapter 5", "Addiction");

        //danh sách chương
        for(int i = 0; i < 5; i++) {
            Console.WriteLine(k[i]);
        }
    }
}