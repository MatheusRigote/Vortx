using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vortx.Application.ViewModel
{
    public class PhoneViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Key]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "The Phone number is Required.")]
        [MinLength(8)]
        [MaxLength(9)]
        [DisplayName("Phone")]
        public string Number { get; set; }

        [Required(ErrorMessage = "The DDD is Required.")]
        [MinLength(2)]
        [MaxLength(3)]
        [DisplayName("DDD")]
        public string DDD { get; set; }

        [Required(ErrorMessage = "The Type number is Required.")]
        public int Type { get; set; }
    }
}
