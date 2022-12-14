using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryGrabber.Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Please enter a username.")]
		[StringLength(25)]
		public string Username { get; set; }

		[Required(ErrorMessage = "Please enter a first name.")]
		[StringLength(25)]
		public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please enter a password.")]
		[DataType(DataType.Password)]
		[Compare("ConfirmPassword")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Please confirm your password.")]
		[DataType(DataType.Password)]
		[Display(Name = "Confirm Password")]
		public string ConfirmPassword { get; set; }
	}
}