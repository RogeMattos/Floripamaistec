namespace Semana09_Exercicio_1_a_3.Models
{
    public class Parto
    {
        public int Id { get; set; }
        public int Id_Medico { get; set; }
        public DateTime DData_Parto { get; set; }
        public DateTime Horario_Parto { get; set; }

        public virtual Medico Medico { get; set; }

        public virtual ICollection<Bebe>? Bebes { get; set; }
    }
}
