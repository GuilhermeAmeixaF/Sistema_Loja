using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace AOP2
{
    public class Estagiario : Funcionario
    {

        // Contrutor -----------------------------------------------------------------
        public Estagiario(string nome, int matricula) : base(nome, matricula)
        {

        }

        // Método ------------------------------------------------------------------------------------
        float CalcularDescontoMenor(float valorProduto, float descontoPercentual)
        {
            float valorComDesconto = valorProduto - (valorProduto * descontoPercentual / 100);
            return valorComDesconto;
        }
    }
}