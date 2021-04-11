using System.ComponentModel.DataAnnotations;

namespace HAC_IN.Models
{
    public class User
    {

        [Required (ErrorMessage = "Please enter your HuntID")]
        public int Huntid { get; set; }
        [Required(ErrorMessage = "Please enter your First Name")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Please enter your Last Name")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Please enter your Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter your Role")]
        public string Role { get; set; }
        public int TAid { get; set; }
        public string TAdate { get; set; }
    }
}
