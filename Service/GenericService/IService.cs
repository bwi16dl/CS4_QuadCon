using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Object Get(string source, string attribute);
        [OperationContract]
        void Set(string source, string attribute, Object value);
        [OperationContract]
        Object Run(string source, string method, Object[] parameters);
    }
}
