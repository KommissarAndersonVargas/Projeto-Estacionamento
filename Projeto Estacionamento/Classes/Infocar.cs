using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento.Classes
{
    internal class Infocar : BasicParkingLot
    {
        public Infocar(string placa, DateTime Time, string data, string Tempo_Permanenica)
        {
            Placa = placa;
            this.Time = Time;
            Data = data;
            this.Tempo_Permanenica = Tempo_Permanenica;
        }

        public static BindingList<Infocar> infocarsList = new BindingList<Infocar>();
    }
}
