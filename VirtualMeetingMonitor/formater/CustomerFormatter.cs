
using System.Collections.Generic;
using VirtualMeetingMonitor.formater;

namespace VirtualMeetingMonitor
{
    public class CustomerFormatter
    {

        public List<MethodExecutor> Functions { get; set; }

        public CustomerFormatter(List<MethodExecutor> functions)
        {
            Functions = functions;
        }
    }
    
    

}
