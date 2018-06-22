using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WeatherService
{
    public class Weather : IWeather
    {


        string GetName() { WeatherConnectors.Find(); }
        Forecast GetOneDay();
        List<Forecast> GetThreeDays();

        void SetName(string name);
        void SetOneDay(string oneDayString);
        void SetThreeDays(List<string> threeDays);

        void Trigger(string printWhat);
    }
}
