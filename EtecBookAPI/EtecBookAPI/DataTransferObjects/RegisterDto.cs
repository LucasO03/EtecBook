using System.ComponentModel.DataAnnotations;

namespace EtecBookAPI.DataTransferObjects;
public class RegisterDto
{
    [Required(ErrorMessage = "Informe o Nome de Usuário")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no máximo 60 caracteres")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Informe o Email de Usuário")]
    [EmailAddress(ErrorMessage = "Informe um Email Válido")]
    [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracteres")]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Informe a Senha de Usuário")]
    [StringLength(20, MinimumLength = 6,
        ErrorMessage = "A senha deve possuir no minimo 6 e no máximo 20 caracteres")]
    public string Password { get; set; }
}