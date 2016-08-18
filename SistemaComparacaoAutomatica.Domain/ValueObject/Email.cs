using System;
using System.Text.RegularExpressions;

namespace SistemaComparacaoAutomatica.Domain.ValueObject
{
    public class Email
    {
        public const int EnderecoMaxLength = 254;
        public string Endereco { get; private set; }


        //Construtor EntityFramework
        protected Email()
        {

        }

        public Email(string endereco)
        {
            if (!IsValidEmail(endereco))
            {
                throw new Exception("E-mail inválido!");
            }

            this.Endereco = endereco;
        }

        public bool IsValidEmail(string strIn)
        {
            bool invalid = false;
            if (String.IsNullOrEmpty(strIn))
            {
                return false;
            }

            if (invalid)
            {
                return false;
            }

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

    }
}
