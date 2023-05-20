﻿namespace Semana09_Exercicio_1_a_3.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public int Celular { get; set; }
        public string Especialidade { get; set; }

        public virtual ICollection<Parto>? Partos { get; set; }

    }
}
