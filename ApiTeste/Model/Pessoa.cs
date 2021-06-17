namespace ApiTeste.Model
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public long Id { get; set; }

        public string Nome { get; set; }
        
    }
}
