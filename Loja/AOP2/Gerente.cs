using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOP2
{
    public class Gerente : Funcionario
    {
        private string senha;

        // MÉTODOS 
        float CalcularDescontoMaior(float valorProduto, float descontoPercentual)
        {
            float valorComDesconto = valorProduto - (valorProduto * descontoPercentual / 100);
            return valorComDesconto;
        }
    }
}