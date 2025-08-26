using Campeao.Domain.Entities;
using Campeao.Domain.Interface;
using System.Collections.Generic;
using System.Globalization;
using Campeao.Domain.Enums;
using Campeao.Domain.ObjetosDeValor;
using Microsoft.Identity.Client;

namespace Campeao.App.Service
{
    public class CampeaoService
    {
        public void CadastrarHabilidades(NovoCampeao novoCampeao)
        {
            while (true)
            {
                Console.WriteLine("Digite a tecla da habilidade (Passiva,Q,W,E,R ou 'Sair' para Finalizar: ");
                var TeclaAtivacaoEnum = Console.ReadLine();

                if (TeclaAtivacaoEnum.ToLower() == "Sair")
                    break;
                Console.Write("Digite a descrição da Habilidade: ");
                var descricao = Console.ReadLine();

                novoCampeao.Habilidades.Add(new Habilidades(TeclaAtivacaoEnum));

                Console.WriteLine($"Habilidade{TeclaAtivacaoEnum} adiciona com sucesso!\n");
            }
        }
    }
}
