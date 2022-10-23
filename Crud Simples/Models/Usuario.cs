using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_Simples.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatorio!")]
        [Column(TypeName = "nvarchar(12)")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O sobrenome é obrigatorio!")]
        [Column(TypeName = "nvarchar(22)")]
        public string Sobrenome { get; set; }

        [Column]
        [Range(1,199, ErrorMessage ="Idade não permitida")]
        public string Idade { get; set; }

        [Column(TypeName ="nvarchar(40)")]
        [Required(ErrorMessage = "O email é obrigatorio!")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }
    }
}
