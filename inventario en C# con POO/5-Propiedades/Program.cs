using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Bryan";
            a.SegundoNombre = "Francisco";
            
            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Waldina";
            b.SegundoNombre = "Zavala";
            
            Alumno c = new Alumno(3);
            c.PrimerNombre = "Hannia";

            Alumno d = new Alumno("Billy", "Feranadez");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}
