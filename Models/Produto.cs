namespace InovaGlic.Models
{
    public class Produto
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Icone { get; set; }
    }

    public class DadosSite
    {
        public string NomeEmpresa { get; set; }
        public string Slogan { get; set; }
        public List<string> Recursos { get; set; }
        public List<string> Beneficios { get; set; }
    }
}
