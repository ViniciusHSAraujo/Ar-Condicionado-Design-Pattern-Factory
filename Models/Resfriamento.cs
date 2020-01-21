using Ar_Condicionado___Design_Pattern_Factory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ar_Condicionado___Design_Pattern_Factory.Models {
    public class Resfriamento : IArCondicionado {

        private readonly double _temperatura;

        public Resfriamento(double temperatura) {
            _temperatura = temperatura;
        }


        public void Operar() {
            Console.WriteLine($"Resfriando a sala até a temperatura exigida de {_temperatura}ºC.");
        }
    }
}
