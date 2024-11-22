using Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        [Required]
        public DateTime ProcessedAt { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do pagamento deve ser maior que zero.")]
        public decimal Amount { get; set; }

        [Required]
        public PaymentStatus Status { get; set; }
    }
}
