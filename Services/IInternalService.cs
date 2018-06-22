using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Services
{
    [ServiceContract]
    public interface IInternalService
    {
        [OperationContract]
        GenericObject Get(string actor, string attribute);
        [OperationContract]
        void Set(string actor, string attribute, GenericObject value);
        [OperationContract]
        void Run(string actor, string action, GenericObject parameters);
    }
}
