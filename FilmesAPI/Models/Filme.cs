using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do filme é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Titulo não pode exceder mais de 50 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O Gênero do filme é obrigatório")]
        [MaxLength(50, ErrorMessage = "O Gênero não pode exceder mais de 50 caracteres.")]
        public string Genero { get; set; }

        [Required]
        [Range(80, 500, ErrorMessage = "O filme não pode ter menos que 80 ou mais que 500 minutos")]
        public int Duracao { get; set; }

    }
}
