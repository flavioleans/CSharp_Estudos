﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    class Acessar
    {
        string senha = "1234";

        public bool Login(string senha)
        {
            return this.senha == senha;
        }
    }
}
