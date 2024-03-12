namespace BeratenDomain
{

    public enum TransactionType
    {
        [Display(Name = "")]
        None = 0,

        [Display(Name = "Sale")]
        Sale = 4,

        [Display(Name = "Purchase")]
        Purchase = 5,

        [Display(Name = "Adjustment")]
        Adjustment = 5,
    }

    public enum SexualOrientation
    {
        [Display(Name = "")]
        None = 0,

        [Display(Name = "Other")]
        Other = 4,

        [Display(Name = "Boy")]
        Boy = 5,

        [Display(Name = "Girl")]
        Girl = 6,

        [Display(Name = "Man")]
        Man = 7,

        [Display(Name = "Woman")]
        Woman = 8,
    }
    public enum Roles
    {
        None = 0,
        Admin = 1,
        Manager = 2,
        General = 3
    }
}
