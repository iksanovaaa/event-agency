namespace EventAgency.Dal.Models
{
    public class Role
    {
        public Role()
        {
            this.UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
