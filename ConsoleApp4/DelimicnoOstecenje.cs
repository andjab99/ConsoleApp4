using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class DelimicnoOstecenje : Fasada
    {

        private Poligon[] ostecenja;

        public DelimicnoOstecenje(string imeObjekta, string adresa, string vlasnik, double duzina, double sirina, Poligon[] ostecenja)
            : base(imeObjekta, adresa, vlasnik, duzina, sirina)
        {
            this.ostecenja = ostecenja;
        }

        public override decimal izracunajCenuPopravke()
        {
            double povrsina = izracunajPovrsinu();
            double obim = izracunajObim();
            decimal cenaTrake = izracunajCenuTrake(povrsina);
            return (decimal)povrsina * cenaFarbe + (decimal)obim * cenaTrake;
        }

        private double izracunajPovrsinu()
        {
            double ukupnaPovrsina = 0;
            for (int i = 0; i < ostecenja.Length; i++)
                //ostecenje.Length je rastojanje izmedju dve tacke.
            {
                ukupnaPovrsina += ostecenja[i].Povrsina();
                //+= "nova vrednost = prethodna vrednost + dodata vrednost".
            }
            ukupnaPovrsina = Math.Round(ukupnaPovrsina, 2);
            double ukupnaPovrsina2 = ukupnaPovrsina * Math.Pow(10, -4);
            Console.WriteLine("Ukupna povrsina ostecenog dela iznosi: " + ukupnaPovrsina + " cm²= " + ukupnaPovrsina2+ " m².");
            return ukupnaPovrsina;
        }

        private double izracunajObim()
        {
            double ukupanObim = 0;
            for (int i = 0; i < ostecenja.Length; i++)
            {
                ukupanObim += ostecenja[i].Obim();
            }
            ukupanObim = Math.Round(ukupanObim, 2);
            double ukupanObim2 = ukupanObim * Math.Pow(10, -2);
            Console.WriteLine("Ukupan obim ostecenog dela iznosi: " + ukupanObim + "cm = " + ukupanObim2 + " m.");
            return ukupanObim;
        }
    }
}
