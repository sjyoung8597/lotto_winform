using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Model
{
    public class LoginInfo
    {
        public string id { get; set; }
        public int selected { get; set; }

        public LoginInfo() { }

        public LoginInfo(string id, int selected)
        {
            this.id = id;
            this.selected = selected;
        }
    }
}
