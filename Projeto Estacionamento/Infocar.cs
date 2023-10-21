using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento
{
    internal class Infocar
    {
       public string Placa { get; set; }
      
       public DateTime Time { get; set; }
       public string Tempo_Permanenica { get; set; }

        public string TotalPagar { get; set; } = "ainda não calculado"; // valor

       public string Data { get; set; } // somente uma string de indicacao

        public Infocar(string placa, DateTime Time,  string data, string Tempo_Permanenica)
        {
            Placa = placa;
            this.Time = Time;
            Data = data;
            this.Tempo_Permanenica = Tempo_Permanenica; 
        }
    }
}
