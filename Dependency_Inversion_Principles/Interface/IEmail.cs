namespace Dependency_Inversion_Principles.Classes
{
    internal interface IEmail
    {
        void EnviarEmail();
        string Assunto { get; set; }
        string Mensagem { get; set; }
       ICliente Cliente { get; set; }
    }
}