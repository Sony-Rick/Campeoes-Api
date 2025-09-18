using Campeao.App.Service;
using Campeao.Domain.Entities;
using Campeao.Domain.Enums;
using Campeao.Domain.ObjetosDeValor;
using Campeao.Infra.Repositories;

namespace Campeao.App;

public class Program
{
    static void Main()
    {
        var repositorio = new CampeaoRepository();
        var service = CampeaoService;
    }
}
