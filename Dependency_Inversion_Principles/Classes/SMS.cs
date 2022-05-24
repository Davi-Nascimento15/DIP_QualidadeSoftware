using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Inversion_Principles;

namespace Dependency_Inversion_Principles.Classes
{
    internal class SMS: IMensagem
    {
        private ICliente cliente;
        private string mensagem;

        public SMS() { }
        public SMS(ICliente cliente, string mensagem)
        {
            this.Cliente = cliente;
            this.Mensagem = mensagem;   
        }

        public string Mensagem { get => mensagem; set => mensagem = value; }
        public ICliente Cliente { get => cliente; set => cliente = value; }

        public void EnviarMensagem()
        {
            Console.WriteLine("Mensagem enviada para o telefone: " + Cliente.getTelefone + "\nMensagem: " + Mensagem);
        }
    }
}
