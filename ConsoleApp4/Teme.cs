using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Teme
    {
        private double x;
        private double y;
        public Teme(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void postaviX(double x)
            //postavi==set.
        {
            this.x = x;
        }

        public void postaviY(double y)
        {
            this.y = y;
        }

        public double dohvatiX() { return this.x; }
        //dohvati==get.

        public double dohvatiY() { return this.y; }
    }
}
