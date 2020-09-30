using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Spa
{
    public class AuthOptions
    {
        /// <summary>
        /// Издатель токена.
        /// </summary>
        public const string ISSUER = "MyAuthServer";

        /// <summary>
        /// Потребитель токена.
        /// </summary>
        public const string AUDIENCE = "MyAuthClient";
        
        /// <summary>
        /// Ключ шифрования.
        /// </summary>
        const string KEY = "mysupersecret_secretkey!123";

        /// <summary>
        /// Время жизни токена
        /// </summary>
        public static readonly TimeSpan LIFETIME = TimeSpan.FromHours(12); 

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
