using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidade;
using Domain.Interface;

namespace Infra.Repositorio;


public class CampeaoRepositorio 
{
    private readonly List<Campeao> _campeao = new List<Campeao>();
    public void Adicionar(Campeao campeao)
    {
        _campeao.Add(campeao);
    }	

    public Campeao GetById(int id)
    {
        return _campeao.FirstOrDefault(c =>c.Id == id) ?? new Campeao();        
    }

    public IEnumerable<Campeao> GetAll()
    {
        return _campeao;
    }

    public void Update(Campeao campeao)
    {
        var CampeaoExistente = GetById(campeao.Id);
        if (CampeaoExistente != null)
        {
            CampeaoExistente.Nome = campeao.Nome;
            CampeaoExistente.lane = campeao.lane;
            CampeaoExistente.tipo = campeao.tipo;
        }
    }

    public void Delete(int id)
        {
            var campeao = GetById(id);
            if (campeao != null)
            {
                _campeao.Remove(campeao);
            }
        }
}