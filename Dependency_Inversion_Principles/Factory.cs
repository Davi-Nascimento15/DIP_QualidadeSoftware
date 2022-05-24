using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Inversion_Principles.Classes;

namespace Dependency_Inversion_Principles
{
    internal static class Factory
    {
        public static Cliente NovoCliente() { return new Cliente(); }
        public static Email NovoEmail() { return new Email(); }
        public static SMS NovoSMS() { return new SMS(); }


    }
}
