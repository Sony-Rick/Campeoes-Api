using Campeao.App.Service;
using Campeao.Domain.Entities;
using Campeao.Domain.Enums;
using Campeao.Domain.ObjetosDeValor;
using Campeao.Infra.Repositories;

namespace Campeao.App;

public class Program
{
    static void Main(string[] args)
    {
        var repositorio = new CampeaoRepository();
        var service = CampeaoService;

        bool sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=====Cadastro de Campeões====");
            Console.WriteLine("1- Cadastrar Campeão");
            Console.WriteLine("2- Listar Campeão");
            Console.WriteLine("3 - Buscar por Id ");
            Console.WriteLine("4 - Buscar por Nome");
            Console.WriteLine("5 - Deletar Campeão ");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1" :
                    CadastrarCampeao(service);
                    break;
                case "2" :
                    ListarCampeoes(service);
                    break;
                case "3" :
                    BuscarPorId(service);
                    break;
                case"4":
                    BuscarPorNome(service);
                    break;
                case "5" :
                    DeletarCampeao(service);
                    break;
                case "0" :
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("\n Pressione qualquer tecla para continuar...");
            Console.ReadLine();
        }
    }

    static void CadastrarCampeao(CampeaoService service)
    {
        Console.WriteLine("Nome do Campeão: ");
        var nome = Console.ReadLine();
        
        Console.WriteLine("Escolha a posição(0 = Topo , 1 = Meio , 2 = Suporte, 3 = Atirador, 4 = Caçador");
        var posicao = (CampeaoPosicao)int.Parse(Console.ReadLine());

        var campeao = new NovoCampeao(nome,posicao);
        service.Adicionar(campeao);
        
        Console.WriteLine("Campeão cadastrado com sucesso");

    }

    static void ListarCampeoes(CampeaoService service)
    {
        var campeoes = service.ObterTodos();
        foreach (var c in campeoes)
        {
            Console.WriteLine($"{c.Id} - {c.Nome}({c.Posicao})");
        }
    }

    static void BuscarPorId(CampeaoService service)
    {
        Console.Write("Digite o Id do Campeão: ");
        var id = int.Parse(Console.ReadLine());
        var campeao = service.BuscarPorId(id);
        
        if (campeao != null)
            Console.WriteLine($"{campeao.Id} - {campeao.Nome}({campeao.Posicao})");
        else 
            Console.WriteLine("Campeão não encontrado! ");
    }

    static void BuscarPorNome(CampeaoService service)
    {
        Console.WriteLine("Digite o nome do campeão: ");
        var nome = Console.ReadLine();
        var campeoes = service.BuscarPorNome(nome);

        foreach (var c in campeoes)
        {
            Console.WriteLine($"{c.Id}- {c.Nome}({c.Posicao})");
        }
    }

    static void DeletarCampeao(CampeaoService service)
    {
        Console.Write("Digite o Id do campeão que deseja deletar: ");
        var id = int.Parse(Console.ReadLine());
        
        if (service.Deletar(id))
            Console.WriteLine("Campeão removido com sucesso! ");
        else 
            Console.WriteLine("Não foi possivel remover o campeão!");
    }
}
/// Encontrar um jeito de colocar as funçoes do pacote da Estartando aqui 