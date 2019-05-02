using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vortx.Application.ViewModel
{
    public class CustomerViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Name is Required.")]
        [MinLength(2)]
        [MaxLength(12)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The FullName is Required.")]
        [MinLength(8)]
        [MaxLength(20)]
        [DisplayName("FullName")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "The CPF is Required.")]
        [MinLength(10)]
        [MaxLength(11)]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "The RG is Required.")]
        [MinLength(9)]
        [MaxLength(10)]
        [DisplayName("CPF")]
        public string RG { get; set; }

        [Required(ErrorMessage = "The BrithDate is Required.")]        
        [DisplayName("BirthDate")]
        public DateTime BirthDate { get; set; }

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
        [MaxLength(1)]
        public int Type { get; set; }                
    }
}
