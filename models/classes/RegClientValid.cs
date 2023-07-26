using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.classes
{
    public class RegClientValid
    {
        [Required(ErrorMessage ="Login required!")]
        [StringLength(20,MinimumLength = 1)]
        public string Login { get; set; }

        [Required(ErrorMessage ="Email required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password required!")]
        [StringLength (30,MinimumLength = 10)]
        [RegularExpression(@"^(?=.*\d)(?=.*[^a-zA-Z0-9\s]).*$",
            ErrorMessage ="Password must contain at least one digit and special sign")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
