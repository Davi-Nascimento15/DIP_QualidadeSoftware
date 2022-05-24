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

        public Email() { }
        public Email(ICliente cliente, string assunto, string mensagem)
        {
            this.Cliente = cliente;
            this.Assunto = assunto;
            this.Mensagem = mensagem;
        }

        public string Assunto { get => assunto; set => assunto = value; }
        public string Mensagem { get => mensagem; set => mensagem = value; }
        public ICliente Cliente { get => cliente; set => cliente = value; }

        public void EnviarEmail()
        {
            Console.WriteLine("Email enviado para: " + Cliente.getNome + "\nAssunto: " + Assunto + "\nMensagem: " + Mensagem);
        }
    }
}
