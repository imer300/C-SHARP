using System;

public class Condor: Avioticos
{
    public string Comportamiento { get; set; }
    public int Incubacion { get; set; }

    public void Hacerreir()
    {
        Console.WriteLine("Condor de rapiña");
    }
    

}