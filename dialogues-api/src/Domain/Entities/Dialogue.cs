namespace Domain.Entities
{
    public class Dialogue
    {
        public int Id { get; set; }
        public ICollection<Turn> Turns { get; set; }

        public Dialogue()
        {
            Turns = new List<Turn>();
        }
    }
}