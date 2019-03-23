namespace carlostorres.Model
{
    public class Avion : Vehiculo
    {
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

        public Avion () {}

        public Avion (float velocidadMaxima, float velocidadMinima, string marca, string modelo) =>
            (base.VelocidadMaxima, base.VelocidadMinima, base.Marca, base.Modelo) = (velocidadMaxima, velocidadMinima, marca, modelo);

        public void Despegar() {
        }

        public void Aterrizar() {
        }

        public void DisminuirAltura(float pie) 
        {
        }
    }
}