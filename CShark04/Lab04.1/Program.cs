using Lab04._1;

internal class Program
{
    private static void Main(string[] args)
    {
        Window win = new Window(1, 2);
        ListBox lb = new ListBox(3, 4, "LBBBBB");
        Button bt = new Button(5, 6);

        win.DrawWindow();
        lb.DrawWindow();
        bt.DrawWindow();

        Window[] winArr = new Window[3];
        winArr[0] = new Window(1, 2);
        winArr[1] = new ListBox(3, 4, "LBBBBBArray");
        winArr[2] = new Button(5, 6);
        for (int i = 0; i < 3; i++)
        {
            winArr[i].DrawWindow();
        }
    }
}