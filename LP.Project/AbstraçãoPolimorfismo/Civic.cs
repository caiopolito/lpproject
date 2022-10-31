namespace LP.Project.Abstração
{
    public class Civic : Carro
    {
        public Civic(string marca, string cor)
        {
            Marca = marca;
            Nome = nameof(Civic);
            Cor = cor;
        }
        public override void Ligar()
        {
            Console.WriteLine("Aperta o botão de ligar");
        }
        public override void Desligar()
        {
            Console.WriteLine("Aperta o botão de desligar");
        }

        public override void LigarRadio()
        {
            throw new NotImplementedException();
        }
    }
}
