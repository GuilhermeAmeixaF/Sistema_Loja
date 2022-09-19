using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace AOP2
{
    public class Funcionario
    {
        private string nome
        {
            get { return nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    nome = value;
                }
            }
        }

        private int matricula
        {
            get { return matricula; }
            set
            {
                matricula = value;

            }
        }
    }
}
