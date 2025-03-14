using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidade;

namespace Domain.Interface
{
    public interface ICampeaoRepositorio
    {
        void Add(Campeao campeao);  
        Campeao GetById(int id); 
        IEnumerable<Campeao> GetAll();
        void Update( Campeao campeao );
        void Delete(int id);
    }
}