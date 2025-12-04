namespace InovaGlic.Models
{
    public class LeituraGlicemica
    {
        public int Id { get; set; }


        public int PacienteId { get; set; }


        public int Valor { get; set; }


        public DateTime DataHora { get; set; }


        public string Origem { get; set; }
    }
}
