using System.ComponentModel.DataAnnotations;

namespace RinhaDeBackendApi.Models
{
    public class Saldo
    {

        [Required]
        public int total { get; set; }

        [Required]
        public int limite { get; set; }

        [Required]
        public DateTime data_extrato { get; set; }


    }
}