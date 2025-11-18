

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
            Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
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
            Console.WriteLine(nimi + "oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö 😏'");
            }
            else
            {
                Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
            }

            //3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
            Console.WriteLine("tere, sisesta esimene liidetav arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("tere, sisesta teine liidetav arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("sisesta themärk: / * + - ^");
            string tehtetyyp = Console.ReadLine();

            int tulemus = 0;
            if (tehtetyyp == "+")
            {
                tulemus = arv1 + arv2;
            }  
            if (tehtetyyp == "-")
            {
                tulemus = arv1 - arv2;
            }
            if (tehtetyyp == "*")
            { 
                tulemus = arv1 * arv2;
            }
            if (tehtetyyp == "/")
            {
                tulemus = arv1 / arv2;
            }
            if (tehtetyyp == "^")
            {
                tulemus = (int)Math.Pow(arv1, arv2);
            }

						Console.WriteLine(tulemus);

            //4 parool, if ja string andmetüüp
            Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
            string password = Console.ReadLine();
            if (password == "simsalabim")
            {
                Console.WriteLine("JES, parool on õige, oled sisse lubatud");
            }
            else if (password == "saatana" || password == "1234")
            {
                Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
            }
            else
            {
                Console.WriteLine("Parool on vale");
            }

            //5 värvituvastus värvidele: punane oranz kollane roheline
            // helesinine tumesinine lilla roosa pruun must ja valge
            Console.WriteLine("Mis on sinu lemmikvärv?:");
            string favColour = Console.ReadLine();
            if (favColour == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (favColour == "oranz")
            {
                Console.WriteLine("Kahjuks ei ole oranz saadaval");
            }
            else if (favColour == "kollane")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (favColour == "roheline")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            else if (favColour == "helesinine")
            { 
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            else if (favColour == "tumesinine")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }   
            else if (favColour == "lilla")
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            else if (favColour == "roosa")
            {
                Console.WriteLine("Kahjuks roosat anda ei ole");
            }
            else if (favColour == "pruun")
            { 
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            else if (favColour == "must")
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if(favColour == "valge")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("ei tea seda värvi");
            }
            Console.WriteLine("The colour has maybe changed!!!!!");
            
            /* ISESEISEV ÜLESANNE */

            //# Kolija kalkulaator - Kirjuta programm mis:
            //#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            //Console.WriteLine("Kas tahad mõõta ära kasti või tünni?");
            //string valik = Console.ReadLine();
            ////#    - olenevalt kasutaja sisestusest küsib ta:
            //if (valik == "tünn")
            //{

            //    //#    - - tünni jaoks:
            //    //#    - - - kas kasutaja teeb põhja raadiust (r) või põhja läbimõõtu (d):
            //    Console.WrtieLine("Kas sa tead tünni raadiust (r) või põhja läbimõõtu (d)");
            //    string rvõid = Console.ReadLine();
            //    Console.WriteLine("Sisesta see mõõt:");
            //    double mõõt = double.Parse(Console.ReadLine());
            //    if (rvõid == "d")
            //    {
            //        mõõt = mõõt / 2;
            //    }
            //    else if(rvõid != "r")
            //    {
            //        Console.WriteLine("Sisend ei ole tuttav");
            //    }

            //    //#    - - - tünni kõrgust
            //    Console.WriteLine("Kui kõrge on su tünn");
            //    int kõrgus = int.Parse(Console.ReadLine());

            //    //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
            //    Console.WriteLine("kui paks on yünni kaas?");
            //    int kaanepaksus = int.Parse(Console.ReadLine());

            //    //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
            //    double tünnipõhis = Math.PI * (mõõt * mõõt);
            //    double mahtV = tünnipõhiS * (kõrgus - kaanepaksus);
			//	  double küljepindala = tünnipõhis * kõrgus;
            //    double kogupindala = (tünnipõhis * 2) + küljepindala;
            //    Console.WriteLine($"Sinu tünn mahutab {mahtV} \nTünni küljepindala on {küljepindala} \nKogupindala aga on{kogupindala}");
			//}
			////#    - - kasti jaoks:
			//else if(valik == "kast")
			//{
			//    //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
			//    Console.WriteLine("Kas su kast on kuubik (k) või risttahukas (r)? ");
			//    string kastitüüp = Console.ReadLine();
			//    if (kastitüüp == "k")
			//    {
			//        //#    - - - - kui on kuubik, siis küsiib kasutajalt ainult küljepikkust
			//        Console.WriteLine("Sisesta kasti küljepikkus:");
			//		  double külgA = double.Parse(Console.ReadLine());
			//        double kuubik = Math.Pow(külgA, 3);
			//		  double küljepindala = (külgA * külgA) * 6;
			//        double diagonaal = külgA * Math.Sqrt(3);
			//        Console.WriteLine($"Sinu kuubik mahutab {kuubik} \nKuubiku küljepindala on {küljepindala} \nDiagonaal aga on{diagonaal}");
            //    }
			//    //#    - - - - kui on risttahukas siis küsib kasutajalt:
			//    else if (kastitüüp == "r")
			//    {
			//        //#    - - - - - pikima külje pikkust,
			//        Console.WriteLine("Mis on sinu kasti kõige pikim külg?:");
			//        double pikkkülg = double.Parse(Console.ReadLine());

			//        //#    - - - - - lühima külje pikkust ja
			//        Console.WriteLine("Mis on sinu kasti kõige lühim külg?:");
            //        double lühikekülg = double.Parse(Console.ReadLine());

			//		  //#    - - - - - kasti kõrgust
			//		  Console.WriteLine("Mis on sinu kasti kõrgus?:");
			//		  double kõrgus = double.Parse(Console.ReadLine());

			//        //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
			//		  double V = pikkkülg * lühikekülg * kõrgus;
			//		  double kogpindala = 2 * ((pikkkülg * lühikekülg) + 



















/* meetodid */

            // Meetodid on väljakutsutavad koodijupid. Meetodid teostavad tavaliselt mingeid funktsioone või tegevusi.
            // Meetodid lasevad programmeerijal taaskasutada oma eelnevalt kirjutatud koodi - write once use many times.
            // Meetodeid on kahte liiki - ühed, mis tagastavad andmeid mingisuguse töö tulemina, ja teised, mis ei tagasta
            // midagi, kuid omavad siisiki mingit tegevust.

            // Meetodi signatuur:
            // Meetodi signatuur koosneb mitmest kindlalt äramääratud omadustest, nendeks on:
            // - Juurdepääsu modifikaator mis ütleb ära, kust ja kuidas sellele meetodile juurde pääseda saab
            //   public - meetod on avalik ja kättesaadav ka teistes klassides peale selle, kus meetod ise asub.
            //   private - meetod on saadav ainult selles klassis, kus meetod ise asub.
            //   protected - meetod on saadav ainult selles klassis, kus meetod ise asub ja kõikides klassides millen on pärilus
            //               sellele klassile.
            //   internal - meetod on saadav ainult selles klassis ja ainult selles failis.
            // - Võib olla ka pandud static - meetod kuulub selle klassi juurde
            // - Tagastustüüp on modifikaator mis ütleb ära, mis tüüpi andmeid meetod tagasi annab kutsumise asukohta.
            //   Andmetüüp mida tagastada võib olla ükskõik milline liht või kombinatsioonandmetüüp, aga kui meetod ei tagasta
            //   üldse andmeid, pannakse selle asemel andmetüübiks "void".

            // 1. tüüpi meetod - ei tagasta midagi
            public static void UusMeetod() //meetodi signatuur, mis omab juurdepääsumodifikaatorit "public", "static" ütleb et
                                           //ta on selle klassi oma, tagastustüüp "void" ütleb et andmeid meie meetod ei tagasta
                                           //ning pärast meetodi omadusi on meetodi nimi "UusMeetod" peale mida on sulud, kus
                                           //parameetreid ei ole.
            {                              //pärast signatuuri on koodiplokk meetodi koodiga {}
                Console.WriteLine("Tere"); //Antud juhul meetod kuvab konsooli sõnumi.
            }
            // 2. tüüpi meetod - tagastab väärtuse
            int[] arvutatavadArvud = new int[] { 3, 67, 420 }; //Töödeldavad andmed, mis asuvad täisarvumassiivis, muutujanimega
                                                               //"arvutatavadArvud".
            public static int ArvutaKokku(int[] arvud) //Meetod, mille signatuuris on juurdepääsumodifikaator public, static
                                                       //ütleb et meetod kuulub siia klassi, tagastustüüp "int" ütleb, et
                                                       //programmis väljakutseasukohta tagastatakse täisarv, peale seda on
                                                       //meetodi nimi "ArvutaKokku" ning sulgude vahel ootab meetod täisarvumassiivi
                                                       //millele pannakse meetodi sees ajutine nimi arvud. Peale signatuuri on
                                                       //koodiplokk {} tehtava koodiga.
            {
                int summa = 0; //Tekitatakse täisarvuandmetüüpi muutuja nimega "summa", kuhu esialgu omistatakse arv 0.
                foreach (int i in arvud) //foreach tsükliga käiakse kõik täisarvumassiivi "arvud" arvud läbi
                {
                    summa += i; //ja muutujale summa lisatakse juurde, hetkel käidav element.
                }
                return summa; //pärast tsükli töö lõppu tagastatakse "return" käsu abil, muutuja summa sisu.
            }
