using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOP2
{
    public class Pedido
    {
        #region PROPRIEDADES DE PEDIDO

        public int pedidoId;
        DateTime DataEmissao = DateTime.Now;
        double valorDoProduto;
        string _descricaoDoProduto = "Produto atualmente sem descrição";
        double _precototal;

        #endregion


        #region CONSTRUTOR
        public Pedido(int pedidoid, DateTime dataemissao, double valor)
        {
            this.pedidoId = pedidoid;
            this.DataEmissao = dataemissao;
            this.valorDoProduto = valor;
            
        }
        #endregion

        #region MÉTODOS
        public void DescricaoProduto(string descricao)
        {
            this._descricaoDoProduto = descricao;
        }

        public double CalcularPrecoTotal(int quantidade)
        {
            double total = valorDoProduto * quantidade;
            return total  ;
        }
        #endregion

    }
}