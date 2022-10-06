using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.Model
{
    public class Server
    { 
        public string Ip { get; set; } 
        public string Name { get; set; }
        public string Protocol { get; set; }
        public string TypeConnection { get; set; }
        public string Port { get; set; }
        public bool IsAlive { get; set; }
        public bool IsGood { get; set; }
        public bool IsBad { get; set; }
        public bool IsCat { get; set; }

    }
}
