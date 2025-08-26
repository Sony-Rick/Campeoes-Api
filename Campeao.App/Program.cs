using Campeao.App.Service;
using Campeao.Domain.Entities;
using Campeao.Domain.Enums;
using Campeao.Domain.ObjetosDeValor;
using Campeao.Infra.Repositories;

namespace Campeao.App;

public class Program
{
    static void Main()
    {
        var repositories = new CampeaoRepository();
        var service = new CampeaoService(repositories); 
        
        var habilidaddes= 

        service.CadastrarCampeao(new NovoCampeao(Tipo.Atirador, nome: Ashe, vidaBase: 1300, manaBase: 700,
            danoAtaqueBasico: 900, CampeaoPosicao.Atirador,
            passiva: "Os ataques de Ashe reduzem a velocidade do alvo e fazem com que ela cause mais dano a ele. Os Acertos Críticos de Ashe não causam dano adicional, mas reduzem ainda mais a velocidade do alvo.",
            
            new Habilidades(TeclaAtivacaoEnum.Q, nome: "Concentração", dano: "50% do dano base", custoDeMana: 60,
                tempoDeRecarga: 13,
                descricao:
                "Ashe acumula Foco ao atacar. Quando o Foco chega ao máximo, Ashe pode conjurar Concentração para consumir todos os acúmulos de Foco, aumentando temporariamente sua Velocidade de Ataque e transformando seu ataque básico em uma poderosa rajada de ataques pela duração do efeito")
            new Habilidades(TeclaAtivacaoEnum.W, nome: "Rajada", dano: "120", custoDeMana: 30, tempoDeRecarga: 8,
                    descricao:
                    "Ashe dispara flechas em cone, causando dano aumentado. Também aplica Tiro Congelado."),
            new Habilidades(TeclaAtivacaoEnum.E, nome: "Olhar do Falcão", dano: "0", custoDeMana: 50, tempoDeRecarga: 15,
                    descricao:
                    "Ashe envia seu Espírito do Falcão em uma missão de exploração em qualquer ponto do mapa."),
            new Habilidades(TeclaAtivacaoEnum.R, nome:"Flecha de Cristal Encantada",dano:"150",custoDeMana:100 ,tempoDeRecarga:130 ,descricao:"Ashe dispara um projétil de gelo em linha reta. Se a flecha colidir com um Campeão inimigo, ela causa dano e o atordoa. A duração do atordoamento depende da distância percorrida pela flecha. Além disso, unidades inimigas próximas recebem dano e lentidão."), ;
            
            
    }
}
