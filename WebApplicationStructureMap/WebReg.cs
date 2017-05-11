using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;

namespace WebApplicationStructureMap
{
    public class WebReg : Registry
    {
        public WebReg()
        {
            Scan(cfg =>
            {
                cfg.Description = "WebReg !";
                cfg.TheCallingAssembly();
                cfg.WithDefaultConventions();
            });

            int xx = 0;
        }
    }
}