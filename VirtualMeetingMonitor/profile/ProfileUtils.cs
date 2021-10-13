using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMeetingMonitor.profile
{
    public  class ProfileUtils
    {
        public delegate void Notify();  // delegate

        public event Notify ProfileChanged;
        public  Profile CurrentProfile { get; set; }
        public  List<Profile> profiles = new List<Profile>();

        public void CallUpdateProfile()
        {

            ProfileChanged.Invoke();
        }




    }
}
