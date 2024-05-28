using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace ShortingLinks;

public static class TokenGenerator
{   
    public static string GenerateRandomKey(int keyLength)
    {
        using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        {
            byte[] key = new byte[keyLength];

            rng.GetBytes(key);

            string keyString = BitConverter.ToString(key).Replace("-", "");

            return keyString;
        }
    }

}