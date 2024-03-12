namespace BeratenDomain
{
    public class Product: BaseEntity
    {
        public string ProductName { get; set; }
        //Color, Model, Brand, Origin, 
        public int CategoryId { get; set; }
        public int CurrentStockQty { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalesPrice { get; set; }
        public int CompanyId { get; set; }

    }
}
