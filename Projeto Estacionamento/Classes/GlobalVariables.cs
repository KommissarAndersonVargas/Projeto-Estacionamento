using System;

namespace Projeto_Estacionamento.Classes
{
    public static class GlobalVariables
    {
        public static DateTime arriveTime;  

        public static DateTime leftHour; 

        public static TimeSpan difference; 

        public static DateTime TimeNow = DateTime.Now; 

        public static string? plot;

        public static int arriveHour; 

        public static int arriveMin; 

        public static int leftTimeHour;

        public static int leftMin; 

        public static BasicParkingLot? car;

        public static List<TimeSpan>? timeSpanList = new List<TimeSpan>();

        public static List<string> filterValues = new List<string>();
    }
}
