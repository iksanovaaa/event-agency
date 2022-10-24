using Microsoft.AspNetCore.Routing.Template;

namespace EventAgency.Dal.Models
{
    public class Document
    {
        public Document()
        {
            this.AttributeValues = new HashSet<DocumentAttributeValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ProjectId { get; set; }
        public int TemplateId { get; set; }

        public virtual Project Project { get; set; }
        public virtual DocumentTemplate Template { get; set; }
        public virtual ICollection<DocumentAttributeValue> AttributeValues { get; set; }
    }
}
