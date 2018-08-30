namespace LSP.Falha
{
    public class Retangulo
    {
        protected int altura;
        protected int largura;

        public virtual void DefineAltura(int a)
        {
            altura = a;
        }

        public virtual void DefineLargura(int l)
        {
            largura = l;
        }

        public int CalculaArea()
        {
            return altura * largura;
        }
    }
}
