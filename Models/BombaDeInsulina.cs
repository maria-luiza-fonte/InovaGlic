namespace InovaGlic.Models
{
    public class BombaDeInsulina
    {
        public int Id { get; set; }

        // Relacionamento simples: id do paciente dono da bomba
        public int PacienteId { get; set; }

        public string NumeroSerie { get; set; }

        public string Modelo { get; set; }

        public DateTime DataAtivacao { get; set; }

        public DateTime UltimaSincronizacao { get; set; }
    }
}
