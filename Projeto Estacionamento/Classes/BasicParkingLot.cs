namespace Projeto_Estacionamento.Classes
{
    public abstract class BasicParkingLot
    {
        public string? Placa { get; set; }

        public DateTime Time { get; set; }

        public string? Tempo_Permanenica { get; set; }

        public string? Data { get; set; } // somente uma string de indicacao

        public string TotalPagar { get; set; } = "ainda não calculado"; // valor

    }
}
