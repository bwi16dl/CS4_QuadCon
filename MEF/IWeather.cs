using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    [InheritedExport(typeof(IWeather))]
    public interface IWeather
    {
        Forecast OneDay;


        internal class Forecast;

    }
}
