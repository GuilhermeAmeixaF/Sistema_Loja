using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AOP2
{
    public class Loja
    {
        public Pedido Pedido
        {
            get => default;
            set
            {
            }
        }

        public Funcionario Funcionario
        {
            get => default;
            set
            {
            }
        }

        // PRORAMA PRINCIPAL ---------------------------------------------------------
        static void Main()
        {

            // int opcao = int.Parse(Console.ReadLine());
            List<Pedido> lista_pedidos = new List<Pedido>();

            bool fecharPrograma = false;


            while (true)
            {
                Menu();
                OpcaoMenu(ref lista_pedidos, ref fecharPrograma);

                if (fecharPrograma == true)
                {
                    break;
                }

                Console.WriteLine("\n\n");

            }

        }

        // -------------------------------- MÉTODOS  -------------------------------- 
        // MÉTODOS DE CONSTRUÇÃO DE LOJA ---------------------------------------------------------
        public static void Menu() // CONSTRUÇÃO DO MENU
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Digite o número da operação, que deseja realizar.");
            Console.WriteLine("1 - Criar Pedido");
            Console.WriteLine("2 - Buscar Pedido");
            Console.WriteLine("3 - Remover Pedido");
            Console.WriteLine("4 - Fechar programa");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Opção : ");

        }

        // MÉTODO QUE APLICA A LÓGICA A EXECUTAR, AO ESCOLHER CADA OPÇÃO DO MENU
        public static void OpcaoMenu(ref List<Pedido> lista_pedidos, ref bool fecharPrograma)
        {
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");


            // CRIAR UM PEDIDO ------------------------------------------------------------------
            if (opcao == 1)
            {

                // ID PRODUTO
                Console.Write("Criando um novo pedido.\n");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());


                // PREÇO DO PRODUTO
                Console.Write("Valor do produto: R$ ");
                double precoProduto = double.Parse(Console.ReadLine());

                // QUANTIDADE 
                Console.Write("Unidades do produto: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());

                // MOMENTO DA CRIAÇÃO DO NOVO PEDIDO
                Console.WriteLine("Recebendo data e hora da crianção do pedido.");
                DateTime dataPedido = DateTime.Now;
                Pedido pedidoTemp = new Pedido(id, dataPedido, precoProduto, quantidadeProduto);

                bool descricaoPedido;
                Console.Write("Deseja criar uma descrição para o pedido.\n" +
                    "Digite (S para sim) e (N para não) \n[S / N] : ");
                string respost = Console.ReadLine().ToLower();

                descricaoPedido = respost == "s" ? true : false;

                if (descricaoPedido == true)
                {
                    Console.Write("Digite a descrição: ");
                    string descricao = Console.ReadLine();

                    pedidoTemp.DescricaoProduto = descricao;
                }

                lista_pedidos.Add(pedidoTemp);
            }

            // Acessar um pedido
            if (opcao == 2)
            {
               
                Console.WriteLine("BUSCAR PEDIDO ENTRE COM O ID DO PEDIDO");
                Console.Write("ID: ");
                int buscarPedido = int.Parse(Console.ReadLine());

                //List<Pedido> pedidoBuscado = lista_pedidos.FindAll(x >= x.pedidoId == buscarPedido);

                Pedido pedidoAtual = lista_pedidos.Find(pedido => pedido.PedidoID == buscarPedido);
                Console.WriteLine("\n\nDADOS DO PEDIDO :" + pedidoAtual);

            }
            if(opcao == 3)
            {
                Console.Write("Id :");
                int produto = int.Parse(Console.ReadLine()); // produto a ser removido

                Console.WriteLine("------------------- PEDIDO REMOVIDO ------------------- \n" 
                    + lista_pedidos.Find(pedido => pedido.PedidoID == produto));

                lista_pedidos.Remove(lista_pedidos.Find(pedido => pedido.PedidoID == produto));


            }
            if (opcao == 4)
            {
                fecharPrograma = true;
            }

            else
            {
                Console.WriteLine("Opção inválida. Escolha uma opção disponível");
            }
            Console.WriteLine("--------------------------------------------------");

        }

    }
}
