using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Leon l = new Leon();
            Console.WriteLine("especimen");
            Console.WriteLine("- Leon -");
            Console.WriteLine("especimen");
            l.Nombre = "Leon";
            l.Patas = 4;
            l.Pelaje = "Melena larga, cafe oscura";
            l.Raza = "Africana";
            l.Comer();
            l.Caminar();
            l.Rugir();
            l.EsFurioso = true;

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.Pelaje);
            Console.WriteLine(l.Raza);         

            Console.WriteLine();

            Vaca v = new Vaca();
            Console.WriteLine("especimen");
            Console.WriteLine("- Vaca -");
            Console.WriteLine("especimen");
            v.Nombre = "Vaca";
            v.Patas = 4;
            v.Comer();
            v.HaceMooo = true;
            v.Caminar();

            Console.WriteLine(v.Nombre);
            Console.WriteLine(v.Patas);

            Console.WriteLine();

            Condor c = new Condor();
            Console.WriteLine("especimen");
            Console.WriteLine("- Condor -");
            Console.WriteLine("especimen");
            c.Nombre = "Condor ave rapiña";
            c.Patas = 2;
            c.Incubacion = 30;
            c.ColorPlumaje = "Normalmente Pelon en la cabeza y de plumaje negro";
            c.Volar();
            c.Comer();
            c.Hacerreir();

            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Incubacion);
            Console.WriteLine(c.Patas);
            Console.WriteLine(c.ColorPlumaje);

            Console.WriteLine();

            PapaGallo P = new PapaGallo();
            Console.WriteLine("--especimen--");
            Console.WriteLine("- Puma  -");
            Console.WriteLine("--especimen--");
            

            Console.WriteLine();

            PezAzul d = new PezAzul();
            Console.WriteLine("-especimen-");
            Console.WriteLine("- Pez leon -");
            Console.WriteLine("-especimen-");
            d.Nombre = "pez leon";
            d.NumeroAletas = 2;
            d.Comer();
            d.Nadar();
            d.Color = "pez con espinas venenozas de apariencia a rallas";
            d.PerderMermoria();
            d.MemoryLost();

            Console.WriteLine(d.Nombre);
            Console.WriteLine(d.NumeroAletas);
            Console.WriteLine(d.Color);

            Tiburon t = new Tiburon();
            Console.WriteLine("-especimen--");
            Console.WriteLine("- Tiburon -");
            Console.WriteLine("-especimen--");
            t.Nombre = "Tiburon";
            t.NumeroAletas = 2;
            t.Comer();
            t.Nadar();
            t.Color = "Gris con Blanco";
 
            Console.WriteLine(t.Nombre);
            Console.WriteLine(t.NumeroAletas);
            Console.WriteLine(t.Color);

            }
        }
}