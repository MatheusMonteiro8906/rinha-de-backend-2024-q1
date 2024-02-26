using System.ComponentModel.DataAnnotations;

namespace RinhaDeBackendApi.Models
{
    public class Extrato
    {

        [Required]
        public Saldo saldo { get; set; }

        [Required]
        public List<Transacao> ultimas_transacoes { get; set; }

    }
}