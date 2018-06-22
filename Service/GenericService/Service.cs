using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF;

namespace Service
{
    public class Service : IService
    {
        public Object Get(string source, string attribute)
        {
            
        }

        public object Run(string source, string method, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Set(string source, string attribute, object value)
        {
            throw new NotImplementedException();
        }
    }
}
