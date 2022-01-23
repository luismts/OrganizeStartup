using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if __ANDROID__
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif

namespace OrganizeStartup.Extensions
{
    public static partial class ConfigExtensions
    {
        public static MauiAppBuilder RegisterHandlers(this MauiAppBuilder builder)
        {
            RegisterMappers();

            return builder.ConfigureMauiHandlers(handlers =>
            {
                // Your handlers here...
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
                //handlers.AddHandler(typeof(MyEntry), typeof(MyEntryHandler));
            });
        }

        private static void RegisterMappers()
        {
            // For a large mapper its better to create a separete file for it.
            Microsoft.Maui.Handlers.EntryHandler.EntryMapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
#if __ANDROID__
                handler.NativeView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#endif
            });
        }
    }
}
