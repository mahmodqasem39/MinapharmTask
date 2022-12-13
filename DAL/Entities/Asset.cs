namespace MinapharmTask.DAL.Entities
{
    public class Asset
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Attribute>? Attributes { get; set; }
    }
}
