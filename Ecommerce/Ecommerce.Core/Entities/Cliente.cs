namespace Ecommerce.Core.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente(string nome, string sobrenome, string email, string numeroContato, string endereco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            NumeroContato = numeroContato;
            Endereco = endereco;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string NumeroContato { get; private set; }
        public string Endereco { get; private set; }
    }
}