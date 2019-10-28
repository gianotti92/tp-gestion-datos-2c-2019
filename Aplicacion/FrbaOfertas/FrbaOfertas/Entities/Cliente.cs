namespace FrbaOfertas.Entities
{
    public class Cliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public Direccion direccion { get; set; }
        public string fechaNac { get; set; }

        public string usuario { get; set; }
    }
}