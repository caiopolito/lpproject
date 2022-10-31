namespace LP.Project.HerançaEncapsulamento
{
    public class Coordenador : Funcionario
    {
        public Coordenador(
            int idade, 
            string nome, 
            string sobrenome, 
            DateOnly dataNascimento, 
            string documento) : base(idade, nome, sobrenome, dataNascimento, documento)
        {
        }
    }
}
