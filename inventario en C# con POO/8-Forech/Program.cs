﻿using System;
using System.Collections.Generic;

namespace listados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            nombres.Add("peter");
            nombres.Add("andrea");
            nombres.Add("bally");

            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(1);
            numeros.Add(5);

            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }

            List<Alumno> alumnos = new List<Alumno>();
            Alumno a = new Alumno(1, "peter");
            Alumno b = new Alumno(2, "andrea");
            Alumno c = new Alumno(3, "bally");

            alumnos.Add(a);
            alumnos.Add(b);
            alumnos.Add(c);

            foreach (var alumno in alumnos)
            {
                Console.WriteLine(alumno.Id);
            }
        }
    }
}