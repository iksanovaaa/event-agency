namespace EventAgency.Dal.Models
{
    public class Stage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProjectId { get; set; }

        public virtual User Employee { get; set; }
        public virtual Project Project { get; set; }
    }
}
