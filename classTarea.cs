namespace tareaT8
{
    class Tarea
    {
        private int id;
        private string? descripcion;
        private int  duracion;

        public int Id { get => id; set => id = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
    }
    
}