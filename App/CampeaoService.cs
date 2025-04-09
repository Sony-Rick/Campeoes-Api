using Domain.Entidade;
using Domain.Interface;
using System.Collections.Generic;
using System.Globalization;
using Domain.Enums;
using Infra.Repositorio;
using Microsoft.Identity.Client;

namespace App.Service
{
    public class CampeaoService
    {
        private readonly ICampeaoRepositorio _campeaoRepositorio;

        public CampeaoService(ICampeaoRepositorio _campeaoRepositorio)
        {
            this._campeaoRepositorio = _campeaoRepositorio;
        }

        public void CriarCampeao(string Nome, string Regiao, int VidaBase, int ManaBase, int DanoAtaqueBase,
            int VelocidadeMovimentoBase, int RegenVida, int TempoDeRecarga)
        {
            var campeao = new Campeao

            {
                Id = GenerateId(),
                Nome = Nome,
                Regiao = Regiao,
                VidaBase = VidaBase,
                DanoAtaqueBasico = DanoAtaqueBase
            };
            _campeaoRepositorio.Add(campeao);
        }

        public Campeao GetCampeao(int id)
        {
                return _campeaoRepositorio.GetById(id);
        }

        public IEnumerable<Campeao> GetAllCampeaos()
        {
            return _campeaoRepositorio.GetAll();
        }

        public void DeleteCampeao(int id)
        {
            _campeaoRepositorio.Delete(id);
        }

        private int GenerateId()
        {
            var campeao = _campeaoRepositorio.GetAll();
            return campeao.Any() ? campeao.Max(c => c.Id) + 1 : 1;
        }
    }
}