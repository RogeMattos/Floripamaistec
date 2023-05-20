namespace Semana09_Exercicio_1_a_3.Models
{
    public class Mae
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public int Telefone { get; set; }
        public DateTime Data_Nascimento { get; set; }

        public virtual ICollection<Bebe> Bebes { get; set; }
    }
}
