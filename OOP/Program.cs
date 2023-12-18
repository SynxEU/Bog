namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title, forfatter;
            Console.Write("Indtast en bog title: ");
            title = Console.ReadLine();
            Console.WriteLine("--------------------------------------");
            Console.Write("Indtast bogens forfatter: ");
            forfatter = Console.ReadLine();
            Bog bog = new Bog(title, forfatter);
            Console.WriteLine(bog.Title + "\n" + bog.Forfatter);
        }
    }
}
