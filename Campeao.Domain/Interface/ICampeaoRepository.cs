using Campeao.Domain.Entities;
using Campeao.Domain.Enums;
using EstartandoDevsCore.Data;
using Microsoft.Identity.Client;

namespace Campeao.Domain.Interface;

public interface ICampeaoRepository : IRepository<NovoCampeao>
{
    public List<NovoCampeao> ObterPorPosicao(List<NovoCampeao> campeaos, CampeaoPosicao pooPosicao);

    public List<NovoCampeao> ObterPorTipo(List<NovoCampeao> campeaos, Tipo tipo);

    
}