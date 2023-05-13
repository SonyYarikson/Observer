using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Состояние сейчас: "+temperature+" градусов и "+humidity+"% влажности");
        }

        public void update(float temp, float humidity)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}
