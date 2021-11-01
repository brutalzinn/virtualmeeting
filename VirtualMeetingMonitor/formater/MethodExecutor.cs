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
        public Func<string,object> MethodCustom { get; set; }

        public bool IsCustom { get; set; }


        // public Action Method { get; set; }
        public MethodExecutor(string identificator, List<MethodExecutor> list, Func<string> method)
        {
            Identificator = identificator.ToUpper();
            Method = method;
            IsCustom = false;
            list.Add(this);
        }

        public MethodExecutor(string identificator, List<MethodExecutor> list, Func<string,object> method)
        {
            Identificator = identificator;
            MethodCustom = method;
            IsCustom = true;
            list.Add(this);
        }



    }
}
