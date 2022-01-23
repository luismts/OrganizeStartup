using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizeStartup.Extensions
{
    public static partial class ConfigExtensions
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            // Add your services here...

            // Default method
            //builder.Services.Add();

            // Scoped objects are the same within a request, but different across different requests.
            //builder.Services.AddScoped();     

            // Singleton objects are created as a single instance throughout the application. It creates the instance for the first time and reuses the same object in the all calls.
            //builder.Services.AddSingleton();  

            // Transient objects lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.
            //builder.Services.AddTransient();  


            return builder;
        }
    }
}
