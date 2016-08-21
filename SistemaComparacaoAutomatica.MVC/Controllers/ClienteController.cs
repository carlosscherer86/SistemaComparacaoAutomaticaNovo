using AutoMapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SistemaComparacaoAutomatica.Application.Interface;
using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.MVC.ViewModels;
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

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }

    public class teste
    {
        public string nome { get; set; }
        public string  sobrenome { get; set; }
    }
}
