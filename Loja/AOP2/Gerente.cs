using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOP2
{
    public class Gerente : Funcionario
    {
        private string senha
        {
            get => default;
            set
            {
            }
        }

        public void CalcularDescontoMaior()
        {
            throw new System.NotImplementedException();
        }
    }
}