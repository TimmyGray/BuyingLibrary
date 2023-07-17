using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace BuyingLibrary.AppSettings
{
    public class JWTOptions
    {
        public readonly string ISSUER;
        public readonly string AUDIENCE;
        public readonly string KEY;

        public SymmetricSecurityKey GetSymmetricKey() => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(KEY));

        //public JWTOptions(string issuer, string audience, string key)
        //{
        //    try
        //    {
        //        ISSUER = issuer;
        //        AUDIENCE = audience;
        //        KEY = key;

        //        if (ISSUER == "" || AUDIENCE == "" && KEY == "")
        //        {
        //            ISSUER = "My Issuer";
        //            AUDIENCE = "My Audience";
        //            KEY = "MySuperSymmetricJWTKey";
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        ISSUER = "My Issuer";
        //        AUDIENCE = "My Audience";
        //        KEY = "MySuperSymmetricJWTKey";

        //    }

        //}
        // Summury:
        // trulala
        public JWTOptions(IConfiguration configuration)
        {
            try
            {
                ISSUER = configuration["Issuer"];
                AUDIENCE = configuration["Audience"];
                KEY = configuration["Key"];
                Console.WriteLine("Successful jwtoptions creation");
                if (ISSUER == "" || AUDIENCE == "" && KEY == "")
                {
                    ISSUER = "My Issuer";
                    AUDIENCE = "My Audience";
                    KEY = "MySuperSymmetricJWTKey";
                }

            }
            catch (Exception)
            {

                ISSUER = "My Issuer";
                AUDIENCE = "My Audience";
                KEY = "MySuperSymmetricJWTKey";

            }
        }

    }
}
