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
    
    public static CampeaoViewModel Mapear (Domain.Entities.NovoCampeao novoCampeao)
    {
        return new CampeaoViewModel()
        {
            Id = novoCampeao.Id,
            Nome = novoCampeao.Nome,
            TipoCampeao = novoCampeao.TipoCampeao,
            VidaBase = novoCampeao.VidaBase,
            ManaBase = novoCampeao.ManaBase,
            DanoAtaqueBasico = novoCampeao.DanoAtaqueBasico,
            CampeaoPosicao = novoCampeao.CampeaoPosicao,
            Passsiva = novoCampeao.Passiva,
            Habilidades = novoCampeao.Habilidades
        };
    }
}