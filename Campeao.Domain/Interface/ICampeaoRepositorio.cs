using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using EstartandoDevsCore.Data;
using Campeao.Domain.Entidades;
using System.Collections.Generic;
using Domain.Enums;
using Microsoft.Identity.Client;

namespace Domain.Interface;

public interface ICampeaoRepositorio
{
    Task<IEnumerable<LaneEnum>> ObeterporLane();
    Task<IEnumerable<TipoCampeao>> ObeterporTipoCampeao();
    Task<IEnumerable<Campeao>> GetByNome(Nome nome);// Nao sei se posso fazer assim , vou deixar pra voltar quando terminar de revisar o material ;
}