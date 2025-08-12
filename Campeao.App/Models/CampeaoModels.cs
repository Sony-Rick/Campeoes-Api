using System.ComponentModel.DataAnnotations;
using Campeao.Domain.Enums;
using Campeao.Domain.Entities;
using Campeao.Domain.ObjetosDeValor;

namespace Campeao.App.Models;

public class CampeaoModels
{
    [Required(ErrorMessage = "O campo {0} é obrigatorio")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "O campo {0} é obrigatorio")]
    public Tipo TipoCampeao { get; set;}
    
    [Required(ErrorMessage = "É necessario no minimo uma {0} selecionada")]
    public CampeaoPosicao Lane { get; set; }
    
    [Required(ErrorMessage = "É necessario adicionar a vida base do Campeão")]
    public int VidaBase  { get; set; }
    
    [Required(ErrorMessage = "É necessario adicionar a Mana Base do Campeao")]
    public int ManaBase { get; set; }
    
    [Required(ErrorMessage = "É necessario adicionar o Dano de Ataque Basico")]
    public int DanoAtaqueBasico { get; set; }
    
    [Required(ErrorMessage = "É necessario adicionar Passiva do Campeão")]
    public string Passiva  { get; set; }
    
    [Required(ErrorMessage = "Por Favor Adicione Todas as Habilidades do Campeão")]
    public Habilidades Habilidades { get; set; }
}