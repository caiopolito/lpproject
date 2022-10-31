namespace LP.Project.Abstração
{
    public class Palio : Carro
    {
        public Palio(string marca, string cor)
        {
            Marca = marca;
            Nome = nameof(Palio);
            Cor = cor;
        }
        public override void Desligar()
        {
            Console.WriteLine("Desvirar a chave");
        }

        public override void LigarRadio()
        {
            throw new NotImplementedException();
        }
    }
}
