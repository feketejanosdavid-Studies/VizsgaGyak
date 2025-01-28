namespace API.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Result> Results { get; } = new List<Result>();

        public Player(string name)
        {
            Name = name;
        }

        public Player()
        {
        }
    }
}
