namespace OpenCaixa.Modelos
{
    public class Movimentacao
    {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public TipoMovimentacao TipoMovimentacao { get; set; }
        public Produto? Produto { get; set; }
        public ItemVenda? ItemVenda { get; set; }
    }

    public enum TipoMovimentacao
    {
        Entrada, Saida, Fechamento_Caixa
    }
}