using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestWeather;

namespace WeatherService
{
    [ServiceContract]
    public interface IWeather
    {
        [OperationContract]
        string GetName();
        [OperationContract]
        Forecast GetOneDay();
        [OperationContract]
        List<Forecast> GetThreeDays();

        [OperationContract]
        void SetName(string name);
        [OperationContract]
        void SetOneDay(string oneDayString);
        [OperationContract]
        void SetThreeDays(List<string> threeDays);

        void Trigger(string printWhat);
    }
}
