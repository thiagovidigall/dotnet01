﻿using DBlue.WebApp.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBlue.WebApp.MVC.Services
{
    public interface IAutenticacaoService
    {
        Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);
        Task<UsuarioRespostaLogin> Registro(UsuarioRegistro usuarioRegistro);
    }
}
