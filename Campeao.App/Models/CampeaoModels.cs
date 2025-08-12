using System.ComponentModel.DataAnnotations;
using Campeao.Domain.Enums;

namespace Campeao.App.Models;

public class CampeaoModels
{
    [Required(ErrorMessage = "O campo {0} é obrigatorio")]
    public string Nome { get; set; }
    
    [Required(ErrorMessage = "O campo {0} é obrigatorio")]
    public Tipo TipoCampeao { get; set;}
    
    [Required(ErrorMessage = "É necessario no minimo uma lane selecionada")]
    public CampeaoPosicao Lane { get; set; }
    
    
}