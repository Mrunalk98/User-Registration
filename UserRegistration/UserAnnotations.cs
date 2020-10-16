using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserRegistration
{
    public class UserAnnotations
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should contain minimum 3 and maximum 100 letters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[\\+]{1}[91]{2}\\s{1}[0-9]{10}$", ErrorMessage = "Enter a valid mobile number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailID { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*(){}<>:;_+=,./?|]).{7,}$" , ErrorMessage = "\n1.Password must have atleast 8 characters \n2.Password must have atleast one uppercase letter and one lowercase letter \n3.Password must have atleast one digit \n4.Password must have atleast one special character")]
        public string Password { get; set; }
    }
}
