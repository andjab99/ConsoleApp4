using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public abstract class Fasada
    {
        protected string imeObjekta;
        protected string adresa;
        protected string vlasnik;
        protected double duzina;
        protected double sirina;
        protected decimal cenaFarbe;

        public Fasada(string imeObjekta, string adresa, string vlasnik, double duzina, double sirina)
        {
            this.imeObjekta = imeObjekta; //uzimamo uneti podatak iz imeObjekta i smestamo ga u imeObjekta.
            this.adresa = adresa;
            this.vlasnik = vlasnik;
            this.duzina = duzina;
            this.sirina = sirina;
            this.cenaFarbe = 0.01499M;
        }

        public abstract decimal izracunajCenuPopravke(); 
        //Apstraktna metoda klase fasada.

        public decimal izracunajCenuTrake(double povrsina)
        {
            if (povrsina < 10000)
            {
                Console.WriteLine("Cena trake iznosi 0.02 din/cm = 20 din/m.");
            }
            else
            {
                Console.WriteLine("Cena trake iznosi 0.035 din/cm = 35 din/m");

            }


            return povrsina < 10000 ? 0.02M : 0.035M;

        }
        //U slucaju da je povrsina <1m2, cena trake je 20din, suprotno je 35din.
    }
            
}  

