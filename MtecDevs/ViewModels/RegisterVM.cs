using System.ComponentModel.DataAnnotations;

namespace MtecDevs.ViewModels;

public class RegisterVM
{
    [Display(Name = "Nome de Usuário", Prompt = "Informe seu nome de usuário")]
    [Required(ErrorMessage = "Por favor, informe seu nome de usuário")]
    public string Nome { get; set; }

    [Display(Name = "Email", Prompt = "Informe seu Email")]
    [Required(ErrorMessage = "Por favor, informe seu email")]
    public string Email { get; set; }

    [Display(Name = "Data de Nascimento", Prompt = "Informe sua data de nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
    public DateTime DataNascimento { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "Informe sua Senha")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }
    public byte TipoDevId { get; set; }
    public string Foto { get; set; }
}
