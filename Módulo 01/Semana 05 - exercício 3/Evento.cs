using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratExcRegraDeNegocio
{
    internal class Evento
    {
        int qtdLugares;
        int qtdIngressosVendidos;

        public Evento()
        {
        }
        public int QtdLugares { get; set; }
        public int QtdIngressosVendidos { get; set; }

        public void IngressoVendido()
        {
            Console.WriteLine("Ingresso vendido com sucesso!!");
        }
    }

}
