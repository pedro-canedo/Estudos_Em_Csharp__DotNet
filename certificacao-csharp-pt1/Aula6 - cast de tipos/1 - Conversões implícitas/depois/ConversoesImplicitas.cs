﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            int inteiro = 2_123_456_789;
            long inteiroLongo = (long)inteiro;
            Console.WriteLine(inteiroLongo);

            int inteiroLongo1 = (int)inteiroLongo;
            inteiro = inteiroLongo1;
        }
    }
}

