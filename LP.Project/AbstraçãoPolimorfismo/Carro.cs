namespace LP.Project.Abstração
{
    public abstract class Carro : ICarro
    {
        public string Marca { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }

        public virtual void Ligar()
        {
            Console.WriteLine("Roda a chave e liga");
        }
        public abstract void Desligar();

        public abstract void LigarRadio();
    }
}
