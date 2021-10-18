using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio
{
    class Atendimento : Funcionarios
    {
        private int _totalVenda; 
        List<Produto> _produtos;
        private int Valor;

        public Atendimento(List<Produto> produtos)
        {
            _produtos = produtos;
        }

        public void AdicionarProduto(Produto prod)
        {
            _produtos.Add(prod);
        }
        public void RemoverProduto(Produto prod)
        {
            _produtos.Remove(prod);
        }

        public void TotalProdutos(Produto prod)
        {
            _totalVenda += Valor;
        }
        public List<Produto> GetProdutos()
        {
            return _produtos;
        }


    }
}
