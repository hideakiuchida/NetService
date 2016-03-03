﻿using Bonus.BusinessServices.Interfaces;
using System;

namespace Bonus.BusinessServices.Providers
{
    public class LoginServices : ILoginServices
    {
        public int Login(string usuario, string password)
        {
            string msgError = "";
            WsBonusLogin.wslogusugxSoapPortClient ws = new WsBonusLogin.wslogusugxSoapPortClient();
            int codError = ws.Execute(usuario, password, out msgError);
            Console.WriteLine(msgError);
            return 0;
        }
    }
}
