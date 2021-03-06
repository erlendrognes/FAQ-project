﻿using FAQ.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;


namespace Nettbutikk_FAQ
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Database.SetInitializer<DatabaseContext>(new FAQ.Models.DBInitializer());

            using (var db = new DatabaseContext())
            {
                {
                    db.Database.Initialize(true);
                }
            }
        }
    }
}
