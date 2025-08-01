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

        public static void PaymentLogic(BasicParkingLot car)
        {
            if (GlobalVariables.difference.Hours > 0 && GlobalVariables.difference.Hours <= 1)
            {

                car.TotalPagar = " Total a pagar 3 $";

            }
            else if (GlobalVariables.difference.Hours > 1 && GlobalVariables.difference.Hours <= 2)
            {

                car.TotalPagar = " Total a pagar 5 $";

            }

            else if (GlobalVariables.difference.Hours > 2 && GlobalVariables.difference.Hours <= 3)
            {

                car.TotalPagar = " Total a pagar 7 $";
            }
            else if (GlobalVariables.difference.Hours > 3 && GlobalVariables.difference.Hours <= 4)
            {

                car.TotalPagar = " Total a pagar 10 $";
            }
            else if (GlobalVariables.difference.Hours > 4 && GlobalVariables.difference.Hours <= 5)
            {

                car.TotalPagar = " Total a pagar 13 $";
            }
            else
            {
                car.TotalPagar = " Total a pagar 20 $";
            }
        }
    }
}
