namespace ArvoreApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Arvore arvore = new Arvore();
            arvore.Adicionar("G");
            arvore.Adicionar("A");
            arvore.Adicionar("C");
            arvore.Adicionar("B");

            arvore.MostrarCrescente();
            arvore.MostrarDecrescente();
        }
    }
}