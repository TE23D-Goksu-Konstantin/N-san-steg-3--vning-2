using System;
using System.Reflection.Metadata;

class Program
{

    static void MinMetod(string namn, int år)
    {
        Console.WriteLine(namn + " är " + år + " gammal");        
    }

    static void Main(string[] args)
    {
    MinMetod("Erland", 24);
    MinMetod("Bertil", 65);
    MinMetod("Urban", 89);
    Console.ReadLine();
    }

}