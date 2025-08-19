using Campeao.Domain.Entities;
using Campeao.Domain.Interface;
using System.Collections.Generic;
using System.Globalization;
using Campeao.Domain.Enums;
using Microsoft.Identity.Client;

namespace Campeao.App.Service
{
    public class CampeaoService
    {
        private readonly ICampeaoRepository _campeaoRepository;

        public CampeaoService(ICampeaoRepository repository)
        {
            _campeaoRepository = repository;
        }

        public void CadastrarCampeao(NovoCampeao campeao)
        {
            _campeaoRepository.Adicionar(campeao);
        }
        public List<NovoCampeao>ListarTodos()
        {
           return _campeaoRepository.ListarTodos();
        }

        public List<NovoCampeao> BuscarPorId()
        {
            return _campeaoRepository.ObterPorId();
        }
        
    }
}

