using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio
{
    class Produto
    {
        public Produto(int id, string nome, decimal valor, string tamanho, string marca)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Tamanho = tamanho;
            Marca = marca;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public object Tamanho { get; set; }
        public object Marca { get; set; }
    }
}
