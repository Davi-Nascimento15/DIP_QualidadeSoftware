using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principles.Classes
{
    internal class Cliente : ICliente
    {
        string nome;
        string telefone;
        string email;

        public Cliente() { }
        public Cliente(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }

        public string getNome { get => nome; }
        public string setNome { set => nome = value; }
        public string getTelefone { get => telefone; }
        public string setTelefone { set => telefone = value; }
        public string getEmail { get => email; }
        public string setEmail { set => email = value; }

    }
}
