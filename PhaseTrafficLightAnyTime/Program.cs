using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhaseTrafficLightAnyTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new TrafficLight(30, 40);
        }
    }

    public class TrafficLight
    {
        /// <summary>
        /// Конструктор создания светофора.
        /// </summary>
        /// <param name="timeGreenLight">Время зеленого сигнала светофора.</param>
        /// <param name="timeRedLight">Время красного сигнала светофора.</param>
        public TrafficLight(int timeGreenLight, int timeRedLight)
        {
            DateTime dateTime = DateTime.Today;
            DateTime todayWithTime = dateTime.AddHours(0).AddMinutes(5).AddSeconds(0);
            TimeGreenLight = timeGreenLight;
            TimeRedLight = timeRedLight;
            string y = FindPhase(todayWithTime);
        }
        public int TimeGreenLight { get; }
        public int TimeRedLight { get; }

        public string FindPhase(DateTime time)
        {
            DateTime startTime = DateTime.Today;
            TimeSpan timeSpan = time - startTime; //Переменная для разницы во времени
            int timeDifference = (int)timeSpan.TotalSeconds;
            int parts = timeDifference % (TimeGreenLight + TimeRedLight);
            if (parts <= TimeGreenLight)
                return $"{parts} сек. ЗЕЛЕНОГО";
            else 
            {
                int x = parts - TimeGreenLight;
                return $"{x} сек. КРАСНОГО";
            }
            
        }

    }
}
