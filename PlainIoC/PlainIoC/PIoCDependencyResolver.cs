using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace PlainIoC
{
    public class PIoCDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            return null;

        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}
