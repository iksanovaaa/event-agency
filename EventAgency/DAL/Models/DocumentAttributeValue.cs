namespace EventAgency.Dal.Models
{
    public class DocumentAttributeValue
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int DocumentId { get; set; }
        public int TemplateAttributeId { get; set; }

        public virtual Document Document { get; set; }
        public virtual TemplateAttribute TemplateAttribute { get; set; }
    }
}
