namespace Konspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. tuvasta sinu võrdluses tühja stringiga, string andmetüüp
            Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Sa ei sisestanud oma nime, sadface 😔");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere "+nimi+"! häpifeiss 😀😀 おはよう");
            }
            else
            {
                Console.WriteLine("Tundmatu sisestus.");
            }
            //2 - vahemikud
            Console.WriteLine(nimi+", mis on sinu vanus?:");
            int kasutajavanus = int.Parse(Console.ReadLine());

            //2.1 mitu tingimust pesastatud ifide abil
            //if (kasutajavanus > 0)
            //{
            //  if (kasutajavanus < 18)
            //  {
            //      Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
            //  }
            //}

            //2.2 mitu tingimust kasutades loogilist tehet "and"
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
            }
            else
            {
                Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
            }

            //2.3 mitu vahemikku if/else-if abil.
        }
    }
}
