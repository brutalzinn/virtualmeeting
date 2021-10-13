using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.formater
{
    class MethodExecutor
    {
        public string Identificator { get; set; }
        public Func<string> Method  { get; set;} 

       // public Action Method { get; set; }
        public MethodExecutor(string identificator, Func<string> method)
        {
            Identificator = identificator;
            Method = method;
        }

      

    }
}
