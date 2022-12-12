using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.Core
{
    public enum OrderStatus
    {
        AWAITING_PAYMENT,
        PAID,
        CANCELLED,
        RETURNED,
        PROCESSING,
        IN_TRANSIT,
        SHIPPED,
        COMPLETED
    }

    public class Order
    {
        public Order()
        {
            this.Id = new Guid();
            this.OrderDate = DateTime.Now;
            this.OrderStatus = OrderStatus.AWAITING_PAYMENT;
        }
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? PostCode { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit")]
        public string? AddressLine1 { get; set; }
        [MaxLength(100, ErrorMessage = "Maximum 100 character limit")]
        public string? AddressLine2 { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public ICollection<OrderEntry>? Orders { get; set; }
        public double GetOrderTotal()
        {
            throw new NotImplementedException();
        }

    }
}
