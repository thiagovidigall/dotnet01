﻿using System;
using System.Net.Http;
using Microsoft.Extensions.Options;
using DBlue.Bff.Compras.Extensions;

namespace DBlue.Bff.Compras.Services
{
    public interface IPagamentoService
    {
    }

    public class PagamentoService : Service, IPagamentoService
    {
        private readonly HttpClient _httpClient;

        public PagamentoService(HttpClient httpClient, IOptions<AppServicesSettings> settings)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(settings.Value.PagamentoUrl);
        }
    }
}