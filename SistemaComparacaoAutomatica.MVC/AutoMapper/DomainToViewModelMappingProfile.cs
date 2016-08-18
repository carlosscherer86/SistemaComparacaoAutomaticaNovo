using AutoMapper;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.ValueObject;
using SistemaComparacaoAutomatica.MVC.ViewModels;

namespace SistemaComparacaoAutomatica.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClientesViewModel>();
            CreateMap<UF, UFViewModel>();
            CreateMap<Email, EmailViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Cep, CepViewModel>();
        }

        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMapping";
            }
        }
    }
}