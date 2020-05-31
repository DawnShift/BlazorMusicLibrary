using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreBE.ApplicationConfig
{
    public class AppConfig
    {
        public ConnectionString ConnectionString { get; set; }
        public App App { get; set; }
    }
    public class ConnectionString
    {
        public string Default { get; set; }
    }
    public class App
    {

    }
}
