﻿using Bonus.BusinessEntities.DTO;
using Bonus.BusinessServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bonus.WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        #region Private variable.

        private readonly IClienteServices _services;

        #endregion

        #region Public Constructor

        public ClienteController(IClienteServices services)
        {
            _services = services;
        }

        #endregion

        [Route("Cliente")]
        [HttpGet]
        public ClienteEntity Cliente(string prsCod)
        {
            return _services.ObtenerCliente(prsCod);
        }

        [Route("ExisteCliente")]
        [HttpGet]
        public bool ExisteCliente(int tipoDocCod, string prsNroDoc)
        {
            return _services.ExisteCliente(Convert.ToInt16(tipoDocCod), prsNroDoc);
        }
    }
}
