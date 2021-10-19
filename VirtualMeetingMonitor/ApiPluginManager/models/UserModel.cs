using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualMeetingMonitor.ApiPluginManager.models
{
    public class UserModel
    {
        public delegate void Notify();

        public event Notify OnLoginSucess;

        public event Notify OnLoginError;

        public event Notify OnLoginLogout;


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
            OnLoginSucess.Invoke();
        }

     
        public void Logout()
        {
            Token = "";
            OnLoginLogout.Invoke();
        }
        
    }
}
