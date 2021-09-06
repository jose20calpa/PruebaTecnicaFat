﻿using IoC;
using ProyectoPruebaTecnica.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ProyectoPruebaTecnica
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.DependencyResolver = new UnityResolver(Contenedor.BuildUnityContainer());
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
