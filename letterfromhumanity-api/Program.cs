using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using letterfromhumanityapi.Models;

namespace letterfromhumanity_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InsertData();
            CreateWebHostBuilder(args).Build().Run();
        }

        private static void InsertData()
        {
            using (var context = new ApiContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();
            }
        }


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
