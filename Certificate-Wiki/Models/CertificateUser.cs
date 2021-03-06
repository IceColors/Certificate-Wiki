﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Certificate_Wiki.Models {

	public class CertificateUser : IdentityUser {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Website { get; set; }
		public string Occupation { get; set; }
		public string Country { get; set; }
		public string Description { get; set; }

		[NotMapped]
		public String ProfilePictureUrl { get; set; }

		public Byte[] ProfilePicture { get; set; }
		public bool isPrivate { get; set; }
	}
}