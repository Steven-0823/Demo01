namespace MyConsolesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWriter MyWriter = new MessageWriter();
            MyWriter.Write("Hello, Writer");

            FiggleWriter Fwriter = new FiggleWriter();
            Fwriter.Write("Hello, Figgle!!!!");
        }
    }
}
