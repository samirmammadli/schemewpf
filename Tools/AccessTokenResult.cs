using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchemeWpf.Tools
{
    class AccessTokenResult
    {
        public AccessTokenResult(string username, string token, DateTime expireDate)
        {
            Username = username;
            Token = token;
            ExpireDate = expireDate;
        }

        public string Username { get; set; }
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }

        public AccessTokenResult()
        {

        }
    }
}
