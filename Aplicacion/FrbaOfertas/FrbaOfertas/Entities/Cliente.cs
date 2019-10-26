namespace FrbaOfertas.Entities
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string mail { get; set; }
        public string telefono { get; set; }
        public Direccion direccion { get; set; }
        public string fechaNac { get; set; } 
    }
}