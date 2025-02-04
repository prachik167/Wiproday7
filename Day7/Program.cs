internal class Program
{
    public delegate void delSample(string s);

    private static void Main(string[] args)
    {
        delSample del = new delSample(Display);
        del("Hello");
    }
    static void Display(string msg)
    {
        Console.WriteLine(msg);
    }
}