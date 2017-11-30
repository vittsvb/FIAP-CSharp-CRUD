using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ExemploCRUD.Models
{
    public class Funcionario
    {
        [Range(1000,5000,ErrorMessage ="Preencha um código entre 1000 e 5000!")]
        [Display(Name ="Código")]
        public int Codigo { get; set; }
        [Required(ErrorMessage ="Preencha o nome")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Gênero")]
        public string Genero { get; set; }
    }
}