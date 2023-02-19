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
       public int Hora_Entrada { get; set; }
       
       public int min { get; set; }
       
       public string Tempo_Permanenica { get; set; } 

       public string TotalPagar { get; set; }

       public string Data { get; set; }


        public Infocar(string placa, int Hora_Entrada, int min, string Tempo_Permanenica, string Data)
        {
            this.Data = Data;
            this.Placa = placa;
            this.Hora_Entrada = Hora_Entrada;
            this.min = min;
            this.Tempo_Permanenica = Tempo_Permanenica;
           
        }

    }
}
