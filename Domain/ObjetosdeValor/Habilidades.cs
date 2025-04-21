using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entidade;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Domain.Enums;
using Tecla;

namespace Domain.ObjetosdeValor
{
    public class Habilidades
    {
        public TeclaAtivacaoEnum Tecla { get; private set; }
        
        public string Nome { get; private set; }
        public int Dano { get; private set;}
        
        public int CustoDeMana { get; private set; }
        public int TempoDeRecarga { get; private set; }
        public string Descricao { get; private set;}

        public Campeao Campeao { get; set; }

        public Habilidades(TeclaAtivacaoEnum tecla, string nome ,int dano, int custoDeMana,  int tempoDeRecarga, string descricao)
        {
            Tecla = tecla;
            Nome = nome;
            Dano = dano;
            CustoDeMana = custoDeMana;
            TempoDeRecarga = tempoDeRecarga;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"{Tecla};{Nome};{Dano};{CustoDeMana};{TempoDeRecarga};{Descricao}";
        }
    }
}