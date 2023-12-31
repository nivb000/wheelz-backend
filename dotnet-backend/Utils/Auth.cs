﻿using System.Security.Cryptography;
using System.Text;

namespace dotnet_backend.Utils
{
    public class Auth
    {
        public static string HashPassword(string password)
        {
            var sha = SHA256.Create();
            var asByteArray = Encoding.Default.GetBytes(password);
            var hashedPassword = sha.ComputeHash(asByteArray);
            return Convert.ToBase64String(hashedPassword);
        }

        public const string AdminUserClaimName = "IsAdmin";
        public const string AdminUserPolicyName = "requireAdmin";
    }
}
