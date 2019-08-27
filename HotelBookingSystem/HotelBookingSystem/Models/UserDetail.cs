//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingSystem.Models
{
    public partial class UserDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserDetail()
        {
            this.BookingDetails = new HashSet<BookingDetail>();
        }
    
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your First Name")]
        [RegularExpression("^([a-zA-Z '-]+)(?<!\\s)$", ErrorMessage = "First name contains only alphabets")]        
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your Last Name")]
        [RegularExpression("^([a-zA-Z '-]+)(?<!\\s)$", ErrorMessage = "First name contains only alphabets")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Email address should be in the format abc@abc.test.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        [DataType(DataType.Password, ErrorMessage = "Invalid password")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).{8,16}$", ErrorMessage = "Password contains one special character, one uppercase, one lowercase, minimum 8 and maximum 16 characters")]
        public string Password { get; set; }

        public int UserTypeId { get; set; }
    
        public virtual UserType UserType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}