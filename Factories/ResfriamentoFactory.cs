using Ar_Condicionado___Design_Pattern_Factory.Models;
using Ar_Condicionado___Design_Pattern_Factory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ar_Condicionado___Design_Pattern_Factory.Factories {
    class ResfriamentoFactory : ArCondicionadoFactory {
        public override IArCondicionado Criar(double temperatura) {
            return new Resfriamento(temperatura);
        }
    }
}
