using System;

public class Tiburon: Acuaticos
{
    public string Morder { get; set; }

    public void Ataque()
    {
        Console.WriteLine(" dominante en el agua territoarial");
    }

    public void Tiburonsin()
    {
        Porras();
    }

    private void Porras()
    {
        Console.WriteLine("animal acuatico  carniboro ");
    }
}