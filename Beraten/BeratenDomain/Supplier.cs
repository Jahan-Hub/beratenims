namespace BeratenDomain
{
    public class Supplier:BaseEntity
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int PhoneNumber2 { get; set; }
        public int VillageId { get; set; }
        public string Address { get; set; }
        public int CompanyId { get; set; }
    }
}
