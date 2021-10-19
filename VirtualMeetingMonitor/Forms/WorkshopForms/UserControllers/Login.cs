using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.ApiPluginManager.models;

namespace VirtualMeetingMonitor.Forms.WorshopForms.UserControllers
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserModel User = new UserModel();
            User.Email = txb_email.Text;
            User.Password = txb_password.Text;

            if (Workshop.PluginManagerWeb.addUser(User))
            {
                var user = Workshop.PluginManagerWeb.User;
                label3.Text = $"DEU BOM. \n {user.Name} - {user.Id}";
            }
           
        }
    }
}
