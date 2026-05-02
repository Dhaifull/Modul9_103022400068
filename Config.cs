using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400068
{
    internal class Config
    {
        public string Lang { get; set; }
        public Transfer Transfer { get; set; }
        public Confirmation confirmation { get; set; }
        public List<string> Methods { get; set; }
        

    }
    public void Config() { }
        public void Config(string lang, Transfer transfer, Confirmation confirmation, List<string> methods)
        {
            Lang = lang;
            Transfer = transfer;
            this.confirmation = confirmation;
            Methods = methods;
        }
    }
}
