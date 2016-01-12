﻿using System;
using System.Linq;
using System.Reflection;
using Toolbox.Common.Helpers;

namespace Toolbox.Codetable
{
    public class CodetableDiscoveryOptions
    {
        public CodetableDiscoveryOptions(Assembly controllerAssembly = null)
        {
            if ( controllerAssembly == null )
                ControllerAssembly = FindControllerAssembly();
            else
                ControllerAssembly = controllerAssembly;
            this.Route = Routes.CodetableProviderController;
        }

        /// <summary>
        /// The route where the list of codetables can be requested (default = '/admin/codetable').
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// The assembly where the codetable controllers are defined (default = the assembly where the Startup class is found).
        /// </summary>
        public Assembly ControllerAssembly { get; private set; }

        /// <summary>
        /// Default Route = 'admin/codetable' and default Assembly is the one where the Startup class is in.
        /// </summary>
        public static CodetableDiscoveryOptions Default {  get { return new CodetableDiscoveryOptions(); } }

        private Assembly FindControllerAssembly()
        {
            var startup = ReflectionHelper.GetTypesFromAppDomain("startup");
            //if ( startup.Count() != 1 ) return;   // ToDo (SVB) :  < 1
            var controllerAssembly = startup.First().Assembly;
            return controllerAssembly;
        }
    }
}
