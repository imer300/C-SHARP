using System;

public abstract class Avioticos: Metazoos
{
    public int Patas { get; set; }
    public string ColorPlumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Vuela vuelaaa, no te haaace falta equipaje, vuelaaa...");
    }
}