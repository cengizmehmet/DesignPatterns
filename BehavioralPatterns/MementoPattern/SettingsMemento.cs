using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern_Settings
{
    public class SettingsMemento
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool RememberMe { get; set; }
    }
}
