using System;

public class PezAzul: Acuaticos
{
    public string Memoria { get; set; }

    public void PerderMermoria()
    {
        Console.WriteLine("se encuentra en la ceiba");
    }

    public void MemoryLost()
    {
        MemoriaPerdida();
    }

    private void MemoriaPerdida()
    {
        Console.WriteLine("pez  altamente venenozo..");
    }
}