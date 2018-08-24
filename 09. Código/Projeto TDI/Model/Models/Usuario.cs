using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class Usuario
    {
        [Key] public int Id { get; set; }
        public bool isAdmin { get; set; }

        [Required]
        [MinLength(3), MaxLength(20)]
        public string Nome { get; set; }

        [Required]
        [DisplayName("Nome de usuário")]
        [MinLength(2), MaxLength(15)]
        public string NomeUsuario { get; set; }

        [Required]
        [DisplayName("Profissão")]
        [MinLength(4), MaxLength(20)]
        public string NomeProfissao { get; set; }

        [Required]
        [DisplayName("Descrição da Profissão")]
        [MinLength(10), MaxLength(50)]
        public string DescricaoProfissao { get; set; }

        [Required]
        [DisplayName("Disponibilidade")]
        public bool isDisponibilidade { get; set; }

        [Required]
        [MinLength(4), MaxLength(20)]
        [DisplayName("Estado")]
        public string Estado { get; set; }
             
        [Required]
        [MinLength(3), MaxLength(30)]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [Required]
        [MinLength(3), MaxLength(30)]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }

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
