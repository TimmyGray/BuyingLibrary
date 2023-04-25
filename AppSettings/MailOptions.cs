using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.AppSettings
{
    public class MailOptions
    {
        public const string EmailSettings = "EmailSettings";
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Host { get; set; } = string.Empty;
        public string Port { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

    }
}
