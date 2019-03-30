namespace carlostorres.Model
{
    public abstract class Vehiculo
    {
        public Vehiculo() {}

        public Vehiculo(float velocidadMaxima, float velocidadMinima, string marca, string modelo){
            (VelocidadMaxima, VelocidadMinima, Marca, Modelo) = (velocidadMaxima, velocidadMinima, marca, modelo);
        }
        private float velocidadMaxima;
        public float VelocidadMaxima
        {
            get { return velocidadMaxima; }
            set { velocidadMaxima = value; }
        }

        private float velocidadMinima;
        public float VelocidadMinima
        {
            get { return velocidadMinima; }
            set { velocidadMinima = value; }
        }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public abstract void Encender();
       
        public abstract void Apagar();
        
    }
}