using System;
using System.ComponentModel.DataAnnotations;

namespace UserProject_4M.Models
{
	public class CreateViewModel
    {
		[Required]
		public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
	}

	public class SecondViewModel
	{

	}
}

