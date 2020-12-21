using System;
using Lista.classes;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            
            List<Cartao> cartao = new List<Cartao>();

                           
            cartao.Add(new Cartao( "Manoel Lima", "1234.2345.4567" ,"MasterCard", 154 , 2025));
            cartao.Add(new Cartao( "Gisele Mendes", "1234.2345.4567" ,"Elo", 134 , 2026));
            cartao.Add(new Cartao( "Felipe José", "1234.2345.4567" , "Visa", 144 , 2027));
            

            produtos.Add(new Produto(1, "Apple Watch", 3252.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.56f));
            produtos.Add(new Produto(3, "Zenfone Asus", 2552.56f));
            produtos.Add(new Produto(4, "Samsung", 2522.56f));
            produtos.Add(new Produto(5, "Motorola G8", 2222.56f));

            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "iphone XII";
            iphone.Preco = 895.45f;
            
            produtos.Add(iphone);

            foreach(Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");

            }
            
            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            Console.WriteLine("Lista alterada");

            foreach(Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }

            foreach(Cartao c in cartao){
                Console.WriteLine($" Titular: {c.Titular} - Bandeira: {c.Bandeira} -Número: {c.Numero} - Cvv: {c.Cvv} - Vencimento : {c.Vencimento}");
            }
        }
    }
}
