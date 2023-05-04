namespace SmartSchool.API.Models
{
    public class Professor
    {
        public Professor(){ }
        public Professor(int id, string nome)
        {
            this.Nome = nome;
            this.Id = id;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}
