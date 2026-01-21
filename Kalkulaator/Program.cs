namespace Kalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kas su tuba on kolmnurga, ristküliku või ringi kujuline?");
            string toakuju = Console.ReadLine();
            if (toakuju == "kolmnurk")
            {
                Console.WriteLine($"Mis on sinu esimese külje pikkus");
                double külg_a = double.Parse( Console.ReadLine() );
            }
        }
    }
}
