using Ar_Condicionado___Design_Pattern_Factory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ar_Condicionado___Design_Pattern_Factory.Models.Enum {
    public class Aquecimento : IArCondicionado {

        private readonly double _temperatura;

        public Aquecimento(double temperatura) {
            _temperatura = temperatura;
        }

        public void Operar() {
            Console.WriteLine($"Aquecendo a sala até a temperatura exigida de {_temperatura}ºC.");
        }
    }
}
