using System.Security.Cryptography;
using Campeao.Domain.Entidade;
using Domain.Enums;

namespace Domain.ObjetosdeValor
{
    public class Habilidades
    {
        public TeclaAtivacaoEnum Tecla { get; private set; }
        public string Nome { get; private set; }
        public int Dano { get; private set; }
        public int CustoDeMana { get; private set; }
        public int TempoDeRecarga { get; private set; }
        public string Descricao { get; private set; }
        

        public Habilidades(TeclaAtivacaoEnum tecla, string nome, int dano, int custoDeMana, int tempoDeRecarga,
            string descricao)
        {
            Tecla = tecla;
            Nome = nome;
            Dano = dano;
            CustoDeMana = custoDeMana;
            TempoDeRecarga = tempoDeRecarga;
            Descricao = descricao;
        }

        public void AtribuirTecla(TeclaAtivacaoEnum teclaAtivacaoEnum) => teclaAtivacaoEnum = teclaAtivacaoEnum;
        public void AtribuirNome(string nome) => Nome = nome;
        public void AtribuirDano(int dano) => Dano = dano;
        public void AtribuirCustoDeMana(int custoDeMana) => custoDeMana = CustoDeMana;
        public void AtribuirTempoDeRecarga(int tempoDeRecarga) => tempoDeRecarga = TempoDeRecarga;
        public void AtribuirDescricao(string descricao) => Descricao = descricao;
    }
    
    
}