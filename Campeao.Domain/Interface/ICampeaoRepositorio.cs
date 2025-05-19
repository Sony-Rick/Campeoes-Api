using EstartandoDevsCore.Data;

namespace Domain.Interface.Interface;

public interface ICampeaoRepositorio
{
    public interface ICampeaoRepositorio : IRepository<Campeao.Domain.Entidade.Campeao>
    {
        Task<IEnumerable<Campeao.Domain.Entidade.Campeao>> ObeterporLane();
        Task<IEnumerable<Campeao.Domain.Entidade.Campeao>> GetByNome();
    }
}