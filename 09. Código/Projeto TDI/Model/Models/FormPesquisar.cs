using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Models
{
    public class FormPesquisar
    {
        [Required]
        [DisplayName("Digite a profissão que voce deseja")]
        [MinLength(4), MaxLength(20)]
        public string CampoPesquisar { get; set; }
    }
}
