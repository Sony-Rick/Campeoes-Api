using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using EstartandoDevsCore.Data;
using System.Collections.Generic;
using Microsoft.Identity.Client;
using Campeao.Domain.Entidades;
using Domain.Enums;
namespace Domain.Interface;

public interface ICampeaoRepositorio
{
    List<Campeao.Domain.Entidades.Campeao> GetByNome(string Nome);
    Task<IEnumerable<LaneEnum>> ObeterPorLane();
    Task<IEnumerable<TipoCampeao>> ObeterPorTipoCampeao();
  
}