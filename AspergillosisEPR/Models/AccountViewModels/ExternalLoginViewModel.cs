using System.ComponentModel.DataAnnotations;


namespace AspergillosisEPR.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
