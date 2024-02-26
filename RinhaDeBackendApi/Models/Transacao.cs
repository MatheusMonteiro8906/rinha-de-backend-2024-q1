using System.ComponentModel.DataAnnotations;

namespace RinhaDeBackendApi.Models
{
    public class Transacao
    {

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O valor da transação não pode ser menor que 0.")]
        public int Valor { get; set; }

        [Required(ErrorMessage = "O tipo da transação é obrigatório.")]
        public char Tipo { get; set; }

        [Required(ErrorMessage = "A descrição da transação é obrigatória.")]
        [MaxLength(10, ErrorMessage = "A descrição não pode exceder mais de 50 caracteres.")]
        public string Descricao { get; set; }

        [Required]
        public DateTime realizada_em { get; set; }

    }
}