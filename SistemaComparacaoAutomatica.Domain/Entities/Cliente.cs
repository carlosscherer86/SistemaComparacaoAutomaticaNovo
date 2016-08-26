using SistemaComparacaoAutomatica.CrossCutting;
using SistemaComparacaoAutomatica.Domain.ValueObject;
using System;

namespace SistemaComparacaoAutomatica.Domain.Entities
{
    public class Cliente
    {
        public int CodCliente { get; private set; }
        public byte[] Senha { get; private set; }
        public Guid TokenAlteracaoSenha { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public bool Administrador { get; private set; }
        public int UFID { get; set; }
        public virtual UF UF { get; set; }

        protected Cliente()
        {
                
        }

        public Cliente(string senha, string confirmaSenha, string nome, string sobrenome, Email email, 
            Endereco endereco, DateTime dataNascimento)
        {
            SetSenha(senha, confirmaSenha);
            SetNome(nome);
            SetSobrenome(sobrenome);
            SetEmail(email);
            SetEndereco(endereco);
            SetDataNascimento(dataNascimento);
        }

        public void SetDataNascimento(DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }

        public void SetEndereco(Endereco endereco)
        {
            this.Endereco = endereco;
        }

        public void SetEmail(Email email)
        {
            this.Email = email;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        private void SetSenha(string senha, string confirmaSenha)
        {
            if (!senha.Equals(confirmaSenha))
            {
                throw new Exception("Senhas não conferem!");
            }
            this.Senha = CriptografiaHelper.CriptografarSenha(senha);
        }

        public Guid GerarNovoTokenAlterarSenha()
        {
            this.TokenAlteracaoSenha = Guid.NewGuid();
            return this.TokenAlteracaoSenha;
        }

        public void AlterarSenha(string senhaAtual, string novaSenha, string confirmacaoSenha)
        {
            ValidarSenha(senhaAtual);
            SetSenha(novaSenha, confirmacaoSenha);
        }

        public void AlterarSenha(Guid token, string novaSenha, string confirmacaoSenha)
        {
            if (!this.TokenAlteracaoSenha.Equals(token))
            {
                throw new Exception("Token Inválido!");
            }
            SetSenha(novaSenha, confirmacaoSenha);
            GerarNovoTokenAlterarSenha();
        }

        public void ValidarSenha(string senha)
        {
            var SenhaCriptografada = CriptografiaHelper.CriptografarSenha(senha);
            if (!this.Senha.Equals(SenhaCriptografada))
            {
                throw new Exception("Senha Inválida!");
            }
        }
        public bool IsEmailUnique()
        {
            return this.Email.Endereco == null;
        }
    }
}
