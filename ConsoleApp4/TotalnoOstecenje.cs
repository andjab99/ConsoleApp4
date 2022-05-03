using System;
using System.Collections.Generic; //Sistemska biblioteka koja omogucava korisnicima bezbedniji unos podataka.
using System.Text;//Mora postojati u okviru apstraktne klase.

namespace ConsoleApp4
{
    class TotalnoOstecenje : Fasada
    {

        public TotalnoOstecenje(string imeObjekta, string adresa, string vlasnik, double duzina, double sirina)
            : base(imeObjekta, adresa, vlasnik, duzina, sirina) 
            //base se koristi pri pozivanju informacija iz roditeljske klase.
        { 
        } 
             
        public override decimal izracunajCenuPopravke()
            //override je kljucna red koja se koristi kao zamena za virtualnog clana definisanog u "base". 
        {
            double povrsina = duzina * sirina;
            double povrsina2 = povrsina * Math.Pow(10, -4);
            Console.WriteLine("Površina zida iznosi:  " + povrsina + "cm²" + " =" + povrsina2 + "m²");
            Console.WriteLine("Cena farbe je: 0.01499 din/cm² = 149.9 din/m² ");
            return (decimal)povrsina * cenaFarbe;
        }
    }
}
