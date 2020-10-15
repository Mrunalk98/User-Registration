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
        [Phone]
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
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Password should contain minimum 8 and maximum 30 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
