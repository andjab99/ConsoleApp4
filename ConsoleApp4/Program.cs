//Program treba da izracunava cenu popravke fasade, u zavisnosti od tipa ostecenja.
//Korisnik, u zavisnosti od toga da li mu odgovara cena,salje zahtev za popravku.

//Using System je biblioteka programa, obavezan deo.
using System;

//Namespace sluzi za imenovanje datoteke
namespace ConsoleApp4
{
    class Program    //Class je klasa programa koja sadrzi podatke i metode.
    {
        static void Main(string[] args) //Main predstavlja metodu.
        {
        start:
            Console.WriteLine("Unesite tip objekta: "); //Console je klasa biblioteke System, a WriteLine je metoda.
            string imeObjekta = Console.ReadLine();

            Console.WriteLine("Unesite adresu: ");
            string adresa = Console.ReadLine(); //ReadLine je metoda koja cita sta korisnik unosi sa tastature.

            Console.WriteLine("Unesite ime i prezime: ");
            string vlasnik = Console.ReadLine();// Vlasnik je varijabla.

            Console.WriteLine("Unesite duzinu zida u centimetrima: ");
            double duzina = Convert.ToDouble(Console.ReadLine());//Uneti podaci se konvertuju u tip double.

            Console.WriteLine("Unesite visinu zida u centimetrima: ");
            double sirina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite tip ostecenja (0 - Totalno ostecenje, 1 - Delimicno ostecenje): ");
            int status = Convert.ToInt32(Console.ReadLine());//Konverzija u intiger.

            Fasada fasada = null; //fasada je promenljiva koja ne pokazuje ni na kakav objekat.
            switch (status) //Naredba switch razmatra slucajeve 0 i 1, status je stanje u kom se nalazi fasada.
            {
                case 0:
                    fasada = new TotalnoOstecenje(imeObjekta, adresa, vlasnik, duzina, sirina);
                    //kreiramo objekat potklase TotalnoOstecenje.
                    break;
                case 1:
                    Console.WriteLine("Unesite broj ostecenja: ");
                    int brOstecenja = Convert.ToInt32(Console.ReadLine());
                    Poligon[] ostecenja = new Poligon[brOstecenja];
                    //Poligon[] je niz ostecenja i na ovoj liniji koda
                    //instanciramo broj elemenata koji jednak broju ostecenja.

                    for (int i = 0; i < brOstecenja; i++)
                    {
                        Console.WriteLine("Unesite broj tacaka za " + (i + 1) + ". ostecenje: ");
                        //(i+1) ispisuje redom redni broj ostecenja.
                        int brTacaka = Convert.ToInt32(Console.ReadLine());

                        if (brTacaka < 3 || brTacaka > 9) 
                        {
                            Console.WriteLine("Greska! Minimalan broj tacaka za ostecenje je 3, a maksimalan je 9.");
                            return;
                        }

                        Teme[] temena = new Teme[brTacaka];//Teme[] je niz temena i na ovoj liniji koda
                                                           //instanciramo broj elemenata koji jednak broju tacaka.
                        for (int j = 0; j < brTacaka; j++)
                        {
                            Console.WriteLine("Unesite X[" + j + "]: ");
                            //(+j+) ispisuje redom koordinate, npr. x0, x1...
                            int x = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Unesite Y[" + j + "]: ");
                            int y = Convert.ToInt32(Console.ReadLine());

                            temena[j] = new Teme(x, y);//Temenima dodeljujemo redom koordinate x,y.
                        }

                        ostecenja[i] = new Poligon(temena);
                    }
                    fasada = new DelimicnoOstecenje(imeObjekta, adresa, vlasnik, duzina, sirina, ostecenja);
                    break;
                default:
                    Console.WriteLine("Nepravilno unesen status ostecenja.");
                    return;
            }

            decimal cenaPopravke = fasada.izracunajCenuPopravke();
            cenaPopravke = Math.Round(cenaPopravke, 2);
            Console.WriteLine("Cena popravke iznosi: " + cenaPopravke + "din.");

            Console.WriteLine("Da li zelite da posaljete zahtev? Unesite broj (2 - Ne, 3 - Da):");
            int zahtev = Convert.ToInt32(Console.ReadLine());

            switch (zahtev)
            {

                case 2: Console.WriteLine("Vas zahtev nije proslat.");
                    break;
                case 3: Console.WriteLine("Vas zahtev je proslat.");
                        Console.WriteLine("Sledeci podaci su prosledjeni firmi:");
                        Console.WriteLine("Tip objekta: " + imeObjekta);
                        Console.WriteLine("Adresa: " + adresa);
                        Console.WriteLine("Ime i prezime: " + vlasnik);
                        Console.WriteLine("Cena popravke: " + cenaPopravke + "din");
                    break;
                default: Console.WriteLine("Error.");
                    break;
            }
            Console.WriteLine("Da li zelite da se vratite na pocetak: (7 - DA , 8 - NE)");
            int izlaz = Convert.ToInt32(Console.ReadLine());

            switch (izlaz)
            {
                case 7:
                    goto start;
                case 8:
                    break;
                default:
                    break;
            }
        }
    }
}
