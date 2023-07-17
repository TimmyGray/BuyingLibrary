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
        //[RegularExpression(@"\w*[!@#$%^&*]+[0-9]+\w+[!@#$%^&*]*[0-9]*\w*")]
        public string Password { get; set; }

        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
