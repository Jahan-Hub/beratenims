namespace BeratenDataAccess.DbModel
{
    public partial class BeratenModel : DbContext
    {
        public BeratenModel(DbContextOptions<BeratenModel> options) : base(options) { }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Login> Logins { get; set; }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
    }
}
