namespace BeratenDomain
{
    public class Transaction: BaseEntity
    {
        public int ProductId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public TransactionType TransactionType { get; set; }
        public int UserId { get; set; }
        public int PersonId { get; set; } //customer/supplier ??
        public int CompanyId { get; set; }
    }
}
