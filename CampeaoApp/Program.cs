using Domain.Entidade;
using Infra.Repositorios;

var campeao = new Camepeao { Nome = "Aatrox", Tipo = enum Tipo};
Console.WriteLine($"Heroi criado:{campeao.Nome}, Tipo:{campeao.Tipo}");
