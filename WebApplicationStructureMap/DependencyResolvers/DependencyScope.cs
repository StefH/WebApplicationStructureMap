using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Http.Dependencies;
using StructureMap;

namespace WebApi.StructureMap
{
    public class DependencyScope : IDependencyScope
    {
        private readonly Guid _guid;
        private readonly IContainer _container;

        public DependencyScope(IContainer container)
        {
            _guid = Guid.NewGuid();
            Debug.WriteLine("DependencyScope---" + DateTime.Now + "---" + _guid);
            _container = container;
        }

        public object GetService(Type serviceType)
        {
            Debug.WriteLine("DependencyScope / GetService" + DateTime.Now + "---" + _guid);
            return _container.GetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            Debug.WriteLine("DependencyScope / GetServices" + DateTime.Now + "---" + _guid);
            return _container.GetAllInstances(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}
