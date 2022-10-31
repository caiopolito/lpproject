namespace LP.Project.HerançaEncapsulamento
{
    public class Desenvolvedor : Funcionario
    {
        public Linguagem Linguagem { get; set; }
        public Desenvolvedor(
            int idade, 
            string nome, 
            string sobrenome, 
            DateOnly dataNascimento,
            string documento,
            Linguagem linguagem) : base(idade, nome, sobrenome, dataNascimento, documento)
        {
            Linguagem = linguagem;
        }

        private void Encapsulamento()
        {
            // Não está disponível na classe que herda, apenas na classe herdada
            // Console.WriteLine(this._documento);
            
            // Disponível em ambas as classes
            Console.WriteLine(this.Idade);

            // Não está disponível na classe herdada, porém na classe que herda
            Console.WriteLine(this.Linguagem);
        }
    }
}
