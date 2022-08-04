using System;

public abstract class Acuaticos: Metazoos
{
    public int NumeroAletas { get; set; }
    public string Color { get; set; }

    public void Nadar()
    {
        Console.WriteLine("toda especie de animal en el cual avita en el agua o es parte del agua.");
    }
}