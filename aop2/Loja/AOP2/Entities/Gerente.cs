using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOP2.Entities
{
    public class Gerente : Funcionario
    {
        public string Senha{ private get;  set; } // auto propertie

        // MÉTODOS 
        float CalcularDescontoMaior(float valorProduto, float descontoPercentual)
        {
            float valorComDesconto = valorProduto - (valorProduto * descontoPercentual / 100);
            return valorComDesconto;
        }

        // CONSTRUTORES

        public Gerente(string nome, int matricula, string senha) : base(nome, matricula)
        {
            this.Senha = senha;
        }
    }
}