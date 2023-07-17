using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication2.Models
{
    public class Modelclass
    {
        [Required(ErrorMessage = "Please enter user name.")]

        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password")]
        public string confirmpassword { get; set; }
        [Required(ErrorMessage = "Please enter student name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter email.")]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter Address.")]
        public string Address { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string DonatingpartofOrgan { get; set; }
        [Required]
        public string problem { get; set; }
        [Required]
       public string Hospitalname { get; set; }
        [Required]
       public string Type { get; set; }
        [Required]
       public string Ambulance { get; set; }
        [Required]
       public string Beds { get; set; }
        [Required]
       public string Oxygen { get; set; }
        [Required(ErrorMessage = "Please enter phone number.")]
       public string PhoneNumber { get; set; }
        [Required]
       public string Hospitaladdress { get; set; }
        [Required(ErrorMessage = "Please enter diseases name.")]
       public string Disease { get; set; }
        [Required]

        public string Bloodgrouptype { get; set; }
        [Required]
        public string Location { get; set; }

    }
}