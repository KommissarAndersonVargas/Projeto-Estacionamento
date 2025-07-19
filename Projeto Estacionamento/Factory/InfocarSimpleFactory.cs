using Projeto_Estacionamento.Classes;

namespace Projeto_Estacionamento.Factory
{
    public class InfocarSimpleFactory
    {
        public static BasicParkingLot CreateCar(string placa, DateTime Time, string data, string Tempo_Permanenica)
        {
            return new Infocar(placa, Time, data, Tempo_Permanenica);
        }
    }
}
