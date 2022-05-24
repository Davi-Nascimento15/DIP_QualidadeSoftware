namespace Dependency_Inversion_Principles.Classes
{
    internal interface ICliente
    {
        string getEmail { get; }
        string getNome { get; }
        string getTelefone { get; }
        string setEmail { set; }
        string setNome { set; }
        string setTelefone { set; }
    }
}