using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principles.Classes
{
    internal class Email:IEmail
    {
        private ICliente cliente;
        private string assunto;
        private string mensagem;
        public Email(ICliente cliente, string assunto, string mensagem)
        {
            this.cliente = cliente;
            this.assunto = assunto;
            this.mensagem = mensagem;
        }
        public void EnviarEmail()
        {
            Console.WriteLine("Email enviado para: " + cliente.getNome + "\nAssunto: " + assunto + "\nMensagem: " + mensagem);
        }
    }
}
