using System;
using System.ComponentModel.DataAnnotations;

namespace Kognit.DTOs
{
    public class WalletDTO
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O valor atual deve ser maior ou igual a 0.")]
        public decimal ValorAtual { get; set; }

        [StringLength(100, ErrorMessage = "O nome do banco deve ter no máximo 100 caracteres.")]
        public string Banco { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UltimaAtualizacao { get; set; }

        // Propriedade adicional para formatar a data de atualização
        public string UltimaAtualizacaoFormatada => UltimaAtualizacao.ToString("dd/MM/yyyy HH:mm:ss");
    }

}
