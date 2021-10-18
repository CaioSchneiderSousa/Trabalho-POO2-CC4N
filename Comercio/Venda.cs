using System;
using System.Collections.Generic;
using System.Text;

namespace Comercio
{
    class Venda : Vendedor 
    {
        
        public float total;
        public float nota_fiscal;
        List<Produto> _produto;

        public int Id { get; set; }
        public string Data { get; set; }
        public Vendedor Vendas { get; set; }

       

        public Venda(int id, string data, Vendedor vendas)
        {
            Id = id;
            Data = data;
            Vendas = vendas;
        }
        public void Nota(Produto total)
        {
            Console.WriteLine("Nota Fiscal.");

            Console.WriteLine($"Nota numero Fiscal: {nota_fiscal}");
            Console.WriteLine($"Total da compra: {total}");
            Console.WriteLine($"Atendente: {Nome} realizado");
            Console.WriteLine($"Produtor {_produto}");

        }

        
    }
}
