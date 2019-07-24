using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MaxLength(5)]
        public String Name { get; set; }
        [Required]
        [EmailAddress]
        //[RegularExpression]
        public String Email { get; set; }
        [Required]
        public String Subject { get; set; }
        [Required]
        [MaxLength(25, ErrorMessage = "Too Long")]
        public String Message { get; set; }
    }
}
