using System.ComponentModel.DataAnnotations;
namespace Tom_s_E_shop.Models
{
    public class SignUpModel
    {
        public long UserId { get; set; }

        [Required(ErrorMessage="First name is required")]
        [StringLength(50, ErrorMessage="First name cannot be longer than 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage="Email is required")]
        [EmailAddress(ErrorMessage="Invalid Email format")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Phone number is required")]
        [Phone(ErrorMessage ="Invalid phone number format")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage="Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage ="Password must be at least 6 characters long")]
        public string Password { get; set; }
        [Required(ErrorMessage="Role is required")]
        [StringLength(20, ErrorMessage="Role cannot be longer than 20 characters")]
        public string Role { get; set; }
    }
}
