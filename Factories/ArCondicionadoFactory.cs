using Ar_Condicionado___Design_Pattern_Factory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ar_Condicionado___Design_Pattern_Factory.Factories {
    public abstract class ArCondicionadoFactory {
        public abstract IArCondicionado Criar(double temperatura);

    }
}
