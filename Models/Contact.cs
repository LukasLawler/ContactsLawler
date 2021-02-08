using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContactsLawler.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Enter a contact name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter a 10 digit phone number (no formatting. ex: 8008675309 instead of (800) 867-5309.)")]
        [Range(1000000000, 9999999999, ErrorMessage ="Phone number must be valid between 1000000000 and 9999999999.")]
        public long Number { get; set; }

        [Required(ErrorMessage ="Enter an address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter a note.")]
        public string Note { get; set; }
    }
}
