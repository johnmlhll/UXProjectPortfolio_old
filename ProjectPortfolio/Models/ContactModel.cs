using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectPortfolio.Models
{
    /// <summary>
    /// Class definition: ContactModel Class to DataModel the Data Inputs from Online Contact Form to XML DB
    /// </summary>
    public class ContactModel
    {
        /*
         * Data Model Properties
         */
        [Display(Name="First Name")]
        [MaxLength(30, ErrorMessage = "First Name should be less than 30 characters long")]
        public string FirstName { get; set; }

        [Display(Name="Last/Family Name")]
        [Required(ErrorMessage = "Last Name is required, please enter to proceed")]
        [MinLength(2, ErrorMessage = "Last Name must be greater than 2 characters")]
        [MaxLength(50, ErrorMessage = "Last Name must be less than 50 characters long")]
        public string LastName { get; set; }

        [Display(Name="Phone Number")]
        [Phone(ErrorMessage = "Must be a recognised Phone Number")]
        [MaxLength(30, ErrorMessage = "Phone number must be less then 30 characters long")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required, please enter to proceed")]
        [EmailAddress(ErrorMessage = "Email address invalid, please try again e.g. john@gmail.com")]
        [MaxLength(50, ErrorMessage = "Email address is too long, must be below 50 characters")]
        public string Email { get; set; }

        [Display(Name="Company Name")]
        [MaxLength(50, ErrorMessage = "Companyname must be less than 50 characters long")]
        public string CompanyName { get; set; }

        [Display(Name="City / Area")]
        [MaxLength(50, ErrorMessage ="City must be less than 50 characters long")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please select your country from the dropdown list")]
        public CountryList Country { get; set; }

        [Required(ErrorMessage = "Please select your contact type from the dropdown list")]
        [Display(Name = "Contact Reason/Type")]
        public ContactType ContactReason { get; set; }

        [Required(ErrorMessage = "Message missing, please enter your message now")]
        [MinLength(2, ErrorMessage = "Message must be greater than 2 characters long")]
        [MaxLength(500, ErrorMessage = "Message must be less then 500 characters long")]
        public string Message { get; set; }
    }   
}
