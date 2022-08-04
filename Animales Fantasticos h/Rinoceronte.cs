using System;
public class Vaca: Mamifero
{
    public string DaLeche { get; set; }
    public bool HaceMooo { get; set; }

    public Vaca() // Polimorfismo
    {
        HaceMooo = true;
    }

    public Vaca(bool haceMooo) // Polimorfismo
    {
        HaceMooo = haceMooo;
    }
    public void Mooo()
    {
        Console.WriteLine("en simples palbras animal domestico que se puede comer..");

    }

}