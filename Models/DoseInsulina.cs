namespace InovaGlic.Models
{
    public class DoseInsulina
    {
        public int Id { get; set; }


        public int PacienteId { get; set; }


        public double Unidade { get; set; }


        public string Tipo { get; set; }


        public DateTime DataHora { get; set; }


        public string Observacao { get; set; }
    }
}
