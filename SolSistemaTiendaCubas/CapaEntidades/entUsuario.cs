namespace CapaEntidades
{
    public class entUsuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set;  }
        public string tipoUsuario { get; set;  } //(Empleado, Gerente, Cliente)
        public int dni { get; set; }
        public int celular { get; set; }
        public Boolean estado { get; set; } //Habilitado o Inhabilitado

    }
}
