using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Inversion_Principles;

namespace Dependency_Inversion_Principles.Classes
{
    internal class SMS
    {
        private Cliente cliente;
        private string mensagem;
        public SMS(Cliente cliente, string mensagem)
        {
            this.cliente = cliente;
            this.mensagem = mensagem;   
        }

        public void EnviarMensagem()
        {
            Console.WriteLine("Mensagem enviada para o telefone: " + cliente.getTelefone + "\nMensagem: " + mensagem);
        }
    }
}
