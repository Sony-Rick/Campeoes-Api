using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidade;
using Domain.Interface;

namespace Infra.Repositories
{
    public class ChampionsRepositorio : IChampionsRepositorio 
    {
        private readonly List<Champions> _champions = new List<Champions>();

        public void Add(Champion champion)
        {
            
        }
    }
}