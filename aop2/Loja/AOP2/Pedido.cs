using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOP2
{
    public class Pedido
    {
        #region PROPRIEDADES DE PEDIDO

        private int pedidoId;
        private DateTime dataEmissao = DateTime.Now;
        private double valorDoProduto;
        public string _descricaoDoProduto = "Produto atualmente sem descrição";
        public int quantidadeProduto = 1;
        double _precototal;

        #endregion
       
        #region CONSTRUTOR
        public Pedido(int pedidoid, DateTime dataemissao, double valor)
        {
            this.pedidoId = pedidoid;
            this.dataEmissao = dataemissao;
            this.valorDoProduto = valor;
        }

        public Pedido(int pedidoid, DateTime dataemissao, double valor, int quantidadeProduto) : this(pedidoid, dataemissao, valor)
        {
            this.quantidadeProduto = quantidadeProduto;
        }
        #endregion


        #region MÉTODOS

        public double CalcularPrecoTotal()
        {
            return valorDoProduto * quantidadeProduto;
        }

        // --- PROPERTIES
        public int PedidoID
        {
            get { return pedidoId; }
        }

        public DateTime DataEmicao
        {
            get { return dataEmissao; }
        }
        #endregion

        public double ValorProduto
        {
            get { return valorDoProduto; }

            set { valorDoProduto = value; }
        }

        public string DescricaoProduto
        {
            get { return _descricaoDoProduto; }

            set
            {
                if(value != null && value.Length >= 7)
                {
                    _descricaoDoProduto = value;
                }
            }
        }

        // FORMATO STRING DO OBJETO PEDIDO

        public override string ToString()
        {
            return "ID: " + PedidoID +
                "\nValor : R$ " + ValorProduto.ToString("F2") +
                "\n\nQuantidade de produto(s) no pedido: " + quantidadeProduto +
                "\nValor total do pedido: R$ " + CalcularPrecoTotal().ToString("F2") 
                + "\nData de criação do pedido: " + DataEmicao +
                "\nDescrição do pedido: " + DescricaoProduto;
        }

    }
}