using Ar_Condicionado___Design_Pattern_Factory.Factories;
using Ar_Condicionado___Design_Pattern_Factory.Models.Enum;
using Ar_Condicionado___Design_Pattern_Factory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ar_Condicionado___Design_Pattern_Factory.Models {
    class ArCondicionado {

        private readonly Dictionary<Acoes, ArCondicionadoFactory> _factories;

        public ArCondicionado() {
            _factories = new Dictionary<Acoes, ArCondicionadoFactory>{
                { Acoes.Resfriamento, new ResfriamentoFactory() },
                { Acoes.Aquecimento, new AquecimentoFactory() }
            };
        }

        public IArCondicionado ExecutarCriacao(Acoes acao, double temperatura) {
            return _factories[acao].Criar(temperatura);
        }

    }
}
