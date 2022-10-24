namespace EventAgency.Dal.Models
{
    public class User
    {
        public User()
        {
            this.UserRoles = new HashSet<UserRole>();
            this.ManagedProjects = new HashSet<Project>();
            this.FundedProjects = new HashSet<Project>();
            this.Stages = new HashSet<Stage>();
        }

        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<Project> ManagedProjects { get; set; }
        public virtual ICollection<Project> FundedProjects { get; set; }
        public virtual ICollection<Stage> Stages { get; set; }
    }
}
