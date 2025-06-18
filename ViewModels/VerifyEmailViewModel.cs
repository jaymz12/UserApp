using System.ComponentModel.DataAnnotations;

namespace UserApplication.ViewModels
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is Required.")]
        [EmailAddress]
        public string Email { get; set; }


    }
}
