using System;
using static System.Console;
using System.Collections.Generic;
using carlostorres.Model;

namespace carlostorres.App
{
    public class MenuPrincipal
    {
        private List<Vehiculo> lista = new List<Vehiculo>();
        public void MostrarMenu()
        {
            int opcion = 100;
            do
            {
                    WriteLine("1. Crear objeto Avión");
                    WriteLine("2. Crear objeto Submarino");
                    WriteLine("3. Mostrar información de los aviones");
                    WriteLine("4. Mostrar información de los submarinos");
                    WriteLine("0. Salir");
                    WriteLine("Ingrese su opcion ==>");
                    string valor = ReadLine();
                    if (EsNumero(valor) == true)
                    {
                        opcion = Convert.ToInt16(valor);
                    }
                    if (opcion == 1)
                    {
                        RegistrarAvion();
                    }
                    else if (opcion == 2)
                    {
                        RegistrarSubmarino();
                    }
                    else if (opcion == 3)
                    {
                        MostrarAvionesForEach(); //Ejecuta metodo del ciclo
                    }
                    else if (opcion == 4)
                    {
                        MostrarSubmarinosForEach();
                    }
                
            } while (opcion != 0);
        }

        public Boolean EsNumero(string valor) {
            Boolean resultado = false;
                int numero = Convert.ToInt16(valor);
                resultado = true;
            return resultado;
        }

        public void RegistrarAvion()
        {
            Vehiculo nuevo = new Avion();
            WriteLine("Ingrese la marca: ");
            nuevo.Marca = Console.ReadLine();
            WriteLine("Ingrese el modelo: ");
            nuevo.Modelo = Console.ReadLine();
            WriteLine("Ingrese la velocidad maxima: ");
            nuevo.VelocidadMaxima = Convert.ToSingle(ReadLine());
            WriteLine("Ingrese la velocidad minima: ");
            nuevo.VelocidadMinima = float.Parse(ReadLine());
            WriteLine("Ingrese la altura maxima: ");
            ((Avion)nuevo).AlturaMaxima = float.Parse(ReadLine());
            lista.Add(nuevo);
            WriteLine("Registro almacenado!");
            ReadKey();

        }

        public void RegistrarSubmarino()
        {
            Submarino nuevo = new Submarino();
            WriteLine("Ingrese la marca: ");
            nuevo.Marca = Console.ReadLine();
            WriteLine("Ingrese el modelo: ");
            nuevo.Modelo = Console.ReadLine();
            WriteLine("Ingrese la velocidad maxima: ");
            nuevo.VelocidadMaxima = Convert.ToSingle(ReadLine());
            WriteLine("Ingrese la velocidad minima: ");
            nuevo.VelocidadMinima = float.Parse(ReadLine());
            WriteLine("Ingrese la profundidad maxima: ");
            ((Submarino)nuevo).ProfundidadMaxima = float.Parse(ReadLine());
            lista.Add(nuevo);
            WriteLine("Registro almacenado!");
            ReadKey();
        }

        public void MostrarAvionesForEach()
        {
            foreach (Vehiculo elemento in lista)
            {
                if (elemento.GetType() == typeof(Avion))
                {
                    WriteLine(elemento.ToString());
                }
            }

        }

        public void MostrarSubmarinosForEach()
        {
            foreach (Vehiculo elemento in lista)
            {
                if (elemento.GetType() == typeof(Submarino))
                {
                    WriteLine(elemento.ToString());
                }
            }
        }


    }
}