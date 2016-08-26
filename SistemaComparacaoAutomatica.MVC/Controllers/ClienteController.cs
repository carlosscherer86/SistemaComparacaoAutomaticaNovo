using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SistemaComparacaoAutomatica.Application.Interface;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SistemaComparacaoAutomatica.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IUFAppService _UFAppService;
        private readonly IClienteAppService _ClienteAppService;

        public ClienteController(IUFAppService UFAppService, IClienteAppService ClienteAppService)
        {
            _UFAppService = UFAppService;
            _ClienteAppService = ClienteAppService;
        }
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowClientes()
        {
            return PartialView("ShowAll");
        }

        public string IndexAngular()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClientesViewModel>>(_ClienteAppService.GetAll());
            var jsonSerialiser = new JavaScriptSerializer();

            return JsonConvert.SerializeObject(clienteViewModel, new IsoDateTimeConverter());
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        // GET: Cliente/Create
        public string CarregarUF()
        {
            var UF = _UFAppService.GetAll();
            var jsonSerialiser = new JavaScriptSerializer();

            return JsonConvert.SerializeObject(UF, new IsoDateTimeConverter());
        }

        // POST: Cliente/Create
        [HttpPost]
        public void Create(ClientesViewModel cliente)
        {
            var ClienteDomain = Mapper.Map<ClientesViewModel, Cliente>(cliente);
            _ClienteAppService.Add(ClienteDomain);
        }

        [HttpPost]
        public string ValidaEmail(EmailViewModel email)
        {
            bool IsEmailUnique = _ClienteAppService.IsEmailUnique(email.Endereco);
            var jsonSerialiser = new JavaScriptSerializer();

            return JsonConvert.SerializeObject(IsEmailUnique, new IsoDateTimeConverter());
        }
    }
}
