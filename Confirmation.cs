using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400068
{
    internal class Confirmation
    {
        public string En { get; set; }
        public string Id { get; set; }
        public void Confirmation() { }
        public void Confirmation(string en, string id) { 
            En = en;
            Id = id;
        }
    }
}
