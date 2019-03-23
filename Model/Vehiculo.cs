namespace carlostorres.Model
{
    public abstract class Vehiculo
    {
        private float velocidadMaxima;
        public float VelodidadMaxima
        {
            get { return velocidadMaxima;}
            set { velocidadMaxima = value;}
        }

        private float velocidadMinima;
        public float VelodidadMinima
        {
            get { return velocidadMinima;}
            set { velocidadMinima = value;}
        }

        private string marca;
        public string Marca
        {
            get { return marca;}
            set { marca = value;}
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo;}
            set { modelo = value;}
        }

        public void Encender() 
        {
        }
        
        public void Apagar() 
        {
        }
    }    
}