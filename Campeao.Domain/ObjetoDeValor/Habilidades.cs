using System.Security.Cryptography;
using Campeao.Domain.Entities;
using Campeao.Domain.Enums;

namespace Campeao.Domain.ObjetosDeValor;

public class Habilidades
    {
        public TeclaAtivacaoEnum Tecla { get; private set; }
        public string Nome { get; private set; }
        public string Dano { get; private set; }
        public int CustoDeMana { get; private set; }
        public int TempoDeRecarga { get; private set; }
        public string Descricao { get; private set; }
        

        public Habilidades(TeclaAtivacaoEnum tecla, string nome, string dano, int custoDeMana, int tempoDeRecarga,
            string descricao)
        {
            Tecla = tecla;
            Nome = nome;
            Dano = dano;
            CustoDeMana = custoDeMana;
            TempoDeRecarga = tempoDeRecarga;
            Descricao = descricao;
        }
        public List<Habilidades> CadastrarHabilidades()
        {
            var habilidades = new List<Habilidades>();
    
            foreach (TeclaAtivacaoEnum tecla in Enum.GetValues(typeof(TeclaAtivacaoEnum)))
            {
                Console.WriteLine($"Digite o nome da Habilidade para a {tecla} (ou deixe em branco para pular):");
                string nome = Console.ReadLine();
      
                if (string.IsNullOrWhiteSpace(nome))
                    continue;
      
                Console.WriteLine($"Digite a Dano da habilidade para a {tecla}:");
                 Dano = Console.ReadLine();
      
                Console.WriteLine($"Digite o Custo de Mana da habilidade para a {tecla}:");
                 CustoDeMana = Console.ReadLine();
      
                Console.WriteLine($"Digite o Tempo de recarga da habilidade para a {tecla}:");
                 TempoDeRecarga = Console.ReadLine();
      
                Console.WriteLine($"Digite a descrição da habilidade para a {tecla}:");
                Descricao = Console.ReadLine();

                habilidades.Add(new Habilidades
                {
                    Tecla = Tecla ,
                    Nome = Nome ,
                    Dano = Dano ,
                    CustoDeMana = CustoDeMana ,
                    TempoDeRecarga = TempoDeRecarga,
                    Descricao = Descricao
                });

            }

            return habilidades;
        }
        
        public void AtribuirTecla(TeclaAtivacaoEnum teclaAtivacaoEnum) => teclaAtivacaoEnum = teclaAtivacaoEnum;
        public void AtribuirNome(string nome) => Nome = nome;
        public void AtribuirDano(string dano) => Dano = dano;
        public void AtribuirCustoDeMana(int custoDeMana) => custoDeMana = CustoDeMana;
        public void AtribuirTempoDeRecarga(int tempoDeRecarga) => tempoDeRecarga = TempoDeRecarga;
        public void AtribuirDescricao(string descricao) => Descricao = descricao;
    }