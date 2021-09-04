using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class TwoFactorAuthenticationViewModel
    {
        //login
        public string Code { get; set; }
        
        //register
        public string Token { get; set; }

        public string QRCodeUrl { get; set; }
    }
}
