using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            Ex2();
        }

        static void Ex1()
        {
            //Un dulap are trei caracteristici: lungime, latime, inaltime.Dulapul va avea o metoda care va calcula volumul acestuia.
            //Folositi o clasa care va modela un dulap.
            // Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
            // Cele trei campuri vor fi initializate cu ajutorul constructorului
            // Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
            //Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si afisati rezultatul.
            Dulap dulap = new Dulap();
            dulap.CitesteDulap(dulap);
            dulap.AfisareDulap(dulap);
            Console.WriteLine($"Volumul dulapului este {CalzuleazaVolumDulap(dulap)}");
        }

        static int CalzuleazaVolumDulap(Dulap myDulap)
        {
            int result = myDulap.GetLungime() * myDulap.GetLatime() * myDulap.GetInaltime();
            return result;
        }
        
        static void Ex2()
        {
            //Scrieti un program care va modela un autoturism. Un autoturism va avea o marca(string), un numar de inmatriculare(string), precum si o capacitate cilindrica(int).
            //Autoturismul va avea:
            // Campurile corespunzatoare caracteristicilor autoturismului.
            // Un constructor care va initializa campurile acestuia
            // O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma: “marca, numarDeInmatriculare, capacitateCilindrica”.
            //Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii xml pentru metodele publice.
            //Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le metodele “Tipareste”
            Autoturism masina = new Autoturism();
            masina.CitesteAuto(masina);
            masina.AfisareAutoturism(masina);
            Autoturism autobus = new Autoturism();
            autobus.CitesteAuto(autobus);
            autobus.AfisareAutoturism(autobus);
        }
    }
}
