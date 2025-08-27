using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Campeao.Domain.ObjetosDeValor;
using EstartandoDevsCore.DomainObjects;
using Campeao.Domain.Enums;
using EstartandoDevsCore.Ultilities;

namespace Campeao.Domain.Entities;

public class NovoCampeao : Entity, IAggregateRoot
{
    private readonly LinkedList<Habilidades> habilidades;
    public Tipo TipoCampeao { get; set; }

    private string _nome;
    public string Nome {
        get
        {
            return _nome.ToCamelCase();
        }
        set
        {
            if (value == "")
            {
                throw new ArgumentException("O nome não pode ser vazio");
            }
            _nome = value;
        } }

    private double _vida;
    public double VidaBase
    {
        get { return _vida;}

        set
        {
            if ( value  <=0 )
            {
                Console.WriteLine("Valor Inválido");
            }
            _vida = value;
        }
    }

    private double _mana;

    public double ManaBase
    {
        get { return _mana;}
        set
        {
            if (value <= 0) 
            {
                Console.WriteLine("Valor Inválido");
            }
            _mana = value;
        }
    }

    private double _danobasico;
    public double DanoAtaqueBasico
    {
        get { return _danobasico;}
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Valor Inválido");
            }
            _danobasico = value;
        }
    }

    public CampeaoPosicao CampeaoPosicao { get; set; }

    private string _passiva;

    public string Passiva
    {
        get
        {
            return _passiva.ToCamelCase();
        }
        set
        {
            if (value == "")
            {
                Console.WriteLine("Área em branco, por favor adicione a passiva ");
            }

            _passiva = value;
        }
    }

    public ICollection<Habilidades> Habilidades { get; set; }

    public NovoCampeao()
    {
        habilidades = new LinkedList<Habilidades>();
    }
    
    public NovoCampeao(Tipo tipoCampeao, string nome, double vidaBase,double manaBase, double danoAtaqueBasico,
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

    public void AtribuirTipoCampeao(Tipo tipoCampeao) => TipoCampeao = tipoCampeao;
    public void AtribuirNome(string nome) => Nome = nome;

    public void AtribuirVidaBase(double vidaBase) => VidaBase = vidaBase;

    public void AtribuirManaBase(double manaBase) => ManaBase = manaBase;

    public void AtribuirDanoAtaqueBasico(double danoAtaqueBasico) => DanoAtaqueBasico = danoAtaqueBasico;

    public void AtribuirCampeaoPosicao(CampeaoPosicao campeaoPosicao) => CampeaoPosicao = campeaoPosicao;
    public void AtribuirPassiva(string passiva) => Passiva = passiva;

    public void DefinirVida()
    {
        double vida;
        do
        {
            Console.WriteLine("Digite um valor válido para a vida :");
            double.TryParse(Console.ReadLine(), out vida);

            if (vida <= 0)
            {
                Console.WriteLine("Valor Inválido! Tente novamente.");
            }
        } while (vida <= 0);

        VidaBase = vida;

    }
    public void DefinirMana()
    {
        double mana;
        do
        {
            Console.WriteLine("Digite um valor válido para a mana :");
            double.TryParse(Console.ReadLine(), out mana);

            if (mana <= 0)
            {
                Console.WriteLine("Valor Inválido! Tente novamente.");
            }
        } while (mana <= 0);

        ManaBase = mana;

    }
    
    public void DefinirAtaqueBasico()
    {
        double ataqueBasico;
        do
        {
            Console.WriteLine("Digite um valor válido para a Ataque Basico :");
            double.TryParse(Console.ReadLine(), out ataqueBasico);

            if (ataqueBasico <= 0)
            {
                Console.WriteLine("Valor Inválido! Tente novamente.");
            }
        } while (ataqueBasico <= 0);

        DanoAtaqueBasico = ataqueBasico;

    }
    
}



