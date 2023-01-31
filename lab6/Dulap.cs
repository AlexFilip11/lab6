using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Dulap
    {

        private int lungime;
        private int latime;
        private int inaltime;
        
        public void AfisareDulap()
        {
            Console.WriteLine( $"Dulapul are lungimea de {lungime}cm, latimea de {latime}cm si inaltimea de {inaltime}cm");
        }
        /*public void CitesteDulap(Dulap myDulap)
        {
            Console.WriteLine("Lungime: ");
            lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Latime: ");
            latime = int.Parse(Console.ReadLine());
            Console.WriteLine("Inaltime: ");
            inaltime = int.Parse(Console.ReadLine());
        }*/
        public void SetLungime(int newLungime)
        {
            lungime = newLungime;
        }
        public void SetLatime(int newLatime)
        {
            latime = newLatime;
        }
        public void SetInaltime(int newInaltime)
        {
            inaltime = newInaltime;
        }
        public int GetLungime()
        {
            return lungime;
        }
        public int GetLatime()
        {
            return latime;
        }
        public int GetInaltime()
        {
            return inaltime;
        }
    }
    class Autoturism
    {
        public string marca;
        public string nrInmatriculare;
        private int capacitateCilindrica;
        public void AfisareAutoturism()
        {
            Console.WriteLine($"Autoturismul este marca {marca} cu numarul de inmatriculare {nrInmatriculare} si capacitatea cilindrica de {capacitateCilindrica}");
        }
        public void SetCapacitateaCilindrica(int newCapacitate)
        {
            capacitateCilindrica = newCapacitate;
        }

        /*public void CitesteAuto(Autoturism myAuto)
        {
            Console.WriteLine("Marca: ");
            marca = Console.ReadLine();
            Console.WriteLine("Numarul de inmatriculare: ");
            nrInmatriculare = Console.ReadLine();
            Console.WriteLine("Capacitatea cilindrica: ");
            capacitateCilindrica = int.Parse(Console.ReadLine());
        }*/
        public int GetCapacitateaCilindrica()
        {
            return capacitateCilindrica;
        }

    }
}
