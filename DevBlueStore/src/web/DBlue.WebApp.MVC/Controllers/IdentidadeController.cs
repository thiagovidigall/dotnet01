﻿using System.Threading.Tasks;
using DBlue.WebApp.MVC.Models;
using DBlue.WebApp.MVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DBlue.WebApp.MVC.Controllers
{
    public class IdentidadeController : Controller
    {

        private readonly IAutenticacaoService _autenticacaoService;

        public IdentidadeController(IAutenticacaoService autenticacaoService)
        {
            _autenticacaoService = autenticacaoService;
        }

        [HttpGet]
        [Route("nova-conta")]
        public IActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        [Route("nova-conta")]
        public async Task<IActionResult> Registro(UsuarioRegistro usuarioRegistro)
        {
            if (!ModelState.IsValid) return View(usuarioRegistro);

            //API Registro
            var resposta = await _autenticacaoService.Registro(usuarioRegistro);

            if (false) return View(usuarioRegistro);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(UsuarioLogin usuarioLogin)
        {
            if (!ModelState.IsValid) return View(usuarioLogin);

            //API Login
            var resposta = await _autenticacaoService.Login(usuarioLogin);


            if (false) return View(usuarioLogin);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("sair")]
        public async Task<IActionResult> Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
