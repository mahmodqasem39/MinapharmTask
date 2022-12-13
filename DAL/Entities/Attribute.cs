using System.ComponentModel.DataAnnotations.Schema;

namespace MinapharmTask.DAL.Entities
{
    public class Attribute
    {
        public int Id { get; set; }
        public string? AttrName { get; set; }
        public string? AttrValue { get; set; }
        public int Asset_Id { get; set; }
        [ForeignKey("Asset_Id")]
        public Asset Asset { get; set; }
    }
}
