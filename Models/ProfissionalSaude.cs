namespace InovaGlic.Models
{
    public class ProfissionalSaude
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CRM { get; set; }

        public string Especialidade { get; set; }

        public string Email { get; set; }

        // Lista de pacientes vinculados a esse médico
        public List<Paciente> UsuariosVinculados { get; set; }
    }
}
