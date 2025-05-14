using Campeao.Domain.Entidades;
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
    }
}