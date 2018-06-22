using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Objects;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InternalService" in both code and config file together.
    public class InternalService : IInternalService
    {
        public GenericObject Get(string actor, string attribute)
        {
            throw new NotImplementedException();
        }

        public void Run(string actor, string action, GenericObject parameters)
        {
            throw new NotImplementedException();
        }

        public void Set(string actor, string attribute, GenericObject value)
        {
            throw new NotImplementedException();
        }
    }
}
