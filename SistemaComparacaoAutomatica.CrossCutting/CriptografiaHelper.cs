using System;
using System.Security.Cryptography;
using System.Text;

namespace SistemaComparacaoAutomatica.CrossCutting
{
    public class CriptografiaHelper
    {
        public static byte[] CriptografarSenha(string Senha)
        {
            return Criptografar(Senha, "osncpsktha-94iskla-32kqosnjf0493");
        }

        private static byte[] Criptografar(string texto, string salt)
        {
            while (salt.Length < 6)
            {
                salt += salt + "z";
            }
            using (var sha = SHA512.Create())
            {
                salt = Encoding.UTF8.GetString(sha.ComputeHash(Encoding.UTF8.GetBytes(salt.Substring(salt.Length - 4))));
                return sha.ComputeHash(Encoding.UTF8.GetBytes(texto + salt));
            }
        }
    }
}
