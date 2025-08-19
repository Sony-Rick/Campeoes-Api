using Campeao.Domain.Entities;
using Campeao.Domain.Enums;
using Campeao.Domain.Interface;
using Campeo.Infra.Data;
using EstartandoDevsCore.Data;
using Microsoft.EntityFrameworkCore;

namespace Campeao.Infra.Repositories;

public class CampeaoRepository : ICampeaoRepository
{
  private readonly CampeaoContext _context;

  public CampeaoRepository(CampeaoContext context)
  {
    _context = context;
  }

  public IUnitOfWorks UnitOfWorks => _context;

  public async Task<NovoCampeao> ObterPorId(Guid Id)
  {
    return await _context.Campeaos.FirstOrDefaultAsync(x => x.Id == Id);
  }

  public void Adicionar(NovoCampeao entity)
  {
    _context.Campeaos.Add(entity);
  }

  public void Atualizar(NovoCampeao entity)
  {
    _context.Campeaos.Update(entity);
  }

  public void Apagar(Func<NovoCampeao, bool> predicate)
  {
    var campeao = _context.Campeaos.FirstOrDefault(predicate);
    _context.Campeaos.Remove(campeao);
  }
  public IUnitOfWorks UnitOfWork { get; }
  
  public List<NovoCampeao> ObterPorPosicao(List<NovoCampeao> campeaos, CampeaoPosicao posicao)
  {
    return _context.Campeaos.Where(c => c.CampeaoPosicao == posicao).ToList();
  }
  public List<NovoCampeao> ObterPorTipo(List<NovoCampeao> campeaos, Tipo tipo)
  {
    return _context.Campeaos.Where(c => c.TipoCampeao == tipo).ToList();
  }
  
  public void Dispose()
  {
    _context.Dispose();
  }
}