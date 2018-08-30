namespace LSP.Falha
{
    public class Quadrado: Retangulo
    {
        public override void DefineAltura(int a)
        {
            altura = largura = a;
        }

        public override void DefineLargura(int l)
        {
            altura = largura = l;
        }

    }
}
