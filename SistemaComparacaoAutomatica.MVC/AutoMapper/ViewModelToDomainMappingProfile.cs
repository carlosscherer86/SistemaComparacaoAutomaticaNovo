using AutoMapper;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.ValueObject;
using SistemaComparacaoAutomatica.MVC.ViewModels;

namespace SistemaComparacaoAutomatica.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile :Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClientesViewModel, Cliente>();
            CreateMap<UFViewModel, UF>();
            CreateMap<EmailViewModel, Email>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<CepViewModel, Cep>();
        }

        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMapping";
            }
        }
    }
}