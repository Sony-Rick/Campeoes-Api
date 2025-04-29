using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Domain.Enums;
using Microsoft.Identity.Client;
using Habilidades = Domain.ObjetosdeValor.Habilidades;
using EstartandoDevsCore;
using EstartandoDevsCore.DomainObjects;


namespace Campeao.Domain.Entidades;

public class NovoCampeao : Entity, IAggregateRoot
{
    public TipoCampeao TipoCampeao { get; set; }
    
    public string Nome { get; set; }
    
    public int VidaBase { get; set; }
    
    public int ManaBase { get; set; }//ou energia achar um modo de colocar a opcao para os dois tipos//
    
    public int DanoAtaqueBasico { get; set; }

    public LaneEnum CampeaoPosicao { get; set; }
    
    public string Passiva { get; set;  }

    public List<Habilidades> Habilidades { get; set; }

    public NovoCampeao(TipoCampeao tipoCampeao, string nome, int vidaBase,int manaBase, int danoAtaqueBasico,
        LaneEnum campeaoPosicao, string passiva, Habilidades habilidades)
    {
        TipoCampeao = TipoCampeao;
        Nome = nome;
        VidaBase = vidaBase;
        ManaBase = manaBase;
        DanoAtaqueBasico = danoAtaqueBasico;
        CampeaoPosicao = CampeaoPosicao;
        Passiva = passiva;
        Habilidades = Habilidades;
    }
        
        
}
    


