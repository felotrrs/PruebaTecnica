using carlostorres.Interfaz;
using System;

namespace carlostorres.Model

{
    public class Submarino : Vehiculo, IBitacora
    {
        
        public Submarino () {}

        public Submarino (float velocidadMaxima, float velocidadMinima, string marca, string modelo) =>
            (base.VelocidadMaxima, base.VelocidadMinima, base.Marca, base.Modelo) = (velocidadMaxima, velocidadMinima, marca, modelo);

        private float profundidadMaxima;
        public float ProfundidadMaxima
        {
            get { return profundidadMaxima;}
            set { profundidadMaxima = value;}
        }

        public void Sumergir(float metros) 
        {
        }

        public override void Encender(){}

        public override void Apagar(){}

        public override string ToString()
        {
            return $"{{ Marca :{this.Marca}, Modelo : {this.Modelo}, Profundidad maxima : {this.profundidadMaxima} }} ";
           
        }

        public  void MostrarDetalle(){
            this.ToString();
        }
    }
}