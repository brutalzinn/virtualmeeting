using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.formater
{
   public class MethodExecutor
    {
        public string Identificator { get; set; }
        public Func<string> Method  { get; set;} 

       // public Action Method { get; set; }
        public MethodExecutor(string identificator, List<MethodExecutor> list, Func<string> method)
        {
            Identificator = identificator;
            Method = method;
            list.Add(this);
        }

      

    }
}
