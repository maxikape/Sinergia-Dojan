namespace SinergiaApp
{
    public class Alumnos
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; } 
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int NumeroAlumno { get; set; }
        public string FechaIngreso { get; set; }
        public int Estado { get; set; }
        public int Asistencias { get; set; }
        public int Pago { get; set; }
        public byte Foto { get; set; }
        public int FichaMedica { get; set; }
        public int Carnet { get; set; }


        // select Alumnos.IdFechaTb , FechaTb.FechaDia from Alumnos join FechaTb on  Alumnos.IdFechaTb = FechaTb.IdFecha

    }
}
