using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        EnumLanes enumLanes{ get; set; }

        
    }
}