using Campeao.Domain.Entities;
using Campeao.Domain.Enums;
using EstartandoDevsCore.Data;
using Microsoft.Identity.Client;

namespace Campeao.Domain.Interface;

public interface ICampeaoRepository : IRepository<Entities.Campeao>
{
    public List<Domain.Entities.Campeao> ObterPorPosicao(List<Entities.Campeao> campeaos, CampeaoPosicao posicao)
    {
        return campeaos.Where(c => c.CampeaoPosicao == posicao).ToList();
    }

    public List<Domain.Entities.Campeao> ObterPorTipo(List<Entities.Campeao> campeaos, Tipo tipo)
    {
        return campeaos.Where(c => c.TipoCampeao == tipo).ToList();
    }
}



