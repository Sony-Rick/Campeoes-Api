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


namespace Campeao.Domain.Entidade;

public class Campeao : Entity, IAggregateRoot
{
    private readonly LinkedList<Habilidades> habilidades;
    public TipoCampeao TipoCampeao { get; set; }
    
    public string Nome { get; set; }
    
    public int VidaBase { get; set; }
    
    public int ManaBase { get; set; }
    
    public int DanoAtaqueBasico { get; set; }

    public CampeaoPosicao CampeaoPosicao { get; set; }
    
    public string Passiva { get; set;  }

    public ICollection<Habilidades> Habilidades { get; set; }

    public Campeao()
    {
        habilidades = new LinkedList<Habilidades>();
    }
    
    public Campeao(TipoCampeao tipoCampeao, string nome, int vidaBase,int manaBase, int danoAtaqueBasico,
        CampeaoPosicao campeaoPosicao, string passiva, Habilidades habilidades)
    {
        TipoCampeao = TipoCampeao;
        Nome = nome;
        VidaBase = vidaBase;
        ManaBase = manaBase;
        DanoAtaqueBasico = danoAtaqueBasico;
        CampeaoPosicao = CampeaoPosicao;
        Passiva = passiva;
    }

    public void AtribuirTipoCampeao(TipoCampeao tipoCampeao) => TipoCampeao = tipoCampeao;
    public void AtribuirNome(string nome) => Nome = nome;

    public void AtribuirVidaBase(int vidaBase) => VidaBase = vidaBase;

    public void AtribuirManaBase(int manaBase) => ManaBase = manaBase;

    public void AtribuirDanoAtaqueBasico(int danoAtaqueBasico) => DanoAtaqueBasico = danoAtaqueBasico;

    public void AtribuirCampeaoPosicao(CampeaoPosicao campeaoPosicao) => CampeaoPosicao = campeaoPosicao;
    public void AtribuirPassiva(string passiva) => Passiva = passiva;
    
}



