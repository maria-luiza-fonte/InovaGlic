namespace InovaGlic.Models
{
    public class Recurso
    {
        public int RecursoId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Icone { get; set; }

        public Recurso(int recursoId, string titulo, string descricao, string icone)
        {
            this.RecursoId = recursoId;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Icone = icone;

        }
    }
}
