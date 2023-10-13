using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness.Helper
{
    public class HashingHelper
    {
        public static string HashPassword(string password, string salt)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 10000);
            return Convert.ToBase64String(pbkdf2.GetBytes(32)); // Retorna un hash de 256 bits.
        }
        public static string GenerateSalt() //asegura que dos usuarios con la misma contraseña no tendran el mismo hash
        {
            var rng = new RNGCryptoServiceProvider();
            var salt = new byte[16]; 
            rng.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }

    }
}
