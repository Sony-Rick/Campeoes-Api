using Campeao.Domain.Entidade;
using EstartandoDevsCore.Data;

namespace Campeao.Domain.Interface;

public interface ICampeaoRepository : IRepository<Entidade.Campeao>
{
      List<Entidade.Campeao> ObterCampeao();
      List<Entidade.Campeao> ObterPorCampeaoPosicao();
      List<Entidade.Campeao> ObterPorTipoCampeao(); 
}