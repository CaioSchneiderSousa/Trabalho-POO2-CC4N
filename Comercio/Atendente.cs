using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio
{
    class Atendente : Funcionarios
    {
        protected float nota;
        protected float salario;

        public Atendente(float nota)
        {
            this.nota = nota;
        }

        public Atendente(int id, int matricula, int cpf, string nome, string sobrenome, int filial_id) : base(id, matricula, cpf, nome, sobrenome, filial_id)
        {

        }
    }
}
