using Campeao.Domain.Entities;
using Campeao.Domain.Enums;
using EstartandoDevsCore.Data;

namespace Campeao.Domain.Interface;

public interface ICampeaoRepository : IRepository<NovoCampeao>
{
    public List<NovoCampeao> ObterPorPosicao(List<NovoCampeao> campeoes, CampeaoPosicao posicao);

    public List<NovoCampeao> ObterPorTipo(List<NovoCampeao> campeoes, Tipo tipo);

    
}