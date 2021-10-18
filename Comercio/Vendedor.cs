using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio
{
    class Vendedor : Funcionarios
    {
        protected float comissao;
        protected float salario;
        

        public Vendedor(float comissao)
        {
            this.comissao = comissao;
            
        }


        public Vendedor(int id, int matricula, int cpf, string nome, string sobrenome, int filial_id) : base(id, matricula, cpf, nome, sobrenome, filial_id)
        {

        }
    }
}
