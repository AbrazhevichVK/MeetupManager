using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MeetupManager.Security
{
    public class AuthOptions
    {
        public const string ISSUER = "MeetupServer"; 
        public const string AUDIENCE = "MeetupClient"; 
        const string KEY = "meetupsecret_secretkey";   
        public const int LIFETIME = 60; 
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
