using Campeao.Domain.Entities;
using Campeao.Domain.Enums;
using Campeao.Domain.ObjetosDeValor;

namespace Campeao.App.ViewModels;

public class CampeaoViewModel
{
    public Guid Id { get; set; }
    
    public string Nome { get; set; }

    public Tipo TipoCampeao { get; set;  }
    
    public int VidaBase { get; set;  }
    
    public int ManaBase { get; set;  }
    
    public int DanoAtaqueBasico { get; set; }
    
    public CampeaoPosicao CampeaoPosicao { get; set;  }
    
    public string Passsiva { get; set; }
    
    public ICollection<Habilidades> Habilidades { get; set; }
    
    public static CampeaoViewModel Mapear (Domain.Entities.Campeao campeao)
    {
        return new CampeaoViewModel()
        {
            Id = campeao.Id,
            Nome = campeao.Nome,
            TipoCampeao = campeao.TipoCampeao,
            VidaBase = campeao.VidaBase,
            ManaBase = campeao.ManaBase,
            DanoAtaqueBasico = campeao.DanoAtaqueBasico,
            CampeaoPosicao = campeao.CampeaoPosicao,
            Passsiva = campeao.Passiva,
            Habilidades = campeao.Habilidades
        };
    }
}