using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class Usuario
    {
        [Key] public int Id { get; set; }
        public bool isAdmin { get; set; }
        public bool isDisponibilidade { get; set; }

        [Required]
        [MaxLength(20),MinLength(5)]
        public string Nome { get; set; }
        [DisplayName("Nome da Profissão")]

        [Required]
        [MinLength(4), MaxLength(20)]
        public string NomeProfissao { get; set; }
        [DisplayName("Descrição da Profissão")]
        public string DescricaoProfissao { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Confirmação de Senha")]
        [Compare("Senha")]
        [DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; }
    }
}
