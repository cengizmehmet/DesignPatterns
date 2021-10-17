using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern_Settings
{
    public class Settings
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool RememberMe { get; set; }

        public SettingsMemento Backup()
        {
            SettingsMemento settingsMemento = new SettingsMemento
            {
                UserName = this.UserName,
                Password = this.Password,
                Email = this.Email,
                RememberMe = this.RememberMe
            };
            return settingsMemento;
        }

        public void GetDefaultSettings(SettingsMemento settingsMemento)
        {
            this.UserName = settingsMemento.UserName;
            this.Password = settingsMemento.Password;
            this.Email = settingsMemento.Email;
            this.RememberMe = settingsMemento.RememberMe;
        }

        public string Display()
        {
            return string.Format("UserName: {0} Password: {1} Email: {2} RememberMe: {3}", this.UserName, this.Password, this.Email, this.RememberMe.ToString());
        }
    }
}
