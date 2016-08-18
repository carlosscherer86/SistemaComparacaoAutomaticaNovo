using SistemaComparacaoAutomatica.Domain.Entities;

namespace SistemaComparacaoAutomatica.Domain.ValueObject
{
    public class Endereco
    {
        public const int EnderecoClienteMaxLength = 150;
        public string EnderecoCliente { get; private set; }

        public const int BairroClienteMaxLength = 150;
        public string Bairro { get; private set; }

        public const int CidadeClienteMaxLength = 150;
        public string Cidade { get; private set; }

        public Cep Cep { get; private set; }

        public const int ComplementoMaxLength = 150;
        public string Complemento { get; private set; }

        public const int NumeroClienteMaxLength = 50;
        public string Numero { get; private set; }

        protected Endereco()
        {

        }

        public Endereco(string enderecoCliente, string bairro, string cidade, Cep cep, string complemento, 
            string numero, UF uf )
        {
            SetEnderecoCliente(enderecoCliente);
            SetBairro(bairro);
            SetCidade(cidade);
            SetCep(cep);
            SetComplemento(complemento);
            SetNumero(Numero);
            //SetUF(uf);
                
        }

        public void SetUF(UF uf)
        {
            //this.UF = uf;
        }

        public void SetNumero(string numero)
        {
            this.Numero = numero;
        }

        public void SetComplemento(string complemento)
        {
            this.Complemento = complemento;
        }

        public void SetCep(Cep cep)
        {
            this.Cep = cep;
        }

        public void SetCidade(string cidade)
        {
            this.Cidade = cidade;
        }

        public void SetBairro(string bairro)
        {
            this.Bairro = bairro;
        }

        public void SetEnderecoCliente(string enderecoCliente)
        {
            this.EnderecoCliente = enderecoCliente;
        }
    }
}
