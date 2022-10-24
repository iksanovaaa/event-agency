namespace EventAgency.Dal.Models
{
    public class DocumentTemplate
    {
        public DocumentTemplate()
        {
            this.Documents = new HashSet<Document>();
            this.Attributes = new HashSet<TemplateAttribute>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }
        public int AttributesCount { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<TemplateAttribute> Attributes { get; set; }
    }
}
