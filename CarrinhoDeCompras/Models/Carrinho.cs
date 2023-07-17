

namespace CarrinhoDeCompras.Models
{
    public class Carrinho
    {
        public int Id { get; set; }

        public decimal ValorTotal
        {
            get
            {
                return Items.Sum(i => i.Valor);
            }            
        }

        public List<Item> Items { get; set; }

    }
}
