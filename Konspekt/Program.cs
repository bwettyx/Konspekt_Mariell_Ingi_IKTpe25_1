

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

            //2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
            Console.WriteLine($"Sisesta oma pikkus ka {nimi}!";
            double kasutajaPikkus = double.Parse(Console.ReadLine());

            if (kasutajaPikkus < 1.00d)
            {
                Console.WriteLine("Oled juntsu (Keemstar)");
            }
            else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
            {
                Console.WriteLine("Oled peaaegu allameetrimees");
            }
            else if (kasutajaPikkus < 1.50 && kasutajaPikkus >= 1.25d)
            {
                Console.WriteLine("OIOI, päkapikk enam ei olegi, "+nimi);
            }
            else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
            {
                Console.WriteLine(nimi+", oled enamasti standardipikkuses, kui mitte kui mitte just natuke lühike");
            }
            else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
            {   
                Console.WriteLine(nimi+, oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö 😏'")
            }
            else
            {
                Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
            }

            //3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
            Console.WriteLine("tere, sisesta esimene liidetav arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("tere, sisesta teine liidetav arv");
        }
    }
}
