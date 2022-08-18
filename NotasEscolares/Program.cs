using System;

namespace NotasEscolares
{
    class Program
    {
       static void Main(string[] arg)
       {
        Seguridad datos2 = new Seguridad();  
        string nombre;
        string contraseña;

        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("INGRESO AL CAMPUS VIRTUAL");
        Console.WriteLine("-------------------------");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el nombre de usuario (imer, Bily): ");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la contraseña (123):");
        contraseña = Console.ReadLine();

        bool resultado = datos2.Autenticar(nombre,contraseña);

        if (resultado == true)
        {
          Console.Clear();
          Console.WriteLine("****************************");
          Console.WriteLine("Bienvido al Sistema de notas");
          Console.WriteLine("****************************");
          Console.WriteLine("");
          Console.WriteLine("Bienvenido Docente " + nombre);
        }else
        {
          Console.WriteLine("Usuario o contraseña invalido");
          return;
        }
        Console.ReadKey();

        Notas datos = new Notas();
        string opcion = "";


        while (true)
        {
            Console.Clear();
            Console.WriteLine("::::::::::::::::::::::::::");
            Console.WriteLine("colegio tecnico INFOP");
            Console.WriteLine("::::::::::::::::::::::::::");
            Console.WriteLine("");
            Console.WriteLine("Sistema de notas escolares");
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bienvenido docente " + nombre);
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1.Lista de Docentes");
            Console.WriteLine("2.Lista de Estudiantes");
            Console.WriteLine("3.Listado Asignaturas");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Calificaciones");
            Console.WriteLine(".................................");
            Console.WriteLine("4. Ingreso de Notas del parcial");
            Console.WriteLine("5. Notas Finales");
            Console.WriteLine("6. Salir");
            Console.WriteLine("");
            Console.WriteLine("Ingrese una de las opciones: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                     datos2.ListarUsuario();
                     break;
                case "2":
                     datos.ListarEstudiantes();
                     break;
                case "3":
                     datos.ListarAsignatura();
                     break;
                case "4":
                     datos.ingresarNotas();
                     break;
                case "5":
                     datos.Notafinales();
                     break;    
                default:
                break;
            }
            if(opcion == "6")
            {
                break;
            }
         }
       }
    }
}
