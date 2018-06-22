using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestWeather
{
    [InheritedExport(typeof(IWeather))]
    public interface IWeather
    {
        string GetName();
        Forecast GetOneDay();
        List<Forecast> GetThreeDays();

        void SetName(string name);
        void SetOneDay(Forecast oneDay);
        void SetThreeDays(List<Forecast> threeDays);
        
        void Trigger(string printWhat);
        void StartUpdating();
    }
}
