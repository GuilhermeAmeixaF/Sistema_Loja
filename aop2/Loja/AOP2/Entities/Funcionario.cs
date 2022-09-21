using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace AOP2
{
    public class Funcionario
    {
        private string NOME
        {
            get { return NOME; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    NOME = value;
                }
            }
        }

        private int MATRICULA
        {
            get { return MATRICULA; }
            set
            {
                MATRICULA = value;

            }
        }

        public Funcionario(string nome, int matricula)
        {
            NOME = nome;
            MATRICULA = matricula;
        }

        // CONSTRUTORES -------------------------------

    }
}
