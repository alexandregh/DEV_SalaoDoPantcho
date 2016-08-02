using System;
using System.Text;
using System.Security.Cryptography;

namespace SalaoDoPantcho.Security.CriptographyPasswords
{
    public class CriptographyPassword
    {
        #region Implementação Métodos Segurança

        public static string CriptografarSenha(string senha)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] hashSha1 = sha1.ComputeHash(Encoding.UTF8.GetBytes(senha));
            return BitConverter.ToString(hashSha1).Replace("-", "");
        }

        #endregion
    }
}