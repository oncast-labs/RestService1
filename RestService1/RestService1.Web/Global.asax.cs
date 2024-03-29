﻿using System;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;
using RestService1.Service;

namespace RestService1.Web
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            // Edit the base address replacing the "SampleService" string below
            RouteTable.Routes.Add(new ServiceRoute("SampleService",
                new WebServiceHostFactory(), typeof(SampleService)));
        }
    }
}
