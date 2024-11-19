using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBlue.Clientes.API.Application.Commands;
using DBlue.Core.Mediator;
using DBlue.WebAPI.Core.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DBlue.Clientes.API.Controllers
{
    public class ClientesController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClientesController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpGet("clientes")]
        public async Task<IActionResult> Index()
        {
            var resultado = await _mediatorHandler.EnviarComando(
                new RegistrarClienteCommand(Guid.NewGuid(), "Eduardo", "edu@edu.com", "30314299076"));

            return CustomResponse(resultado);
        }
    }
}
