using Shared.Enums;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Shared.Models
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public Guid ProductId { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser no mínimo 1.")]
        public int Quantity { get; set; }
        
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço total deve ser maior que zero.")]
        public decimal TotalPrice { get; set; }
        
        [Required]
        public OrderStatus Status { get; set; }
    }
}