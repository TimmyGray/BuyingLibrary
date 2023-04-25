using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.AppSettings
{
    public class ConnectionStringsOptions
    {
        public const string ConnectionStrings = "ConnectionStrings";
        public string AppUrl { get; set; } = string.Empty;
        public string ClientUrl { get;set; } = string.Empty;

    }
}
