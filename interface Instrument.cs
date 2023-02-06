using System;

interface Instrument
{
    void play();
    string KEY = "До мажор";

 
}

class Guitar: Instrument
{
    int stringCount;
    public void play()
    {
        Console.WriteLine("Играет гитара, количество струн: 5");
    }

}

class Drums: Instrument
{
    int size ;
    public void play()
    {
        Console.WriteLine("Играет барабан, размером: 54");
    }
}

class Wind: Instrument
{
    int diametr;
    public void play()
    {
        Console.WriteLine("Играет труба, диаметрос: 5");
    }

    class clas
    {
        static void Main(string[] args)
        {
            Instrument[] instruments = { new Guitar { stringCount = 54 }, new Drums { size = 54 }, new Wind { diametr = 5 } };
            foreach (var instrument in instruments)
            {
                instrument.play();
            }
        }
        
    }
