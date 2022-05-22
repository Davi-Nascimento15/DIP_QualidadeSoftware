using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Inversion_Principles.Classes;

namespace Dependency_Inversion_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICliente cliente = new Cliente("Davi Nascimento", "(35) 99881-1355", "Rua B,10 - Alfenas-MG");

            IEmail email = new Email(cliente, "Cobrança", "Ainda não recebemos o pagamento do título X");
            email.EnviarEmail();
            
            Console.WriteLine("\n");
            
            IMensagem sms = new SMS(cliente, "Ainda não recebemos o pagamento do título X");
            sms.EnviarMensagem();
            
            Console.ReadLine();
        }
    }
}
