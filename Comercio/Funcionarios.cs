using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio
{
    abstract class Funcionarios
    {
        protected int id;
        protected int matricula;
        protected int cpf;
        protected string Nome;
        protected string sobrenome;
 

        protected Funcionarios(int id, int matricula, int cpf, string nome, string sobrenome, int filial_id)
        {
            this.id = id;
            this.matricula = matricula;
            this.cpf = cpf;
            Nome = nome;
            this.sobrenome = sobrenome;
            
        }
    }
}
