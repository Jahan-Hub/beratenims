namespace BeratenDomain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; }

        [StringLength(50)]
        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime? CreatedOn { get; set; }
    }
}
