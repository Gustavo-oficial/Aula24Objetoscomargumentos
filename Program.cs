using System;
using Aula23Listas;

namespace Aula24ObjetosArgumento
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Instanciamos um novo carrinho
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto("Skyrim",1, 70f);
            Produto p2 = new Produto("FIFA 20",2, 100f);
            Produto p3 = new Produto("Dualshock",3, 249.99f);
            Produto p4 = new Produto("Fone JBL",4, 150f);
            
            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

        // System.Console.WriteLine("Deseja alterar algum produto ou acrescentar?");
        // string verificar = Console.ReadLine();
        
        // if(verificar == "sim"){
        //    cart.Alterar();
        // }else{
        //     System.Console.WriteLine("Obrigado pela compra, volte sempre!");
        // }
            
            System.Console.WriteLine("Bem vindo!");
            System.Console.WriteLine("Deseja proseguir com a comprar ou remover algo, se deseja remover digite \n p1 para remover o produto 1 \n  p2 para remover o produto 2 \n  p3 para remover o produto 3 \n  p4 para remover o produto 4 \n caso deseje prosseguir aperte prosseguir");
            string resposta = Console.ReadLine();
            Console.Clear();

           if(resposta == "p1"){
                cart.Remover(p1);
                cart.Ler();
                cart.MostrarTotal();
        }else if(resposta == "p2"){
            cart.Remover(p2);
                cart.Ler();
                cart.MostrarTotal();
        }else if(resposta == "p3"){
            cart.Remover(p3);
                cart.Ler();
                cart.MostrarTotal();
        }else if(resposta == "p4"){
            cart.Remover(p4);
                cart.Ler();
                cart.MostrarTotal();
        }else{
        cart.Ler();
        cart.MostrarTotal();
        }
    
        }
    }
}