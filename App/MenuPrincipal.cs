using System;
using static System.Console;
using System.Collections.Generic;
using carlostorres.Model;

namespace carlostorres.App
{
    public class MenuPrincipal
    {
        public void MostrarMenu () {
            int opcion = 100;
            do {
                try {
                    WriteLine ("1. Crear objeto Avión");
                    WriteLine ("2. Crear objeto Submarino");
                    WriteLine ("3. Mostrar información de los aviones");
                    WriteLine ("4. Mostrar información de los submarinos");
                    WriteLine ("0. Salir");
                    WriteLine ("Ingrese su opcion ==>");
                    string valor = ReadLine ();
                    if (EsNumero(valor) == true){
                        opcion = Convert.ToInt16 (valor);
                    }
                    if (opcion == 1) {
                        RegistrarAvion (opcion);
                    }else if (opcion == 2) {
                        RegistrarSubmarino (opcion);
                    } else if (opcion == 3) {
                        MostrarAvionesForEach (); //Ejecuta metodo del ciclo
                    }  else if (opcion == 4) {
                        MostrarSubmarinosForEach ();
                    } 
                } catch (OpcionMenuException e) {
                    WriteLine(e.Message);
                }
            } while (opcion != 0);
        }

        public void RegistrarAvion () {

        }
        
        public void RegistrarSubmarino(){

        }

        public void MostrarAvionesForEach(){

        }

        public void MostrarSubmarinosForEach (){

        }
    }
}