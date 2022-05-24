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
            ICliente cliente = Factory.NovoCliente();
            cliente.setNome = "Davi Nascimento";
            cliente.setTelefone = "(35) 99881-1355";
            cliente.setEmail = "davi@gmail.com";

            IEmail email = Factory.NovoEmail();
            email.Cliente = cliente;
            email.Assunto = "Cobrança";
            email.Mensagem ="Ainda não recebemos o pagamento do título X";
            email.EnviarEmail();
            
            Console.WriteLine("\n");

            IMensagem sms = Factory.NovoSMS();
            sms.Mensagem = "Ainda não recebemos o pagamento do título X";
            sms.Cliente= cliente;
            sms.EnviarMensagem();
            
            Console.ReadLine();
        }
    }
}
