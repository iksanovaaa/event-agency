namespace EventAgency.Dal.Models
{
    public class TemplateAttribute
    {
        public TemplateAttribute()
        {
            this.AttributeValues = new HashSet<DocumentAttributeValue>();
        }

        public int Id { get; set; }
        public string DisplayName { get; set; }
        public int TemplateId { get; set; }
        public int Order { get; set; }

        public virtual DocumentTemplate Template { get; set; }
        public virtual ICollection<DocumentAttributeValue> AttributeValues { get; set; }
    }
}
