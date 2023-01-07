
using System.ComponentModel.DataAnnotations;

namespace TechnoSewa.Models

{
    public class registerModel
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        [Required(ErrorMessage = "Email is required")]
        public string Email{ get; set; } = String.Empty;
        [Required(ErrorMessage = "Phone Number is required")]
        public string Phone_Number { get; set; } = String.Empty;
        public string Role { get; set; } = String.Empty;
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password{ get; set; } = String.Empty;

       
        //public string PhoneNumber { get; set; } = String.Empty;
       
        

        public static implicit operator registerModel(Task<registerModel?> v)
        {
            throw new NotImplementedException();
        }
    }
}
