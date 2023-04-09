namespace Domain.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Dialogue> Dialogues { get; set; }
    }
}