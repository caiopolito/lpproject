namespace LP.Project.HerançaEncapsulamento
{
    public class Funcionario
    {
        public Funcionario(
            int idade, 
            string nome, 
            string sobrenome, 
            DateOnly dataNascimento, 
            string documento)
        {
            Idade = idade;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            _documento = documento;
        }
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateOnly DataNascimento { get; set; }

        private string _documento;

        public string Documento { get => _documento; }
    }
}
