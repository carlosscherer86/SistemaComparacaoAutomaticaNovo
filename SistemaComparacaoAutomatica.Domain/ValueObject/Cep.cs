using System;

namespace SistemaComparacaoAutomatica.Domain.ValueObject
{
    public class Cep
    {
        public const int CepMaxLength = 8;
        public string CepCod { get; private set;}

        protected Cep()
        {

        }

        public Cep(string cep)
        {
            try
            {
                CepCod = cep;
            } 
            catch (Exception)
            {
                throw new Exception("CEP Inválido");
            }
        }
    }
}
