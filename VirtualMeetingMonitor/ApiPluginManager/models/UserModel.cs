using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualMeetingMonitor.ApiPluginManager.models
{
    public class UserModel
    {

        private string password = "";
        public string Email { get; set; }

        public string Password { get => password; set => password = value; }

        public string Name { get; set; }
        public int Id { get; set; }
        public string Rank { get; set; }

        public string Token { get; set; }

        public bool Status { get; set; }

        public UserModel()
        {

        }
        public UserModel(string token)
        {
            Token = token;
        }
        
    }
}
