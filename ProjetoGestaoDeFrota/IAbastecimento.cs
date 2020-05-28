

namespace ProjetoGestaoDeFrota
{
    interface IAbastecimento
    {
        public double consumo();
        public double valorLitro();
        public void AlteraValorLitro(double precoLitro);
    }
}
