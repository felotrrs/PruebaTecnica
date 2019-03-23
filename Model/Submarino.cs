using carlostorres.Interfaz;

namespace carlostorres.Model

{
    public class Submarino : Vehiculo, IBitacora
    {
        private float profundidadMaxima;
        public float ProfundidadMaxima
        {
            get { return profundidadMaxima;}
            set { profundidadMaxima = value;}
        }

        public Submarino () {}

        public Submarino (float velocidadMaxima, float velocidadMinima, string marca, string modelo) =>
            (base.VelocidadMaxima, base.VelocidadMinima, base.Marca, base.Modelo) = (velocidadMaxima, velocidadMinima, marca, modelo);

        public void Sumergir(float metros) 
        {
        }

        public void MostrarDetalle(){
             Writeline ($"Profundidad maxima: {profundidadMaxima}" );
        }
    }
}