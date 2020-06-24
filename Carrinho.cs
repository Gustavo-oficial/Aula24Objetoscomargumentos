using System;
using System.Collections.Generic;
using Aula23Listas;

namespace Aula24ObjetosArgumento
{
    public class Carrinho
    {
        
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Ler()
        {
            foreach(Produto item in carrinho)
            {
                Console.WriteLine($"Os produtos a serem adquiridos são: {item.Nome} - R$ {item.Preco} ");
            }
        }

        public void MostrarTotal()
        {
            foreach(Produto item in carrinho)
            {
                ValorTotal += item.Preco;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Total dos itens: R$ {ValorTotal} ");
            Console.ResetColor();
        }
        
       public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(z => z.codigo == _codigo).Nome  = _produtoAlterado.Nome;
            carrinho.Find(z => z.codigo == _codigo).Preco = _produtoAlterado.Preco;
        }
    
    }
}