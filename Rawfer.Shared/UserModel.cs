using System;
using System.Collections.Generic;
using System.Text;

namespace Rawfer.Shared
{
    public class UserModel
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
    }

    public class ErrorsModel
    {
        public string[] username { get; set; }
        public string[] email { get; set; }
        public string[] password { get; set; }
        public string[] title { get; set; }
        public string[] body { get; set; }
        public string[] description { get; set; }
        public string[] emailOrPassword { get; set; }
    }
}
