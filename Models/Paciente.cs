namespace InovaGlic.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        //(texto)
        public string SenhaHash { get; set; }

        public DateTime DataNascimento { get; set; }


        public string TipoDiabetes { get; set; }

        // Peso em kg
        public double Peso { get; set; }

        // Altura em metros
        public double Altura { get; set; }
    }
}
