using Microsoft.Owin;
using Owin;
using RedisRestAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(RedisRestAPI.Startup))]

namespace RedisRestAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR<MyConnection>("/echo/{*operation}");
        }
    }
}