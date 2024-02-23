using System.ComponentModel.DataAnnotations;

namespace RinhaDeBackendApi.Models
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O Saldo do cliente não pode ficar negativado")]
        public int Saldo { get; set; }
         
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "O filme não pode ter menos que 80 ou mais que 500 minutos")]
        public int Limite { get; set; }
    }
}