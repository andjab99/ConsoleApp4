using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Poligon
    {
        private Teme[] temena;
        public Poligon(Teme[] temena)
        {
            this.temena = temena;
        }

        public void postaviTemena(Teme[] temena)
        //Metoda postaviTemena postavlja koordinate tacke (definisana temena) u niz Teme[].
        {
            this.temena = temena;
        }

        public Teme[] dohvatiTemena()
        {
            return this.temena;
        }

        public double Obim()
        {
            int n = temena.Length;
            //n je rastojanje izmedju dve tacke.
            double o = 0;
            for (int i = 0; i < n - 1; i++)
            {
                Teme t1 = temena[i];
                Teme t2 = temena[i + 1];
                o += Math.Sqrt(Math.Pow(t1.dohvatiX() - t2.dohvatiX(), 2) + Math.Pow(t1.dohvatiY() - t2.dohvatiY(), 2));
                //Ako imamo samo 1 ostecenje na fasadi, sa minimanim brojem tacaka 3.
            }
            o += Math.Sqrt(Math.Pow(temena[0].dohvatiX() - temena[n - 1].dohvatiX(), 2) + Math.Pow(temena[0].dohvatiY() - temena[n - 1].dohvatiY(), 2));
            return o;
            //Ukoliko korisnik unese da ima vise od 1 ostecenja, obimi svih ostecenja se sabiraju.
        }

        public double Povrsina()
        {
            int n = temena.Length;
            double p = 0;
            for (int i = 0; i < n - 1; i++)
            {
                p += (temena[i].dohvatiX() * temena[i + 1].dohvatiY() - temena[i + 1].dohvatiX() * temena[i].dohvatiY())
                    - (temena[n - 1].dohvatiX() * temena[0].dohvatiY() - temena[0].dohvatiX() * temena[n - 1].dohvatiY());
            }
            p = Math.Abs(p) / 2;
            return p;
        }

    }
}
