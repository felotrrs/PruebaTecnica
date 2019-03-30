using System;
using static System.Console;
using carlostorres.Model;

namespace carlostorres.Interfaz
{
    public interface IBitacora
    {
        void MostrarDetalle (){
             WriteLine(elemento.ToString());
        }
         
    }
}