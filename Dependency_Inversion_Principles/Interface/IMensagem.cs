namespace Dependency_Inversion_Principles.Classes
{
    internal interface IMensagem
    {
        void EnviarMensagem();
        string Mensagem { get; set; }
        ICliente Cliente { get; set; }

    }
}