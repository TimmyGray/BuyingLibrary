using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingLibrary.models.classes
{
    public class LogClientValid
    {

        [Required(ErrorMessage ="Email  or login required!")]
        public string EmailOrLogin { get; set; }

        [Required(ErrorMessage ="Password required!")]
        public string Password { get; set; }

    }
}
