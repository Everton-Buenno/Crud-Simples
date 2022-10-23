using System.ComponentModel.DataAnnotations;

namespace Crud_Simples.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
