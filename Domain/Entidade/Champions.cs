using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entidade
{
    public class Champions
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Regiao { get; set; }

        public int VidaBase { get; set; }

        public int ManaBase { get; set; }//ou energia achar um modo de colocar a opcao para os dois tipos//

        public int DanoAtaqueBasico { get; set; }

        public int VelocidadeDeMovimentoBase { get; set; }

        public int RegenVida { get; set; }

        public int TempoDeRecargBase { get; set; }

        public Lane lane { get; set; }

        public  Tipo tipo {get; set; }//Adicionar mais de um tipo
    }
}