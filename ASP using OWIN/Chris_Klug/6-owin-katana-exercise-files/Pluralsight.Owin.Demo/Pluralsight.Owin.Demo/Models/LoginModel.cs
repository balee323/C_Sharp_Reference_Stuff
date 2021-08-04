using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security;

namespace Pluralsight.Owin.Demo.Models
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<AuthenticationDescription> AuthProviders { get; internal set; }
    }
}