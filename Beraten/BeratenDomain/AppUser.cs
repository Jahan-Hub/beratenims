namespace BeratenDomain
{
    public class AppUser
    {
        public AppUser()
        {
            AppUserRoles = new HashSet<AppUserRole>();
        }

        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Login Id is Required")]
        public string LoginId { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be a minimum length of 6 and a maximum length of 20")]
        public string Password { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(17)]
        [RegularExpression(pattern: @"^[0-9 ]{14}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        [StringLength(100)]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is not a valid")]
        public string Email { get; set; }


        [StringLength(50)]
        [Required(ErrorMessage = "First Name is Required")]
        public string LastName { get; set; }

        public int CompanyId { get; set; }
        public DateTime LastActiveDate { get; set; }

        public DateTime ModifiedOn { get; set; }

        [NotMapped]
        public bool IsTempPassword { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public virtual ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}