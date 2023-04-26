using System.Runtime.InteropServices;

class Program
{
    [DllImport("/home/xxx/invoke/hi.so")]
    private static extern int Sayhi();

    static void Main(string[] args)
    {
     
        Console.WriteLine("Hello World!");
        int status = Sayhi();
        Console.WriteLine(status);

    }
}