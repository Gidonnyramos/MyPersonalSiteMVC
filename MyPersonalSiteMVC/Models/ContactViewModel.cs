using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//Add for server-side validation


namespace MyPersonalSiteMVC.Models
{
    public class ContactViewModel
    {  
        [Required(ErrorMessage = "** Name is required")]
        public string Name { get; set; }

        public string Subject { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "** Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "** Message is required")]
        [UIHint("MultilineText")]
        public string Message { get; set; }
    }
}

