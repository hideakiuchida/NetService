﻿using Bonus.BusinessEntities.DTO;
using System;


namespace Bonus.BusinessServices.Interfaces
{
    public interface IClienteServices
    {
        bool ExisteCliente(short tipodoccod, string prsnrodoc);
        ClienteEntity ObtenerCliente(string PrsCod);
    }
}