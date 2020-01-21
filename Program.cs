using Ar_Condicionado___Design_Pattern_Factory.Models;
using Ar_Condicionado___Design_Pattern_Factory.Models.Enum;
using System;

namespace Ar_Condicionado___Design_Pattern_Factory {
    class Program {
        static void Main(string[] args) {
            var factory = new ArCondicionado().ExecutarCriacao(Acoes.Resfriamento, 16.5);
            factory.Operar();

            var factory2 = new ArCondicionado().ExecutarCriacao(Acoes.Aquecimento, 26);
            factory2.Operar();

            Console.ReadKey();
        }
    }
}
