using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo.Models
{
    public class LoginResponse
    {
        public LoginResult Result { get; set; }
        public Kunde Kunde { get; set; }
    }
}
