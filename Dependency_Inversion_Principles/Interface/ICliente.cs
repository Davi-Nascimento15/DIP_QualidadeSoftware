namespace Dependency_Inversion_Principles.Classes
{
    internal interface ICliente
    {
        string getEndereco { get; }
        string getNome { get; }
        string getTelefone { get; }
        string setEndereco { set; }
        string setNome { set; }
        string setTelefone { set; }
    }
}