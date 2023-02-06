using System;


interface  Printable  {

     void Print();
}

class Book: Printable{

    public void Print()
    {
        Console.WriteLine("books");
    }
    public static void printMagazines(Printable[] printables)
    {

        foreach (Printable printable in printables)
        {
            if (printable is Book)
            {
                Console.WriteLine("print only boobs");
            }
        }

    }
}


class Magazine: Printable
{

    public void Print()

    {
        Console.WriteLine(" Magazine");
    }
    public static void printMagazines(Printable[] printables)
    {

        foreach (Printable printable in printables)
        {
            if (printable is Book)
            {
                Console.WriteLine("print only Magazines");
            }
        }

    }
}

class clas
{
    static void Main(string[] args) {
        Printable[] printables = new Printable[] { new Book(), new Magazine() };
        foreach (Printable printable in printables) {
            printable.Print();
        }
        Book.printBooks(printables);
        Magazine.printMagazines(printables);
    }
}