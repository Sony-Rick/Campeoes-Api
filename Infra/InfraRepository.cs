using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidade;
using Domain.Interface;

namespace Infra.Repositories
{
    public class CampeaoRepositorio : ICampeaoRepositories
    {
        private readonly List<Campeao> _campeao <Campeao>(); 

        public void Add(Campeao campeao)
        {
            
        }
    }
}