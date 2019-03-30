using carlostorres.Interfaz;

namespace carlostorres.Model

{
    public class Avion : Vehiculo,IBitacora
    {
        public Avion():base() {}

        public Avion (float velocidadMaxima, float velocidadMinima, string marca, string modelo) =>
            (base.VelocidadMaxima, base.VelocidadMinima, base.Marca, base.Modelo) = (velocidadMaxima, velocidadMinima, marca, modelo);
       
        private float alturaMaxima;
        public float AlturaMaxima
        {
            get { return alturaMaxima;}
            set { alturaMaxima = value;}
        }

        private float alturaMinima;
        public float AlturaMinima
        {
            get { return alturaMinima;}
            set { alturaMinima = value;}
        }

        public void Despegar() {
        }

        public void Aterrizar() {
        }
        public void DisminuirAltura(float pie) 
        {
        }
        public override void Encender(){}

        public override void Apagar(){}

        public override string ToString()
        {
            return $"{{ Marca :{this.Marca}, Modelo : {this.Modelo}, Altura maxima : {this.alturaMaxima} , Altura minima : {this.alturaMinima}}} ";
           
        }

        public  void MostrarDetalle(){
            this.ToString();
        }
    }
}