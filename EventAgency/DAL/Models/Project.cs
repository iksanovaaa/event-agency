namespace EventAgency.Dal.Models
{
    public class Project
    {
        public Project()
        {
            this.Stages = new HashSet<Stage>();
            this.Documents = new HashSet<Document>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Budget { get; set; }
        public int CustomerId { get; set; }

        public virtual User Manager { get; set; }
        public virtual User Customer { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
