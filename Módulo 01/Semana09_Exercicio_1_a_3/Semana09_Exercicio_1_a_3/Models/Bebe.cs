namespace Semana09_Exercicio_1_a_3.Models
{
    public class Bebe
    {
        public int Id { get; set; }

        public DateTime Data_Nascimento { get; set; }

        public decimal Peso_Nascimento { get; set; }

        public int Altura { get; set; }

        public int Id_Mae { get; set; }

        public int Id_Parto { get; set; }

        public virtual Mae Mae { get; set; }
        public virtual Parto Parto { get; set; }

    }
}
